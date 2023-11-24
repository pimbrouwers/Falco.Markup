module Falco.Markup.Html

open System
open System.Collections.Generic

type a(key : string, ?value : string ) =
    member internal _.attribute =
        match value with
        | Some v -> KeyValueAttr (key, v)
        | None -> NonValueAttr key

type type'(value : string) =
    inherit a("type", value)

type attr([<ParamArray>]attrs : a array) =
    static member empty = attr()
    member internal _.attributes =
        attrs |> Array.map _.attribute |> List.ofArray

let private selfClosingTags : HashSet<string> = HashSet<string>(seq { "base";"link";"meta";"hr";"br";"wbr";"img";"track";"embed";"source";"col";"input" })

[<AbstractClass>]
type x =
    val value: XmlNode
    new (node) = { value = node }

type text =
    inherit x
    new (str : string) = { inherit x(TextNode str) }

type elem =
    inherit x
    new (tag : string, attr : attr, [<ParamArray>]children : x array) =
        let a = attr.attributes
        let c = children |> Array.map _.value |> List.ofArray
        let node =
            match selfClosingTags.Contains tag with
            | false -> ParentNode ((tag, a), c)
            | true -> SelfClosingNode (tag, a)
        { inherit x(node) }
    new (tag : string) = elem(tag, attr(), [||])
    new (tag : string, attr : attr) = elem(tag, attr, [||])
    new (tag : string, [<ParamArray>] c : x array) = elem(tag, attr(), c)

