#r "nuget: Falco.Markup"

open Falco.Markup

let _books = Elem.create "books" []
let _book = Elem.create "book" []
let _name = Elem.create "name" []

let myBooks =
    [ "To Kill A Mockingbird"
      "Moby Dick"
      "Pride & Prejudice"
      "Green Eggs and Ham" ]

let xml =
    _books [
        for book in myBooks do
            _book [
                _name [ Text.raw book ] ] ]
    |> renderXml

printfn "%s" xml