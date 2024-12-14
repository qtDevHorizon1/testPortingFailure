using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Middleware.Authentication.AppService
{
    public class AzureAppServiceAuthenticationOptions : AuthenticationOptions
    {
        public AzureAppServiceAuthenticationOptions()
        {
            this.AuthenticationScheme = "Automatic";
        }
    }
}