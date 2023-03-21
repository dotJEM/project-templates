using NUnit.Framework;

namespace DotJEM.Framework.Test;

public class MyFrameworkClassTest
{
    [Test]
    public void SayHello_ReturnsHello()
    {
        Assert.That(new MyFrameworkClass().SayHello(), Is.EqualTo("Hello"));
    }
}