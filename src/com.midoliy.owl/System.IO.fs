namespace com.midoliy.owl.io

open System.IO

module FileSystem =
  (*
    Path class
  *)
  let inline combine (pathes: array<string>) = Path.Combine pathes

  let inline root (path: string) = Path.GetPathRoot path
  let inline fullpath (path: string) = Path.GetFullPath path
  let inline parent'dir (path: string) = Path.GetDirectoryName path
  let inline fname (path: string) = Path.GetFileName path
  let inline fname'without'ext (path: string) = Path.GetFileNameWithoutExtension path
  
  let inline ext (path: string) = Path.GetExtension path
  let inline has'ext (path: string) = Path.HasExtension path

  (*
    File class
  *)
  let inline f'exists (path: string) = File.Exists path
  let inline f'copy (dst: string) (src: string) = File.Copy (src, dst); dst

  (*
    Directory class
  *)
  let inline d'exists (path: string) = Directory.Exists path