using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Infrastructure
{
    public static class UrlExtensions
    {
        public static string PathAndQuery(this HttpRequest request) =>
request.QueryString.HasValue ? $"{request.Path}{request.QueryString}" : request.Path.ToString();
        //PathAndQuery extension method operates on the HttpRequest class, which ASP.NET uses to describe an HTTP request. 
        //The extension method generates an URL that the browser will return to after the cart has been updated, taking into account the query string if there is one
    }
}
