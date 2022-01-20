namespace Rnd.Api.Controller

open Microsoft.AspNetCore.Mvc
open Microsoft.Extensions.Logging

[<ApiController>]
[<Route("[controller]")>] 
type RandomController (logger : ILogger<RandomController>) =
    inherit ControllerBase()

    [<HttpGet("one")>]
    member _.GetOne() = 
        RandomApi.stream(1)

    [<HttpGet("stream")>]
    member _.GetStream() =
        RandomApi.stream(10)