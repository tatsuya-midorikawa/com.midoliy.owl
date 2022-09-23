namespace com.midoliy.owl.console

open System

[<AutoOpen>]
[<System.Runtime.Versioning.UnsupportedOSPlatform("android")>]
[<System.Runtime.Versioning.UnsupportedOSPlatform("browser")>]
[<System.Runtime.Versioning.UnsupportedOSPlatform("ios")>]
[<System.Runtime.Versioning.UnsupportedOSPlatform("tvos")>]
module Console =

  type color = ConsoleColor
  type keyinfo = ConsoleKeyInfo

  let inline clear () : unit = Console.Clear()
  let inline read () : int = Console.Read()
  let inline readln () : string = Console.ReadLine()
  let inline readkey () : keyinfo = Console.ReadKey()
  let inline printl<'a> (value:'a) : unit = Console.Write(value)
  let inline println<'a> (value:'a) : unit = Console.WriteLine(value)

  let inline bgcolor (c: color) : unit = Console.BackgroundColor <- c
  let inline fgcolor (c: color) : unit = Console.ForegroundColor <- c