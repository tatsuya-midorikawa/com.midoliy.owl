namespace com.midoliy.owl

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
  val defaultof<'a> : 'a

  (*
    Functions
  *)
  val inline isdefault<'a when 'a : equality> : 'a -> bool