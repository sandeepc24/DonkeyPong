module Global

type Page =
  | Home
  | Game
  | Counter
  | About

let toHash page =
  match page with
  | About -> "#about"
  | Counter -> "#counter"
  | Game -> "#game"
  | Home -> "#home"
