    type html =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("html", attr, children) }
        new ([<ParamArray>] children) = html(attr.empty, children)

    type head =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("head", attr, children) }
        new ([<ParamArray>] children) = head(attr.empty, children)

    type style =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("style", attr, children) }
        new ([<ParamArray>] children) = style(attr.empty, children)

    type title =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("title", attr, children) }
        new ([<ParamArray>] children) = title(attr.empty, children)

    type body =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("body", attr, children) }
        new ([<ParamArray>] children) = body(attr.empty, children)

    type address =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("address", attr, children) }
        new ([<ParamArray>] children) = address(attr.empty, children)

    type article =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("article", attr, children) }
        new ([<ParamArray>] children) = article(attr.empty, children)

    type aside =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("aside", attr, children) }
        new ([<ParamArray>] children) = aside(attr.empty, children)

    type footer =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("footer", attr, children) }
        new ([<ParamArray>] children) = footer(attr.empty, children)

    type header =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("header", attr, children) }
        new ([<ParamArray>] children) = header(attr.empty, children)

    type h1 =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("h1", attr, children) }
        new ([<ParamArray>] children) = h1(attr.empty, children)

    type h2 =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("h2", attr, children) }
        new ([<ParamArray>] children) = h2(attr.empty, children)

    type h3 =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("h3", attr, children) }
        new ([<ParamArray>] children) = h3(attr.empty, children)

    type h4 =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("h4", attr, children) }
        new ([<ParamArray>] children) = h4(attr.empty, children)

    type h5 =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("h5", attr, children) }
        new ([<ParamArray>] children) = h5(attr.empty, children)

    type h6 =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("h6", attr, children) }
        new ([<ParamArray>] children) = h6(attr.empty, children)

    type main =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("main", attr, children) }
        new ([<ParamArray>] children) = main(attr.empty, children)

    type nav =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("nav", attr, children) }
        new ([<ParamArray>] children) = nav(attr.empty, children)

    type section =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("section", attr, children) }
        new ([<ParamArray>] children) = section(attr.empty, children)

    type blockquote =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("blockquote", attr, children) }
        new ([<ParamArray>] children) = blockquote(attr.empty, children)

    type dd =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("dd", attr, children) }
        new ([<ParamArray>] children) = dd(attr.empty, children)

    type div =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("div", attr, children) }
        new ([<ParamArray>] children) = div(attr.empty, children)

    type dl =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("dl", attr, children) }
        new ([<ParamArray>] children) = dl(attr.empty, children)

    type dt =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("dt", attr, children) }
        new ([<ParamArray>] children) = dt(attr.empty, children)

    type figcaption =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("figcaption", attr, children) }
        new ([<ParamArray>] children) = figcaption(attr.empty, children)

    type figure =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("figure", attr, children) }
        new ([<ParamArray>] children) = figure(attr.empty, children)

    type li =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("li", attr, children) }
        new ([<ParamArray>] children) = li(attr.empty, children)

    type menu =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("menu", attr, children) }
        new ([<ParamArray>] children) = menu(attr.empty, children)

    type ol =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("ol", attr, children) }
        new ([<ParamArray>] children) = ol(attr.empty, children)

    type p =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("p", attr, children) }
        new ([<ParamArray>] children) = p(attr.empty, children)

    type pre =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("pre", attr, children) }
        new ([<ParamArray>] children) = pre(attr.empty, children)

    type ul =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("ul", attr, children) }
        new ([<ParamArray>] children) = ul(attr.empty, children)

    type a =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("a", attr, children) }
        new ([<ParamArray>] children) = a(attr.empty, children)

    type abbr =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("abbr", attr, children) }
        new ([<ParamArray>] children) = abbr(attr.empty, children)

    type b =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("b", attr, children) }
        new ([<ParamArray>] children) = b(attr.empty, children)

    type bdi =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("bdi", attr, children) }
        new ([<ParamArray>] children) = bdi(attr.empty, children)

    type bdo =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("bdo", attr, children) }
        new ([<ParamArray>] children) = bdo(attr.empty, children)

    type cite =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("cite", attr, children) }
        new ([<ParamArray>] children) = cite(attr.empty, children)

    type code =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("code", attr, children) }
        new ([<ParamArray>] children) = code(attr.empty, children)

    type data =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("data", attr, children) }
        new ([<ParamArray>] children) = data(attr.empty, children)

    type dfn =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("dfn", attr, children) }
        new ([<ParamArray>] children) = dfn(attr.empty, children)

    type em =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("em", attr, children) }
        new ([<ParamArray>] children) = em(attr.empty, children)

    type i =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("i", attr, children) }
        new ([<ParamArray>] children) = i(attr.empty, children)

    type kbd =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("kbd", attr, children) }
        new ([<ParamArray>] children) = kbd(attr.empty, children)

    type mark =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("mark", attr, children) }
        new ([<ParamArray>] children) = mark(attr.empty, children)

    type q =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("q", attr, children) }
        new ([<ParamArray>] children) = q(attr.empty, children)

    type rp =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("rp", attr, children) }
        new ([<ParamArray>] children) = rp(attr.empty, children)

    type rt =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("rt", attr, children) }
        new ([<ParamArray>] children) = rt(attr.empty, children)

    type ruby =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("ruby", attr, children) }
        new ([<ParamArray>] children) = ruby(attr.empty, children)

    type s =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("s", attr, children) }
        new ([<ParamArray>] children) = s(attr.empty, children)

    type samp =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("samp", attr, children) }
        new ([<ParamArray>] children) = samp(attr.empty, children)

    type small =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("small", attr, children) }
        new ([<ParamArray>] children) = small(attr.empty, children)

    type span =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("span", attr, children) }
        new ([<ParamArray>] children) = span(attr.empty, children)

    type strong =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("strong", attr, children) }
        new ([<ParamArray>] children) = strong(attr.empty, children)

    type sub =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("sub", attr, children) }
        new ([<ParamArray>] children) = sub(attr.empty, children)

    type sup =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("sup", attr, children) }
        new ([<ParamArray>] children) = sup(attr.empty, children)

    type time =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("time", attr, children) }
        new ([<ParamArray>] children) = time(attr.empty, children)

    type u =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("u", attr, children) }
        new ([<ParamArray>] children) = u(attr.empty, children)

    type var =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("var", attr, children) }
        new ([<ParamArray>] children) = var(attr.empty, children)

    type area =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("area", attr, children) }
        new ([<ParamArray>] children) = area(attr.empty, children)

    type audio =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("audio", attr, children) }
        new ([<ParamArray>] children) = audio(attr.empty, children)

    type map =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("map", attr, children) }
        new ([<ParamArray>] children) = map(attr.empty, children)

    type video =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("video", attr, children) }
        new ([<ParamArray>] children) = video(attr.empty, children)

    type iframe =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("iframe", attr, children) }
        new ([<ParamArray>] children) = iframe(attr.empty, children)

    type object =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("object", attr, children) }
        new ([<ParamArray>] children) = object(attr.empty, children)

    type picture =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("picture", attr, children) }
        new ([<ParamArray>] children) = picture(attr.empty, children)

    type portal =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("portal", attr, children) }
        new ([<ParamArray>] children) = portal(attr.empty, children)

    type canvas =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("canvas", attr, children) }
        new ([<ParamArray>] children) = canvas(attr.empty, children)

    type noscript =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("noscript", attr, children) }
        new ([<ParamArray>] children) = noscript(attr.empty, children)

    type script =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("script", attr, children) }
        new ([<ParamArray>] children) = script(attr.empty, children)

    type del =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("del", attr, children) }
        new ([<ParamArray>] children) = del(attr.empty, children)

    type ins =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("ins", attr, children) }
        new ([<ParamArray>] children) = ins(attr.empty, children)

    type caption =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("caption", attr, children) }
        new ([<ParamArray>] children) = caption(attr.empty, children)

    type colgroup =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("colgroup", attr, children) }
        new ([<ParamArray>] children) = colgroup(attr.empty, children)

    type table =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("table", attr, children) }
        new ([<ParamArray>] children) = table(attr.empty, children)

    type tbody =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("tbody", attr, children) }
        new ([<ParamArray>] children) = tbody(attr.empty, children)

    type td =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("td", attr, children) }
        new ([<ParamArray>] children) = td(attr.empty, children)

    type tfoot =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("tfoot", attr, children) }
        new ([<ParamArray>] children) = tfoot(attr.empty, children)

    type th =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("th", attr, children) }
        new ([<ParamArray>] children) = th(attr.empty, children)

    type thead =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("thead", attr, children) }
        new ([<ParamArray>] children) = thead(attr.empty, children)

    type tr =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("tr", attr, children) }
        new ([<ParamArray>] children) = tr(attr.empty, children)

    type button =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("button", attr, children) }
        new ([<ParamArray>] children) = button(attr.empty, children)

    type datalist =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("datalist", attr, children) }
        new ([<ParamArray>] children) = datalist(attr.empty, children)

    type fieldset =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("fieldset", attr, children) }
        new ([<ParamArray>] children) = fieldset(attr.empty, children)

    type form =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("form", attr, children) }
        new ([<ParamArray>] children) = form(attr.empty, children)

    type label =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("label", attr, children) }
        new ([<ParamArray>] children) = label(attr.empty, children)

    type legend =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("legend", attr, children) }
        new ([<ParamArray>] children) = legend(attr.empty, children)

    type meter =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("meter", attr, children) }
        new ([<ParamArray>] children) = meter(attr.empty, children)

    type optgroup =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("optgroup", attr, children) }
        new ([<ParamArray>] children) = optgroup(attr.empty, children)

    type option =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("option", attr, children) }
        new ([<ParamArray>] children) = option(attr.empty, children)

    type output =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("output", attr, children) }
        new ([<ParamArray>] children) = output(attr.empty, children)

    type progress =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("progress", attr, children) }
        new ([<ParamArray>] children) = progress(attr.empty, children)

    type select =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("select", attr, children) }
        new ([<ParamArray>] children) = select(attr.empty, children)

    type textarea =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("textarea", attr, children) }
        new ([<ParamArray>] children) = textarea(attr.empty, children)

    type details =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("details", attr, children) }
        new ([<ParamArray>] children) = details(attr.empty, children)

    type dialog =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("dialog", attr, children) }
        new ([<ParamArray>] children) = dialog(attr.empty, children)

    type summary =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("summary", attr, children) }
        new ([<ParamArray>] children) = summary(attr.empty, children)

    type slot =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("slot", attr, children) }
        new ([<ParamArray>] children) = slot(attr.empty, children)

    type template =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("template", attr, children) }
        new ([<ParamArray>] children) = template(attr.empty, children)

    type math =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("math", attr, children) }
        new ([<ParamArray>] children) = math(attr.empty, children)

    type svg =
        inherit elem
        new (attr, [<ParamArray>] children) = { inherit elem("svg", attr, children) }
        new ([<ParamArray>] children) = svg(attr.empty, children)

