module Game.View

open Fable.Core
open Fable.Helpers.React
open Fable.Helpers.React.Props
open Types

let simpleButton txt action dispatch isActive =
  a
    [ ClassName ("button btn-primary " + (if isActive then "active" else ""))
      Style[CSSProp.Width "170px"]
      OnClick (fun _ -> action |> dispatch) ]
    [ str txt ]

let root model dispatch =
  div[][
      yield simpleButton "Reset Game" StartNew dispatch true
      if model.GameState = Over then
        yield div[][str (sprintf "Game Over - Winner is %s" model.Winner.Value.Name)]
       
      for player in model.Players do
        yield div[][
          div[ClassName "column is-narrow"][
                div[ClassName "column is-narrow"][
                  strong[][str (player.Name)]
                  strong[][str (" Score: " + (player.Score |> Option.defaultValue ""))]
                ]
                simpleButton "+" (AddScore player) dispatch player.IsPlaying
            ]
        ]
  ]