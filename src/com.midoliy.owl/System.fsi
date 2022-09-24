namespace com.midoliy.owl

module System =
  (*
    Types
  *)
  type vec<'a> = ResizeArray<'a>
  type pair<'key, 'value> = System.Collections.Generic.KeyValuePair<'key, 'value>
  type dict<'key, 'value> = System.Collections.Generic.Dictionary<'key, 'value>
  type queue<'a> = System.Collections.Generic.Queue<'a>
  type stack<'a> = System.Collections.Generic.Stack<'a>

  type con'bag<'a> = System.Collections.Concurrent.ConcurrentBag<'a>
  type con'dict<'key, 'value> = System.Collections.Concurrent.ConcurrentDictionary<'key, 'value>
  type con'queue<'a> = System.Collections.Concurrent.ConcurrentQueue<'a>
  type con'stack<'a> = System.Collections.Concurrent.ConcurrentStack<'a>

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
  val inline is'default<'a when 'a : equality> : 'a -> bool
  val inline is'not'default<'a when 'a : equality> : 'a -> bool