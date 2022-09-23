namespace com.midoliy.owl.console

module Console =
  type color = System.ConsoleColor
  type keyinfo = System.ConsoleKeyInfo

  val inline clear : unit -> unit

  val inline read : unit -> int
  val inline readln : unit -> string
  val inline readkey : unit -> keyinfo
  val inline printl<'a> : 'a -> unit
  val inline println<'a> : 'a -> unit

  val inline bgcolor : color -> unit
  val inline fgcolor : color -> unit