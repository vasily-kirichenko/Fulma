module FulmaExtensions.Calendar.State

open Elmish
open Types

let iconCode =
    """
```fsharp
    Calendar.calendar [ ]
        [ Calendar.Nav.nav [ ]
            [ Calendar.Nav.left [ ]
                [ Button.button [ Button.isLink ]
                    [ Icon.faIcon [ ] Fa.ChevronLeft ] ]
              span [ ] [ str "August 2017" ]
              Calendar.Nav.right [ ]
                [ Button.button [ Button.isLink ]
                    [ Icon.faIcon [ ] Fa.ChevronRight ] ] ]
          div [ ]
            [ Calendar.header [ ]
                [ Calendar.Date.date [ ] [ str "Sun" ]
                  Calendar.Date.date [ ] [ str "Mon" ]
                  Calendar.Date.date [ ] [ str "Tue" ]
                  Calendar.Date.date [ ] [ str "Wed" ]
                  Calendar.Date.date [ ] [ str "Thu" ]
                  Calendar.Date.date [ ] [ str "Fri" ]
                  Calendar.Date.date [ ] [ str "Sat" ] ]
              Calendar.body [ ]
                [ Calendar.Date.date [ Calendar.Date.isDisabled ]
                      [ Calendar.Date.item [ ]
                          [ str "31" ] ]
                  Calendar.Date.date [ ]
                      [ Calendar.Date.item [ ]
                          [ str "1" ] ]
                  Calendar.Date.date [ ]
                      [ Calendar.Date.item [ ]
                          [ str "2" ] ]
                  Calendar.Date.date [ ]
                      [ Calendar.Date.item [ ]
                          [ str "3" ] ]
                  Calendar.Date.date [ ]
                      [ Calendar.Date.item [ ]
                          [ str "4" ] ]
                  Calendar.Date.date [ ]
                      [ Calendar.Date.item [ ]
                          [ str "5" ] ]
                  Calendar.Date.date [ ]
                      [ Calendar.Date.item [ ]
                          [ str "6" ] ]
                  Calendar.Date.date [ ]
                      [ Calendar.Date.item [ Calendar.Date.Item.isToday ]
                          [ str "7" ] ]
                  Calendar.Date.date [ ]
                      [ Calendar.Date.item [ ]
                          [ str "8" ] ]
                  Calendar.Date.date [ ]
                      [ Calendar.Date.item [ ]
                          [ str "9" ] ]
                  Calendar.Date.date [ ]
                      [ Calendar.Date.item [ ]
                          [ str "10" ] ]
                  Calendar.Date.date [ Calendar.Date.isRangeStart ]
                      [ Calendar.Date.item [ Calendar.Date.Item.isActive ]
                          [ str "11" ] ]
                  Calendar.Date.date [ Calendar.Date.isRange ]
                      [ Calendar.Date.item [ ]
                          [ str "12" ] ]
                  Calendar.Date.date [ Calendar.Date.isRange ]
                      [ Calendar.Date.item [ ]
                          [ str "13" ] ]
                  Calendar.Date.date [ Calendar.Date.isRange ]
                      [ Calendar.Date.item [ ]
                          [ str "14" ] ]
                  Calendar.Date.date [ Calendar.Date.isRange ]
                      [ Calendar.Date.item [ ]
                          [ str "15" ] ]
                  Calendar.Date.date [ Calendar.Date.isRange ]
                      [ Calendar.Date.item [ ]
                          [ str "16" ] ]
                  Calendar.Date.date [ Calendar.Date.isRangeEnd ]
                      [ Calendar.Date.item [ Calendar.Date.Item.isActive ]
                          [ str "17" ] ]
                  Calendar.Date.date [ ]
                      [ Calendar.Date.item [ ]
                          [ str "18" ] ]
                  Calendar.Date.date [ ]
                      [ Calendar.Date.item [ ]
                          [ str "19" ] ]
                  Calendar.Date.date [ ]
                      [ Calendar.Date.item [ ]
                          [ str "20" ] ]
                  Calendar.Date.date [ ]
                      [ Calendar.Date.item [ ]
                          [ str "21" ] ]
                  Calendar.Date.date [ ]
                      [ Calendar.Date.item [ ]
                          [ str "22" ] ]
                  Calendar.Date.date [ ]
                      [ Calendar.Date.item [ ]
                          [ str "23" ] ]
                  Calendar.Date.date [ ]
                      [ Calendar.Date.item [ ]
                          [ str "24" ] ]
                  Calendar.Date.date [ ]
                      [ Calendar.Date.item [ ]
                          [ str "25" ] ]
                  Calendar.Date.date [ ]
                      [ Calendar.Date.item [ ]
                          [ str "26" ] ]
                  Calendar.Date.date [ ]
                      [ Calendar.Date.item [ ]
                          [ str "27" ] ]
                  Calendar.Date.date [ ]
                      [ Calendar.Date.item [ ]
                          [ str "28" ] ]
                  Calendar.Date.date [ ]
                      [ Calendar.Date.item [ ]
                          [ str "29" ] ]
                  Calendar.Date.date [ ]
                      [ Calendar.Date.item [ ]
                          [ str "30" ] ]
                  Calendar.Date.date [ ]
                      [ Calendar.Date.item [ ]
                          [ str "31" ] ]
                  Calendar.Date.date [ Calendar.Date.isDisabled ]
                      [ Calendar.Date.item [ ]
                          [ str "1" ] ]
                  Calendar.Date.date [ Calendar.Date.isDisabled ]
                      [ Calendar.Date.item [ ]
                          [ str "2" ] ]
                  Calendar.Date.date [ Calendar.Date.isDisabled ]
                      [ Calendar.Date.item [ ]
                          [ str "3" ] ] ] ] ]
```
    """

let init() =
    { Intro =
        """
# Calendar

Display a **calendar** for date selection or for planning management, in different colors and sizes.

*[Documentation](https://wikiki.github.io/bulma-extensions/calendar)*

## Npm packages

<table class="table" style="width: auto;">
    <thead>
        <tr>
            <th>Version</th>
            <th>CLI</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td>Latest</td>
            <td>`yarn add bulma bulma-calendar bulma-tooltip`</td>
        </tr>
        <tr>
            <td>Supported</td>
            <td>`yarn add bulma bulma-calendar@0.0.1 bulma-tooltip@0.0.4`</td>
        </tr>
    </tbody>
<table>
        """
      BasicViewer = Viewer.State.init iconCode }

let update msg model =
    match msg with
    | BasicViewerMsg msg ->
        let (viewer, viewerMsg) = Viewer.State.update msg model.BasicViewer
        { model with BasicViewer = viewer }, Cmd.map BasicViewerMsg viewerMsg
