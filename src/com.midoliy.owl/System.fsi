namespace com.midoliy.owl

module System =
  type dict<'key, 'value> = System.Collections.Generic.Dictionary<'key, 'value>
  type pair<'key, 'value> = System.Collections.Generic.KeyValuePair<'key, 'value>
  type notimplexn = System.NotImplementedException
  type idxoutrngexn = System.IndexOutOfRangeException
  type argoutrngexn = System.ArgumentOutOfRangeException

  val defaultof<'a> : 'a
