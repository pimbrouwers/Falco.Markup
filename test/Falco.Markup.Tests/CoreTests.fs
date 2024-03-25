module Falco.Tests.CoreTests

open System
open Falco.Markup
open Falco.Markup.Svg
open FsUnit.Xunit
open Xunit

[<Fact>]
let ``Text.empty should be empty`` () =
    renderNode Text.empty |> should equal String.Empty

[<Fact>]
let ``Text.raw should not be encoded`` () =
    let rawText = Text.raw "<div>"
    renderNode rawText |> should equal "<div>"

[<Fact>]
let ``Text.raw should not be encoded, but template applied`` () =
    let rawText = Text.rawf "<div>%s</div>" "falco"
    renderNode rawText |> should equal "<div>falco</div>"

[<Fact>]
let ``Text.enc should be encoded`` () =
    let encodedText = Text.enc "<div>"
    renderNode encodedText |> should equal "&lt;div&gt;"

[<Fact>]
let ``Text.comment should equal HTML comment`` () =
    let rawText = Text.comment "test comment"
    renderNode rawText |> should equal "<!-- test comment -->"

[<Fact>]
let ``Self-closing tag should render with trailing slash`` () =
    let t = Elem.createSelfClosing "hr" []
    renderNode t |> should equal "<hr />"

