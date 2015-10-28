module Controllers

open System.Web.Http

type HelloController () =
    inherit ApiController()

    member this.Get () = 
            "hello world"