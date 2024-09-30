module Falco.Tests.Attr

open System
open Falco.Markup
open FsUnit.Xunit
open Xunit

[<Fact>]
let ``Attr.valueString should invoke ToString member with no parameters`` () =
    Attr.valueString 1 |> should equal <| Attr.value "1"

[<Fact>]
let ``Attr.valueStringf should invoke ToString member with format parameter`` () =
    Attr.valueStringf "F2" 1.2345 |> should equal <| Attr.value "1.23"

[<Fact>]
let ``Attr.value{Type} should produce expected string`` () =
    let dt = (DateTime(1986,12,12,5,30,0))
    Attr.valueDate dt |> should equal <| Attr.value "1986-12-12"
    Attr.valueDatetimeLocal dt |> should equal <| Attr.value "1986-12-12T05:30:00"
    Attr.valueMonth dt |> should equal <| Attr.value "1986-12"
    Attr.valueTime (TimeSpan(12,12,0)) |> should equal <| Attr.value "12:12"
    Attr.valueWeek dt |> should equal <| Attr.value "1986-W50"

[<Fact>]
let ``Attr.valueOption + Attr.value{Type} should produce expected attribute`` () =
    let dt = Some (DateTime(1986,12,12,5,30,0))
    Attr.valueOption Attr.valueDate dt |> should equal <| Attr.value "1986-12-12"
    Attr.valueOption Attr.valueDatetimeLocal dt |> should equal <| Attr.value "1986-12-12T05:30:00"
    Attr.valueOption Attr.valueDate None |> should equal <| Attr.valueEmpty
    Attr.valueOption Attr.valueDatetimeLocal None |> should equal <| Attr.valueEmpty


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
