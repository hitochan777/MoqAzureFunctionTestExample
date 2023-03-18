using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;

namespace MyFunctions;

public class HelloWorld
{
    private readonly NumberGeneratorWrapper _klass;
    public HelloWorld(NumberGeneratorWrapper klass)
    {
        _klass = klass;
    }
    
    [FunctionName("HelloWorld")]
    public async Task<IActionResult> RunAsync(
        [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req)
    {
        var num =    _klass.GetNumber();
        return new OkObjectResult($"Hello, {num}");
    }
}