[<AutoOpen>]
module Elem =
    type html =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("html", attr, children) }
        new (attr) = html(attr, Array.empty)
        new ([<ParamArray>] children) = html(attr.empty, children)

    type base' =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("base", attr, children) }
        new (attr) = base'(attr, Array.empty)
        new ([<ParamArray>] children) = base'(attr.empty, children)

    type head =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("head", attr, children) }
        new (attr) = head(attr, Array.empty)
        new ([<ParamArray>] children) = head(attr.empty, children)

    type link =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("link", attr, children) }
        new (attr) = link(attr, Array.empty)
        new ([<ParamArray>] children) = link(attr.empty, children)

    type meta =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("meta", attr, children) }
        new (attr) = meta(attr, Array.empty)
        new ([<ParamArray>] children) = meta(attr.empty, children)

    type style =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("style", attr, children) }
        new (attr) = style(attr, Array.empty)
        new ([<ParamArray>] children) = style(attr.empty, children)

    type title =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("title", attr, children) }
        new (attr) = title(attr, Array.empty)
        new ([<ParamArray>] children) = title(attr.empty, children)

    type body =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("body", attr, children) }
        new (attr) = body(attr, Array.empty)
        new ([<ParamArray>] children) = body(attr.empty, children)

    type address =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("address", attr, children) }
        new (attr) = address(attr, Array.empty)
        new ([<ParamArray>] children) = address(attr.empty, children)

    type article =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("article", attr, children) }
        new (attr) = article(attr, Array.empty)
        new ([<ParamArray>] children) = article(attr.empty, children)

    type aside =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("aside", attr, children) }
        new (attr) = aside(attr, Array.empty)
        new ([<ParamArray>] children) = aside(attr.empty, children)

    type footer =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("footer", attr, children) }
        new (attr) = footer(attr, Array.empty)
        new ([<ParamArray>] children) = footer(attr.empty, children)

    type header =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("header", attr, children) }
        new (attr) = header(attr, Array.empty)
        new ([<ParamArray>] children) = header(attr.empty, children)

    type h1 =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("h1", attr, children) }
        new (attr) = h1(attr, Array.empty)
        new ([<ParamArray>] children) = h1(attr.empty, children)

    type h2 =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("h2", attr, children) }
        new (attr) = h2(attr, Array.empty)
        new ([<ParamArray>] children) = h2(attr.empty, children)

    type h3 =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("h3", attr, children) }
        new (attr) = h3(attr, Array.empty)
        new ([<ParamArray>] children) = h3(attr.empty, children)

    type h4 =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("h4", attr, children) }
        new (attr) = h4(attr, Array.empty)
        new ([<ParamArray>] children) = h4(attr.empty, children)

    type h5 =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("h5", attr, children) }
        new (attr) = h5(attr, Array.empty)
        new ([<ParamArray>] children) = h5(attr.empty, children)

    type h6 =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("h6", attr, children) }
        new (attr) = h6(attr, Array.empty)
        new ([<ParamArray>] children) = h6(attr.empty, children)

    type main =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("main", attr, children) }
        new (attr) = main(attr, Array.empty)
        new ([<ParamArray>] children) = main(attr.empty, children)

    type nav =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("nav", attr, children) }
        new (attr) = nav(attr, Array.empty)
        new ([<ParamArray>] children) = nav(attr.empty, children)

    type section =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("section", attr, children) }
        new (attr) = section(attr, Array.empty)
        new ([<ParamArray>] children) = section(attr.empty, children)

    type blockquote =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("blockquote", attr, children) }
        new (attr) = blockquote(attr, Array.empty)
        new ([<ParamArray>] children) = blockquote(attr.empty, children)

    type dd =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("dd", attr, children) }
        new (attr) = dd(attr, Array.empty)
        new ([<ParamArray>] children) = dd(attr.empty, children)

    type div =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("div", attr, children) }
        new (attr) = div(attr, Array.empty)
        new ([<ParamArray>] children) = div(attr.empty, children)

    type dl =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("dl", attr, children) }
        new (attr) = dl(attr, Array.empty)
        new ([<ParamArray>] children) = dl(attr.empty, children)

    type dt =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("dt", attr, children) }
        new (attr) = dt(attr, Array.empty)
        new ([<ParamArray>] children) = dt(attr.empty, children)

    type figcaption =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("figcaption", attr, children) }
        new (attr) = figcaption(attr, Array.empty)
        new ([<ParamArray>] children) = figcaption(attr.empty, children)

    type figure =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("figure", attr, children) }
        new (attr) = figure(attr, Array.empty)
        new ([<ParamArray>] children) = figure(attr.empty, children)

    type hr =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("hr", attr, children) }
        new (attr) = hr(attr, Array.empty)
        new ([<ParamArray>] children) = hr(attr.empty, children)

    type li =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("li", attr, children) }
        new (attr) = li(attr, Array.empty)
        new ([<ParamArray>] children) = li(attr.empty, children)

    type menu =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("menu", attr, children) }
        new (attr) = menu(attr, Array.empty)
        new ([<ParamArray>] children) = menu(attr.empty, children)

    type ol =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("ol", attr, children) }
        new (attr) = ol(attr, Array.empty)
        new ([<ParamArray>] children) = ol(attr.empty, children)

    type p =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("p", attr, children) }
        new (attr) = p(attr, Array.empty)
        new ([<ParamArray>] children) = p(attr.empty, children)

    type pre =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("pre", attr, children) }
        new (attr) = pre(attr, Array.empty)
        new ([<ParamArray>] children) = pre(attr.empty, children)

    type ul =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("ul", attr, children) }
        new (attr) = ul(attr, Array.empty)
        new ([<ParamArray>] children) = ul(attr.empty, children)

    type a' =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("a", attr, children) }
        new (attr) = a'(attr, Array.empty)
        new ([<ParamArray>] children) = a'(attr.empty, children)

    type abbr =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("abbr", attr, children) }
        new (attr) = abbr(attr, Array.empty)
        new ([<ParamArray>] children) = abbr(attr.empty, children)

    type b =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("b", attr, children) }
        new (attr) = b(attr, Array.empty)
        new ([<ParamArray>] children) = b(attr.empty, children)

    type bdi =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("bdi", attr, children) }
        new (attr) = bdi(attr, Array.empty)
        new ([<ParamArray>] children) = bdi(attr.empty, children)

    type bdo =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("bdo", attr, children) }
        new (attr) = bdo(attr, Array.empty)
        new ([<ParamArray>] children) = bdo(attr.empty, children)

    type br =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("br", attr, children) }
        new (attr) = br(attr, Array.empty)
        new ([<ParamArray>] children) = br(attr.empty, children)

    type cite =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("cite", attr, children) }
        new (attr) = cite(attr, Array.empty)
        new ([<ParamArray>] children) = cite(attr.empty, children)

    type code =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("code", attr, children) }
        new (attr) = code(attr, Array.empty)
        new ([<ParamArray>] children) = code(attr.empty, children)

    type data =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("data", attr, children) }
        new (attr) = data(attr, Array.empty)
        new ([<ParamArray>] children) = data(attr.empty, children)

    type dfn =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("dfn", attr, children) }
        new (attr) = dfn(attr, Array.empty)
        new ([<ParamArray>] children) = dfn(attr.empty, children)

    type em =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("em", attr, children) }
        new (attr) = em(attr, Array.empty)
        new ([<ParamArray>] children) = em(attr.empty, children)

    type i =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("i", attr, children) }
        new (attr) = i(attr, Array.empty)
        new ([<ParamArray>] children) = i(attr.empty, children)

    type kbd =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("kbd", attr, children) }
        new (attr) = kbd(attr, Array.empty)
        new ([<ParamArray>] children) = kbd(attr.empty, children)

    type mark =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("mark", attr, children) }
        new (attr) = mark(attr, Array.empty)
        new ([<ParamArray>] children) = mark(attr.empty, children)

    type q =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("q", attr, children) }
        new (attr) = q(attr, Array.empty)
        new ([<ParamArray>] children) = q(attr.empty, children)

    type rp =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("rp", attr, children) }
        new (attr) = rp(attr, Array.empty)
        new ([<ParamArray>] children) = rp(attr.empty, children)

    type rt =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("rt", attr, children) }
        new (attr) = rt(attr, Array.empty)
        new ([<ParamArray>] children) = rt(attr.empty, children)

    type ruby =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("ruby", attr, children) }
        new (attr) = ruby(attr, Array.empty)
        new ([<ParamArray>] children) = ruby(attr.empty, children)

    type s =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("s", attr, children) }
        new (attr) = s(attr, Array.empty)
        new ([<ParamArray>] children) = s(attr.empty, children)

    type samp =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("samp", attr, children) }
        new (attr) = samp(attr, Array.empty)
        new ([<ParamArray>] children) = samp(attr.empty, children)

    type small =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("small", attr, children) }
        new (attr) = small(attr, Array.empty)
        new ([<ParamArray>] children) = small(attr.empty, children)

    type span =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("span", attr, children) }
        new (attr) = span(attr, Array.empty)
        new ([<ParamArray>] children) = span(attr.empty, children)

    type strong =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("strong", attr, children) }
        new (attr) = strong(attr, Array.empty)
        new ([<ParamArray>] children) = strong(attr.empty, children)

    type sub =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("sub", attr, children) }
        new (attr) = sub(attr, Array.empty)
        new ([<ParamArray>] children) = sub(attr.empty, children)

    type sup =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("sup", attr, children) }
        new (attr) = sup(attr, Array.empty)
        new ([<ParamArray>] children) = sup(attr.empty, children)

    type time =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("time", attr, children) }
        new (attr) = time(attr, Array.empty)
        new ([<ParamArray>] children) = time(attr.empty, children)

    type u =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("u", attr, children) }
        new (attr) = u(attr, Array.empty)
        new ([<ParamArray>] children) = u(attr.empty, children)

    type var =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("var", attr, children) }
        new (attr) = var(attr, Array.empty)
        new ([<ParamArray>] children) = var(attr.empty, children)

    type wbr =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("wbr", attr, children) }
        new (attr) = wbr(attr, Array.empty)
        new ([<ParamArray>] children) = wbr(attr.empty, children)

    type area =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("area", attr, children) }
        new (attr) = area(attr, Array.empty)
        new ([<ParamArray>] children) = area(attr.empty, children)

    type audio =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("audio", attr, children) }
        new (attr) = audio(attr, Array.empty)
        new ([<ParamArray>] children) = audio(attr.empty, children)

    type img =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("img", attr, children) }
        new (attr) = img(attr, Array.empty)
        new ([<ParamArray>] children) = img(attr.empty, children)

    type map =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("map", attr, children) }
        new (attr) = map(attr, Array.empty)
        new ([<ParamArray>] children) = map(attr.empty, children)

    type track =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("track", attr, children) }
        new (attr) = track(attr, Array.empty)
        new ([<ParamArray>] children) = track(attr.empty, children)

    type video =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("video", attr, children) }
        new (attr) = video(attr, Array.empty)
        new ([<ParamArray>] children) = video(attr.empty, children)

    type embed =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("embed", attr, children) }
        new (attr) = embed(attr, Array.empty)
        new ([<ParamArray>] children) = embed(attr.empty, children)

    type iframe =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("iframe", attr, children) }
        new (attr) = iframe(attr, Array.empty)
        new ([<ParamArray>] children) = iframe(attr.empty, children)

    type object =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("object", attr, children) }
        new (attr) = object(attr, Array.empty)
        new ([<ParamArray>] children) = object(attr.empty, children)

    type picture =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("picture", attr, children) }
        new (attr) = picture(attr, Array.empty)
        new ([<ParamArray>] children) = picture(attr.empty, children)

    type portal =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("portal", attr, children) }
        new (attr) = portal(attr, Array.empty)
        new ([<ParamArray>] children) = portal(attr.empty, children)

    type source =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("source", attr, children) }
        new (attr) = source(attr, Array.empty)
        new ([<ParamArray>] children) = source(attr.empty, children)

    type canvas =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("canvas", attr, children) }
        new (attr) = canvas(attr, Array.empty)
        new ([<ParamArray>] children) = canvas(attr.empty, children)

    type noscript =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("noscript", attr, children) }
        new (attr) = noscript(attr, Array.empty)
        new ([<ParamArray>] children) = noscript(attr.empty, children)

    type script =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("script", attr, children) }
        new (attr) = script(attr, Array.empty)
        new ([<ParamArray>] children) = script(attr.empty, children)

    type del =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("del", attr, children) }
        new (attr) = del(attr, Array.empty)
        new ([<ParamArray>] children) = del(attr.empty, children)

    type ins =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("ins", attr, children) }
        new (attr) = ins(attr, Array.empty)
        new ([<ParamArray>] children) = ins(attr.empty, children)

    type caption =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("caption", attr, children) }
        new (attr) = caption(attr, Array.empty)
        new ([<ParamArray>] children) = caption(attr.empty, children)

    type col =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("col", attr, children) }
        new (attr) = col(attr, Array.empty)
        new ([<ParamArray>] children) = col(attr.empty, children)

    type colgroup =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("colgroup", attr, children) }
        new (attr) = colgroup(attr, Array.empty)
        new ([<ParamArray>] children) = colgroup(attr.empty, children)

    type table =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("table", attr, children) }
        new (attr) = table(attr, Array.empty)
        new ([<ParamArray>] children) = table(attr.empty, children)

    type tbody =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("tbody", attr, children) }
        new (attr) = tbody(attr, Array.empty)
        new ([<ParamArray>] children) = tbody(attr.empty, children)

    type td =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("td", attr, children) }
        new (attr) = td(attr, Array.empty)
        new ([<ParamArray>] children) = td(attr.empty, children)

    type tfoot =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("tfoot", attr, children) }
        new (attr) = tfoot(attr, Array.empty)
        new ([<ParamArray>] children) = tfoot(attr.empty, children)

    type th =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("th", attr, children) }
        new (attr) = th(attr, Array.empty)
        new ([<ParamArray>] children) = th(attr.empty, children)

    type thead =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("thead", attr, children) }
        new (attr) = thead(attr, Array.empty)
        new ([<ParamArray>] children) = thead(attr.empty, children)

    type tr =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("tr", attr, children) }
        new (attr) = tr(attr, Array.empty)
        new ([<ParamArray>] children) = tr(attr.empty, children)

    type button =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("button", attr, children) }
        new (attr) = button(attr, Array.empty)
        new ([<ParamArray>] children) = button(attr.empty, children)

    type datalist =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("datalist", attr, children) }
        new (attr) = datalist(attr, Array.empty)
        new ([<ParamArray>] children) = datalist(attr.empty, children)

    type fieldset =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("fieldset", attr, children) }
        new (attr) = fieldset(attr, Array.empty)
        new ([<ParamArray>] children) = fieldset(attr.empty, children)

    type form =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("form", attr, children) }
        new (attr) = form(attr, Array.empty)
        new ([<ParamArray>] children) = form(attr.empty, children)

    type input =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("input", attr, children) }
        new (attr) = input(attr, Array.empty)
        new ([<ParamArray>] children) = input(attr.empty, children)

    type label =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("label", attr, children) }
        new (attr) = label(attr, Array.empty)
        new ([<ParamArray>] children) = label(attr.empty, children)

    type legend =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("legend", attr, children) }
        new (attr) = legend(attr, Array.empty)
        new ([<ParamArray>] children) = legend(attr.empty, children)

    type meter =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("meter", attr, children) }
        new (attr) = meter(attr, Array.empty)
        new ([<ParamArray>] children) = meter(attr.empty, children)

    type optgroup =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("optgroup", attr, children) }
        new (attr) = optgroup(attr, Array.empty)
        new ([<ParamArray>] children) = optgroup(attr.empty, children)

    type option =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("option", attr, children) }
        new (attr) = option(attr, Array.empty)
        new ([<ParamArray>] children) = option(attr.empty, children)

    type output =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("output", attr, children) }
        new (attr) = output(attr, Array.empty)
        new ([<ParamArray>] children) = output(attr.empty, children)

    type progress =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("progress", attr, children) }
        new (attr) = progress(attr, Array.empty)
        new ([<ParamArray>] children) = progress(attr.empty, children)

    type select =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("select", attr, children) }
        new (attr) = select(attr, Array.empty)
        new ([<ParamArray>] children) = select(attr.empty, children)

    type textarea =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("textarea", attr, children) }
        new (attr) = textarea(attr, Array.empty)
        new ([<ParamArray>] children) = textarea(attr.empty, children)

    type details =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("details", attr, children) }
        new (attr) = details(attr, Array.empty)
        new ([<ParamArray>] children) = details(attr.empty, children)

    type dialog =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("dialog", attr, children) }
        new (attr) = dialog(attr, Array.empty)
        new ([<ParamArray>] children) = dialog(attr.empty, children)

    type summary =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("summary", attr, children) }
        new (attr) = summary(attr, Array.empty)
        new ([<ParamArray>] children) = summary(attr.empty, children)

    type slot =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("slot", attr, children) }
        new (attr) = slot(attr, Array.empty)
        new ([<ParamArray>] children) = slot(attr.empty, children)

    type template =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("template", attr, children) }
        new (attr) = template(attr, Array.empty)
        new ([<ParamArray>] children) = template(attr.empty, children)

    type math =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("math", attr, children) }
        new (attr) = math(attr, Array.empty)
        new ([<ParamArray>] children) = math(attr.empty, children)

    type svg =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("svg", attr, children) }
        new (attr) = svg(attr, Array.empty)
        new ([<ParamArray>] children) = svg(attr.empty, children)

