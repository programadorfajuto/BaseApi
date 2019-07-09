using System;
using Microsoft.AspNetCore.Hosting;

namespace BaseApi.Api.Extensions
{
    public static class WebHostBuilderExtensions
    {
        public static IWebHostBuilder UsePort(this IWebHostBuilder builder)
        {
            var port = Environment.GetEnvironmentVariable("PORT");
            return string.IsNullOrEmpty(port) ? builder : builder.UseUrls($"http://+:{port}");
        }
    }
}