module Global

type Page =
  | Home
  | Counter
  | About
  | NewCounter

let toHash page =
  match page with
  | About -> "#about"
  | Counter -> "#counter"
  | Home -> "#home"
  | NewCounter -> "#newcounter"
