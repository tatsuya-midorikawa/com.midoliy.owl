namespace com.midoliy.owl.console

[<AutoOpen>]
[<System.Runtime.Versioning.UnsupportedOSPlatform("android")>]
[<System.Runtime.Versioning.UnsupportedOSPlatform("browser")>]
[<System.Runtime.Versioning.UnsupportedOSPlatform("ios")>]
[<System.Runtime.Versioning.UnsupportedOSPlatform("tvos")>]
module Console =

  type color = System.ConsoleColor
  type keyinfo = System.ConsoleKeyInfo

  let inline clear () : unit = System.Console.Clear()
  let inline readl () : int = System.Console.Read()
  let inline readln () : string = System.Console.ReadLine()
  let inline readkey () : keyinfo = System.Console.ReadKey()
  let inline writel<'a> (value:'a) : unit = System.Console.Write(value)
  let inline writeln<'a> (value:'a) : unit = System.Console.WriteLine(value)

  let inline bgcolor (c: color) : unit = System.Console.BackgroundColor <- c
  let inline fgcolor (c: color) : unit = System.Console.ForegroundColor <- c