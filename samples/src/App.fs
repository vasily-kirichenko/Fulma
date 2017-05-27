module App.View

open Elmish
open Elmish.Browser.Navigation
open Elmish.Browser.UrlParser
open Fable.Core
open Fable.Core.JsInterop
open Fable.Import
open Fable.Import.Browser
open Types
open App.State
open Global
open Elmish.Bulma

importAll "../sass/main.sass"

open Fable.Helpers.React
open Fable.Helpers.React.Props

module Bulma = open Elmish.Bulma

let menuItem label page currentPage =
    li
      [ ]
      [ a
          [ classList [ "is-active", page = currentPage ]
            Href (toHash page) ]
          [ str label ] ]

let menu currentPage =
  aside
    [ ClassName "menu" ]
    [ p
        [ ClassName "menu-label" ]
        [ str "General" ]
      ul
        [ ClassName "menu-list" ]
        [ menuItem "Home" Home currentPage ] ]

let root model dispatch =

  let pageHtml =
    function
    | Home -> Home.View.root model.home (HomeMsg >> dispatch)

  div
    []
    [ div
        [ ClassName "navbar-bg" ]
        [ div
            [ ClassName "container" ]
            [ Navbar.View.root ] ]
      div
        [ ClassName "section" ]
        [ div
            [ ClassName "container" ]
            [ div
                [ ClassName "columns" ]
                [ div
                    [ ClassName "column is-3" ]
                    [ menu model.currentPage ]
                  div
                    [ ClassName "column" ]
                    [ pageHtml model.currentPage
                      a
                        [ ClassName "button"
                          OnClick (fun _ -> SendNotification |> dispatch) ]
                        [ str "Test notif" ]
                      Bulma.Notification.view
                        [ ]
                        [ str "test"
                          a
                            [ ClassName "button"
                              OnClick (fun _ -> Test |> dispatch) ]
                            [ str "Click me" ]
                        ]
                    ] ] ] ] ]

open Elmish.React
open Elmish.Bulma.Notification

// App
Program.mkProgram init update root
|> Program.toNavigable (parseHash pageParser) urlUpdate
|> Program.toNotifiable
|> Program.withReact "elmish-app"
|> Program.run
