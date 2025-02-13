// <auto-generated/>
#pragma warning disable
using Microsoft.AspNetCore.Routing;
using System;
using System.Linq;
using Wolverine.Http;

namespace Internal.Generated.WolverineHandlers
{
    // START: GET_openapi_sideeffect
    public class GET_openapi_sideeffect : Wolverine.Http.HttpHandler
    {
        private readonly Wolverine.Http.WolverineHttpOptions _wolverineHttpOptions;

        public GET_openapi_sideeffect(Wolverine.Http.WolverineHttpOptions wolverineHttpOptions) : base(wolverineHttpOptions)
        {
            _wolverineHttpOptions = wolverineHttpOptions;
        }



        public override System.Threading.Tasks.Task Handle(Microsoft.AspNetCore.Http.HttpContext httpContext)
        {
            
            // The actual HTTP request handler execution
            var simpleSideEffect = WolverineWebApi.OpenApiEndpoints.SideEffect();

            
            // Placed by Wolverine's ISideEffect policy
            simpleSideEffect.Execute();

            // Wolverine automatically sets the status code to 204 for empty responses
            if (!httpContext.Response.HasStarted) httpContext.Response.StatusCode = 204;
            return System.Threading.Tasks.Task.CompletedTask;
        }

    }

    // END: GET_openapi_sideeffect
    
    
}

