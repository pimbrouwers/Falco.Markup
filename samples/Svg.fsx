#r "nuget: Falco.Markup"

open Falco.Markup
open Falco.Markup.Svg

// https://developer.mozilla.org/en-US/docs/Web/SVG/Element/text#example
let svg =
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
    |> renderNode

printfn "%s" svg