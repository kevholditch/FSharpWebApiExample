module Controllers

open System.Web.Http

type HelloController () =
    inherit ApiController()

    member this.Get () = 
            "getting hello world"

    member this.Post () =
            "posting hello world"
