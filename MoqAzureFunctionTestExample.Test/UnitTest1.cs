using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
using Microsoft.AspNetCore.Mvc;
using Moq;
using MyFunctions;
using NUnit.Framework;

namespace TestProject1;

public class Tests
{
    [Test]
    public async Task Test1()
    { 
        var mockKlass = new Mock<NonVirtualKlassWrapper>(MockBehavior.Strict, 10);
        var task = async () =>
        {
            await Task.Delay(2000);
            return 20;
        };
        mockKlass.Setup(klass => klass.GetNumber()).Returns(task());
        var myFunction = new HelloWorld(mockKlass.Object);
        var res = (OkObjectResult)await myFunction.RunAsync(new DefaultHttpRequest(new DefaultHttpContext()));
        Assert.AreEqual("Hello, 2", res.Value);
    }
}