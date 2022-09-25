namespace com.midoliy.owl.io

module Path =
  val inline combine : array<string> -> string

  val inline root : string -> string
  val inline fullpath : string -> string
  val inline parent'dir : string -> string
  val inline fname : string -> string
  val inline fname'without'ext : string -> string

  val inline ext : string -> string
  val inline has'ext : string -> bool