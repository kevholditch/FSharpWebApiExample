namespace FSharpWebApi.Tests

open System
open NUnit.Framework
open FsUnit
open WebServerBuilder
open Owin
open Microsoft.Owin.Testing
open System.Web.Http
open System.Net.Http

module WebServerTests =
    let createTestServer = fun () -> TestServer.Create(new Action<IAppBuilder>(getAppBuilder()))

    [<Test>]
    let ``get /Hello should return "get - hello world"``() =
        let testServer = createTestServer()
        let client = testServer.HttpClient

        client.GetAsync("/Hello").Result.Content.ReadAsStringAsync().Result 
            |> should equal "\"get - hello world\""   

    [<Test>]
    let ``post /Hello should return "post - hello world"``() =
        let testServer = createTestServer()
        let client = testServer.HttpClient

        client.PostAsync("/Hello", new StringContent("")).Result.Content.ReadAsStringAsync().Result 
            |> should equal "\"post - hello world\"" 