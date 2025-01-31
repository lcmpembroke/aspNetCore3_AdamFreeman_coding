﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Platform.Services
{
    public class HtmlResponseFormatter : IResponseFormatter
    {
        public async Task Format(HttpContext context, string content)
        {
            context.Response.ContentType = "text/html";
            await context.Response.WriteAsync($@"
            <!DOCTYPE html>
            <html>
            <head><title>Response</title></head>
            <body>
                <h2>Formatted response</h2>
                <span>{content}</span>
            </body>
            </html>"

            );
        }

        public bool RichOutput => true;

    }
}
