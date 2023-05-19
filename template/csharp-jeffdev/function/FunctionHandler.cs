using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Function
{
    public class FunctionHandler
    {
        public async Task HandleAsync(HttpContext context)
        {
            var readString = await new StreamReader(context.Request.Body).ReadToEndAsync();

            await context.Response.WriteAsync($"Hello! Your input was {readString}");
        }
    }
}
