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
    public class AuzreAppServiceAuthenticationMiddleware : AuthenticationMiddleware
    {
        public AuzreAppServiceAuthenticationMiddleware(
            RequestDelegate next,
            IAuthenticationSchemeProvider schemes,
            IOptionsMonitor<AuthenticationOptions> options,
            ILoggerFactory logger,
            UrlEncoder encoder)
            : base(next, schemes, options, logger, encoder)
        {
        }
    }
}