[<AutoOpen>]
module Attr =
    type async() = inherit a("async")
    type autofocus() = inherit a("autofocus")
    type autoplay() = inherit a("autoplay")
    type checked'() = inherit a("checked")
    type controls() = inherit a("controls")
    type default'() = inherit a("default")
    type defer() = inherit a("defer")
    type disabled() = inherit a("disabled")
    type formnovalidate() = inherit a("formnovalidate")
    type hidden() = inherit a("hidden")
    type ismap() = inherit a("ismap")
    type loop() = inherit a("loop")
    type multiple() = inherit a("multiple")
    type muted() = inherit a("muted")
    type novalidate() = inherit a("novalidate")
    type readonly() = inherit a("readonly")
    type required() = inherit a("required")
    type reversed() = inherit a("reversed")
    type selected() = inherit a("selected")

    type accept(value) = inherit a("accept", value)
    type acceptCharset(value) = inherit a("accept-charset", value)
    type accesskey(value) = inherit a("accesskey", value)
    type action(value) = inherit a("action", value)
    type align(value) = inherit a("align", value)
    type allow(value) = inherit a("allow", value)
    type alt(value) = inherit a("alt", value)
    type autocapitalize(value) = inherit a("autocapitalize", value)
    type autocomplete(value) = inherit a("autocomplete", value)
    type background(value) = inherit a("background", value)
    type bgcolor(value) = inherit a("bgcolor", value)
    type border(value) = inherit a("border", value)
    type buffered(value) = inherit a("buffered", value)
    type capture(value) = inherit a("capture", value)
    type challenge(value) = inherit a("challenge", value)
    type charset(value) = inherit a("charset", value)
    type cite(value) = inherit a("cite", value)
    type class'(value) = inherit a("class", value)
    type code(value) = inherit a("code", value)
    type codebase(value) = inherit a("codebase", value)
    type color(value) = inherit a("color", value)
    type cols(value) = inherit a("cols", value)
    type colspan(value) = inherit a("colspan", value)
    type content(value) = inherit a("content", value)
    type contenteditable(value) = inherit a("contenteditable", value)
    type contextmenu(value) = inherit a("contextmenu", value)
    type coords(value) = inherit a("coords", value)
    type crossorigin(value) = inherit a("crossorigin", value)
    type csp(value) = inherit a("csp", value)
    type data(value) = inherit a("data", value)
    type datetime(value) = inherit a("datetime", value)
    type decoding(value) = inherit a("decoding", value)
    type dir(value) = inherit a("dir", value)
    type dirname(value) = inherit a("dirname", value)
    type download(value) = inherit a("download", value)
    type draggable(value) = inherit a("draggable", value)
    type enctype(value) = inherit a("enctype", value)
    type enterkeyhint(value) = inherit a("enterkeyhint", value)
    type for'(value) = inherit a("for", value)
    type form(value) = inherit a("form", value)
    type formaction(value) = inherit a("formaction", value)
    type formenctype(value) = inherit a("formenctype", value)
    type formmethod(value) = inherit a("formmethod", value)
    type formtarget(value) = inherit a("formtarget", value)
    type headers(value) = inherit a("headers", value)
    type height(value) = inherit a("height", value)
    type high(value) = inherit a("high", value)
    type href(value) = inherit a("href", value)
    type hreflang(value) = inherit a("hreflang", value)
    type httpEquiv(value) = inherit a("http-equiv", value)
    type icon(value) = inherit a("icon", value)
    type id(value) = inherit a("id", value)
    type importance(value) = inherit a("importance", value)
    type integrity(value) = inherit a("integrity", value)
    type inputmode(value) = inherit a("inputmode", value)
    type itemprop(value) = inherit a("itemprop", value)
    type keytype(value) = inherit a("keytype", value)
    type kind(value) = inherit a("kind", value)
    type label(value) = inherit a("label", value)
    type lang(value) = inherit a("lang", value)
    type loading(value) = inherit a("loading", value)
    type list(value) = inherit a("list", value)
    type low(value) = inherit a("low", value)
    type max(value) = inherit a("max", value)
    type maxlength(value) = inherit a("maxlength", value)
    type minlength(value) = inherit a("minlength", value)
    type media(value) = inherit a("media", value)
    type method(value) = inherit a("method", value)
    type min(value) = inherit a("min", value)
    type name(value) = inherit a("name", value)
    type open'(value) = inherit a("open", value)
    type optimum(value) = inherit a("optimum", value)
    type pattern(value) = inherit a("pattern", value)
    type ping(value) = inherit a("ping", value)
    type placeholder(value) = inherit a("placeholder", value)
    type poster(value) = inherit a("poster", value)
    type preload(value) = inherit a("preload", value)
    type radiogroup(value) = inherit a("radiogroup", value)
    type referrerpolicy(value) = inherit a("referrerpolicy", value)
    type rel(value) = inherit a("rel", value)
    type role(value) = inherit a("role", value)
    type rows(value) = inherit a("rows", value)
    type rowspan(value) = inherit a("rowspan", value)
    type sandbox(value) = inherit a("sandbox", value)
    type scope(value) = inherit a("scope", value)
    type shape(value) = inherit a("shape", value)
    type size(value) = inherit a("size", value)
    type sizes(value) = inherit a("sizes", value)
    type slot(value) = inherit a("slot", value)
    type span(value) = inherit a("span", value)
    type spellcheck(value) = inherit a("spellcheck", value)
    type src(value) = inherit a("src", value)
    type srcdoc(value) = inherit a("srcdoc", value)
    type srclang(value) = inherit a("srclang", value)
    type srcset(value) = inherit a("srcset", value)
    type start(value) = inherit a("start", value)
    type step(value) = inherit a("step", value)
    type style(value) = inherit a("style", value)
    type tabindex(value) = inherit a("tabindex", value)
    type target(value) = inherit a("target", value)
    type title(value) = inherit a("title", value)
    type translate(value) = inherit a("translate", value)
    type type'(value) = inherit a("type", value)
    type usemap(value) = inherit a("usemap", value)
    type value(value) = inherit a("value", value)
    type width(value) = inherit a("width", value)
    type wrap(value) = inherit a("wrap", value)