namespace FSharpWebApi.Tests

open NUnit.Framework
open FsUnit
open WebServerBuilder
open Owin
open Microsoft.Owin.Testing
open System.Web.Http
open System.Net.Http

module WebServerTests =
    [<Test>]
    let ``get /Hello should return "get - hello world"``() =
        let testServer = TestServer.Create(new System.Action<IAppBuilder>(getAppBuilder()))
        let client = testServer.HttpClient

        client.GetAsync("/Hello").Result.Content.ReadAsStringAsync().Result 
            |> should equal "\"get - hello world\""   

    [<Test>]
    let ``post /Hello should return "post - hello world"``() =
        let testServer = TestServer.Create(new System.Action<IAppBuilder>(getAppBuilder()))
        let client = testServer.HttpClient

        client.PostAsync("/Hello", new StringContent("")).Result.Content.ReadAsStringAsync().Result 
            |> should equal "\"post - hello world\"" 