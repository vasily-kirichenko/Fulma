module Global

open Fable.Core

type Elements =
  | Button
  | Icon
  | Title

type Page =
  | Home
  | Element of Elements

let toHash page =
  match page with
  | Home -> "#home"
  | Element element ->
    match element with
    | Button -> "#elements/button"
    | Icon -> "#elements/icon"
    | Title -> "#elements/title"

[<Pojo>]
type DangerousInnerHtml =
  { __html : string }

open Fable.Helpers.React
open Fable.Helpers.React.Props
open Fable.Import

let renderMarkdown str =
  div
    [   DangerouslySetInnerHTML {
          __html = Marked.Globals.marked.parse(str)
    } ]
    [ ]

let toList = (fun x -> [ x ])

let sectionBase title docBlocks =
  div
    [ ]
    ((div
        [ ClassName "content" ]
        [ renderMarkdown title ]) :: docBlocks)

let docBlock code children =
  div
    [ ClassName "columns" ]
    [ div
        [ ClassName "column" ]
        [ children ]
      div
        [ ClassName "column" ]
        [ renderMarkdown code ] ]
