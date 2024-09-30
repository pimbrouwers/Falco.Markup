module Falco.Tests.Text

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
