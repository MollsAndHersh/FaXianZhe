﻿using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Text;

namespace JCSoft.FXZ.Server.Authentication.Middleware
{
    public static class AuthenticationMiddlewareExtensions
    {
        public static IApplicationBuilder UseAuthenticationMiddleware(this IApplicationBuilder builder) => 
            builder.UseMiddleware<AuthenticationMiddleware>(builder);
    }
}
