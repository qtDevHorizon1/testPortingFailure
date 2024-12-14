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
        private readonly UrlEncoder _encoder;

        public AuzreAppServiceAuthenticationMiddleware(
            IOptions<AzureAppServiceAuthenticationOptions> options,
            ILogger<AuzreAppServiceAuthenticationMiddleware> logger,
            UrlEncoder encoder)
        {
            _options = options;
            _logger = logger;
            _encoder = encoder;
        }

        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            // TODO: Implement authentication logic here

            // For now, just call the next middleware in the pipeline
            await next(context);
        }
    }
}