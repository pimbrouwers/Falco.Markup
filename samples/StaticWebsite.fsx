#r "nuget: Falco.Markup"

open System
open System.IO
open Falco.Markup

// Components
let divider =
    Elem.hr [ Attr.class' "divider" ]

// Template
let master (title : string) (content : XmlNode list) =
    Elem.html [ Attr.lang "en" ] [
        Elem.head [] [
            Elem.title [] [ Text.raw "Sample App" ]
        ]
        Elem.body [] content
    ]

// Views
let homeView =
    master "Homepage" [
        Elem.h1 [] [ Text.raw "Homepage" ]
        divider
        Elem.p [] [ Text.raw "Lorem ipsum dolor sit amet."]
    ]

let aboutView =
    master "About Us" [
        Elem.h1 [] [ Text.raw "About" ]
        divider
        Elem.p [] [ Text.raw "Lorem ipsum dolor sit amet."]
    ]

// Generate website
let writeHtmlToFile (filename : string) (html : XmlNode) =
    File.WriteAllText(
        Path.Join(__SOURCE_DIRECTORY__, filename),
        (renderHtml html))

writeHtmlToFile "_homepage.html" homeView
writeHtmlToFile "_about.html" aboutView