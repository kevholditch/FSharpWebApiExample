module Controllers

open System.Web.Http

type HelloController () =
    inherit ApiController()

    member this.Get () = 
            "get - hello world"

    member this.Post () =
            "post - hello world"
