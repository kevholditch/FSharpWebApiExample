module WebServerBuilder

open Owin
open System.Web.Http

let getAppBuilder() =
    let config = new HttpConfiguration()
    config.Routes.MapHttpRoute("default", "{controller}") |> ignore
    fun (appBuilder:IAppBuilder) -> appBuilder.UseWebApi(config) |> ignore
    