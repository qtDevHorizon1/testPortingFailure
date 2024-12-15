using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Authentication;

namespace Middleware.Authentication.AppService
{
    public class AuzreAppServiceAuthenticationMiddleware : IMiddleware
    {
        private readonly IOptions<AzureAppServiceAuthenticationOptions> _options;
        private readonly ILogger<AuzreAppServiceAuthenticationMiddleware> _logger;

        public AuzreAppServiceAuthenticationMiddleware(
            IOptions<AzureAppServiceAuthenticationOptions> options,
            ILogger<AuzreAppServiceAuthenticationMiddleware> logger)
        {
            _options = options;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            // Implement your authentication logic here
            // For example:
            // if (!context.User.Identity.IsAuthenticated)
            // {
            //     // Authenticate the user
            //     // ...
            // }

            await next(context);
        }
    }
}