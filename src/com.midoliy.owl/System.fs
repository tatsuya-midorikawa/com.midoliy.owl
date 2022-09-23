namespace com.midoliy.owl

[<AutoOpen>]
module System =
  (*
    Types
  *)
  type dict<'key, 'value> = System.Collections.Generic.Dictionary<'key, 'value>
  type pair<'key, 'value> = System.Collections.Generic.KeyValuePair<'key, 'value>
  type notimplexn = System.NotImplementedException
  type idxoutrngexn = System.IndexOutOfRangeException
  type argoutrngexn = System.ArgumentOutOfRangeException

  (*
    Values
  *)
  let defaultof<'a> = Unchecked.defaultof<'a>

  (*
    Functions
  *)
  let inline isdefault<'a when 'a : equality> (value: 'a) : bool = value = defaultof<'a>