// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.
open Microsoft.Owin.Hosting
open Owin
open Microsoft.Owin
open System
open System.IO
open System.Threading.Tasks
open System.Web.Http
open WebServerBuilder


[<EntryPoint>]
let main argv = 

    
    let hostAddress = "http://localhost:8000"
    let server = WebApp.Start(hostAddress, getAppBuilder())
    
    printfn "Web server up and running on %s" hostAddress
    printf  "Press any key to stop"

    Console.ReadKey() |> ignore

    server.Dispose()

    0 // return an integer exit code
