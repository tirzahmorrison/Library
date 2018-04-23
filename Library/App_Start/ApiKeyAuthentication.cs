using System.Net;
using System.Web.Mvc;
using System;
using System.Web;

namespace Library
{
    public class ApiKeyAuthenticationAttribute : AuthorizeAttribute //making new class deriving from action attribute
    {
        protected override bool AuthorizeCore(HttpContextBase httpContext) //overiding method that runs before my actualy endpoint gets run
        {
            return httpContext.Request.Headers.Get("Authorization") == "thisIsTirzahsLibraryApiKey"; //validate api key
           
           
        }
    }
}