[<Fact>]
let ``Self-closing tag with attrs should render with trailing slash`` () =
    let t = Elem.createSelfClosing "hr" [ Attr.class' "my-class" ]
    renderNode t |> should equal "<hr class=\"my-class\" />"

[<Fact>]
let ``Standard tag should render with multiple attributes`` () =
    let t = Elem.create "div" [ Attr.create "class" "my-class"; Attr.autofocus; Attr.create "data-bind" "slider" ] []
    renderNode t |> should equal "<div class=\"my-class\" autofocus data-bind=\"slider\"></div>"

[<Fact>]
let ``Script should contain src, lang and async`` () =
    let t = Elem.script [ Attr.src "http://example.org/example.js";  Attr.lang "javascript"; Attr.async ] []
    renderNode t |> should equal "<script src=\"http://example.org/example.js\" lang=\"javascript\" async></script>"

[<Fact>]
let ``Should produce valid html doc`` () =
    let doc =
        Elem.html [] [
            Elem.body [] [
                Elem.div [ Attr.class' "my-class" ] [
                    Elem.h1 [] [ Text.raw "hello" ] ] ] ]
    renderHtml doc |> should equal "<!DOCTYPE html><html><body><div class=\"my-class\"><h1>hello</h1></div></body></html>"

[<Fact>]
let ``Elem.control should render label with nested input`` () =
    let name = "email_address"
    let label = "Email Address"
    let expected = Elem.label [ Attr.for' name ] [ 
        Elem.span [ Attr.class' "form-label" ] [ Text.raw label ]
        Elem.input [ Attr.id name; Attr.name name; Attr.typeEmail; Attr.required ] ]
    
    Elem.control name [ Attr.typeEmail; Attr.required  ] [ 
        Elem.span [ Attr.class' "form-label" ] [ Text.raw label ] ]
    |> should equal expected

[<Fact>]
let ``Text shortcuts should produce valid XmlNode`` () = 
    Text.h1 "falco" |> should equal <| Elem.h1 [] [ Text.raw "falco" ]
    Text.h2 "falco" |> should equal <| Elem.h2 [] [ Text.raw "falco" ]
    Text.h3 "falco" |> should equal <| Elem.h3 [] [ Text.raw "falco" ]
    Text.h4 "falco" |> should equal <| Elem.h4 [] [ Text.raw "falco" ]
    Text.h5 "falco" |> should equal <| Elem.h5 [] [ Text.raw "falco" ]
    Text.h6 "falco" |> should equal <| Elem.h6 [] [ Text.raw "falco" ]
    Text.p "falco" |> should equal <| Elem.p [] [ Text.raw "falco" ]
    Text.dd "falco" |> should equal <| Elem.dd [] [ Text.raw "falco" ]
    Text.dt "falco" |> should equal <| Elem.dt [] [ Text.raw "falco" ]
    Text.abbr "falco" |> should equal <| Elem.abbr [] [ Text.raw "falco" ]
    Text.b "falco" |> should equal <| Elem.b [] [ Text.raw "falco" ]
    Text.bdi "falco" |> should equal <| Elem.bdi [] [ Text.raw "falco" ]
    Text.bdo "falco" |> should equal <| Elem.bdo [] [ Text.raw "falco" ]
    Text.cite "falco" |> should equal <| Elem.cite [] [ Text.raw "falco" ]
    Text.code "falco" |> should equal <| Elem.code [] [ Text.raw "falco" ]
    Text.data "falco" |> should equal <| Elem.data [] [ Text.raw "falco" ]
    Text.dfn "falco" |> should equal <| Elem.dfn [] [ Text.raw "falco" ]
    Text.em "falco" |> should equal <| Elem.em [] [ Text.raw "falco" ]
    Text.i "falco" |> should equal <| Elem.i [] [ Text.raw "falco" ]
    Text.kbd "falco" |> should equal <| Elem.kbd [] [ Text.raw "falco" ]
    Text.mark "falco" |> should equal <| Elem.mark [] [ Text.raw "falco" ]
    Text.q "falco" |> should equal <| Elem.q [] [ Text.raw "falco" ]
    Text.rp "falco" |> should equal <| Elem.rp [] [ Text.raw "falco" ]
    Text.rt "falco" |> should equal <| Elem.rt [] [ Text.raw "falco" ]
    Text.ruby "falco" |> should equal <| Elem.ruby [] [ Text.raw "falco" ]
    Text.s "falco" |> should equal <| Elem.s [] [ Text.raw "falco" ]
    Text.samp "falco" |> should equal <| Elem.samp [] [ Text.raw "falco" ]
    Text.small "falco" |> should equal <| Elem.small [] [ Text.raw "falco" ]
    Text.span "falco" |> should equal <| Elem.span [] [ Text.raw "falco" ]
    Text.strong "falco" |> should equal <| Elem.strong [] [ Text.raw "falco" ]
    Text.sub "falco" |> should equal <| Elem.sub [] [ Text.raw "falco" ]
    Text.sup "falco" |> should equal <| Elem.sup [] [ Text.raw "falco" ]
    Text.time "falco" |> should equal <| Elem.time [] [ Text.raw "falco" ]
    Text.u "falco" |> should equal <| Elem.u [] [ Text.raw "falco" ]
    Text.var "falco" |> should equal <| Elem.var [] [ Text.raw "falco" ]

[<Fact>]
let ``Should create valid html button`` () =
    let doc = Elem.button [ Attr.onclick "console.log(\"test\")"] [ Text.raw "click me" ]
    renderNode doc |> should equal "<button onclick=\"console.log(\"test\")\">click me</button>";

[<Fact>]
let ``Should produce valid xml doc`` () =
    let doc =
        Elem.create "books" [] [
            Elem.create "book" [] [
                Elem.create "name" [] [ Text.raw "To Kill A Mockingbird" ]
            ]
        ]

    renderXml doc |> should equal "<?xml version=\"1.0\" encoding=\"UTF-8\"?><books><book><name>To Kill A Mockingbird</name></book></books>"

[<Fact>]
let ``Should produce valid svg`` () =
    // https://developer.mozilla.org/en-US/docs/Web/SVG/Element/text#example
    let doc =
        Templates.svg (0, 0, 240, 80) [
            Elem.style [] [
                Text.raw ".small { font: italic 13px sans-serif; }"
                Text.raw ".heavy { font: bold 30px sans-serif; }"
                Text.raw ".Rrrrr { font: italic 40px serif; fill: red; }"
            ]
            Elem.text [ Attr.x "20"; Attr.y "35"; Attr.class' "small" ] [ Text.raw "My" ]
            Elem.text [ Attr.x "40"; Attr.y "35"; Attr.class' "heavy" ] [ Text.raw "cat" ]
            Elem.text [ Attr.x "55"; Attr.y "55"; Attr.class' "small" ] [ Text.raw "is" ]
            Elem.text [ Attr.x "65"; Attr.y "55"; Attr.class' "Rrrrr" ] [ Text.raw "Grumpy!" ]
        ]

    renderNode doc |> should equal "<svg viewBox=\"0 0 240 80\" xmlns=\"http://www.w3.org/2000/svg\"><style>.small { font: italic 13px sans-serif; }.heavy { font: bold 30px sans-serif; }.Rrrrr { font: italic 40px serif; fill: red; }</style><text x=\"20\" y=\"35\" class=\"small\">My</text><text x=\"40\" y=\"35\" class=\"heavy\">cat</text><text x=\"55\" y=\"55\" class=\"small\">is</text><text x=\"65\" y=\"55\" class=\"Rrrrr\">Grumpy!</text></svg>"

type Product =
    { Name : string
      Price : float
      Description : string }

[<Fact>]
let ``Should produce valid html doc for large result`` () =
    let lorem = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum";

    let products =
        [ 1..25000 ]
        |> List.map (fun i -> { Name = sprintf "Name %i" i; Price = i |> float; Description = lorem})

    let elem product =
        Elem.li [] [
            Elem.h2 [] [ Text.raw product.Name ]
            Text.rawf "Only %f" product.Price
            Text.raw product.Description ]

    let productElems =
        products
        |> List.map elem
        |> Elem.ul [ Attr.id "products" ]

    let doc =
        Elem.html [] [
            Elem.body [] [
                Elem.div [ Attr.class' "my-class" ] [ productElems ] ] ]

    let render = renderHtml doc
    render |> fun s -> s.Substring(0, 27) |> should equal "<!DOCTYPE html><html><body>"
    render |> fun s -> s.Substring(s.Length - 14, 14) |> should equal "</body></html>"

[<Fact>]
let ``Attr.merge should combine two XmlAttribute lists`` () =
    Attr.merge
        [ Attr.class' "ma2"; Attr.id "el" ]
        [ Attr.id "some-el"; Attr.class' "bg-red"; Attr.readonly ]
    |> should equal [ Attr.class' "ma2 bg-red"; Attr.id "some-el"; Attr.readonly ]

[<Fact>]
let ``Attr.merge should work with bogus "class" NonValueAttr`` () =
    Attr.merge
        [ Attr.class' "ma2" ]
        [ Attr.id "some-el"; Attr.class' "bg-red"; NonValueAttr("class") ]
    |> should equal [ Attr.class' "ma2 bg-red"; Attr.id "some-el" ]

[<Fact>]
let ``Attr.merge should combine two XmlAttribute lists factoring additive attributes`` () =
    Attr.merge
        [ Attr.name "test"; Attr.class' "ma2"; Attr.style "background: red"; Attr.accept "image/jpeg" ]
        [ Attr.name "expected"; Attr.class' "pa2"; Attr.style "color: white"; Attr.accept "image/png" ]
    |> should equal [ Attr.name "expected"; Attr.class' "ma2 pa2"; Attr.style "background: red; color: white"; Attr.accept "image/jpeg, image/png" ]