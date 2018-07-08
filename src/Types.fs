module App.Types

open Global

type Msg =
  | CounterMsg of Counter.Types.Msg
  | GameMsg of Game.Types.Msg
  | HomeMsg of Home.Types.Msg

type Model = {
    currentPage: Page
    counter: Counter.Types.Model
    game: Game.Types.Model
    home: Home.Types.Model
  }
