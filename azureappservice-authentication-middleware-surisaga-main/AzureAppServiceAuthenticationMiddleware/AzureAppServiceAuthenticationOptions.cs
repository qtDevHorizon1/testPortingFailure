using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Middleware.Authentication.AppService
{
    public class AzureAppServiceAuthenticationOptions : AuthenticationSchemeOptions
    {
        public string Scheme { get; set; } = "Automatic";

        public AzureAppServiceAuthenticationOptions()
        {
        }
    }
}