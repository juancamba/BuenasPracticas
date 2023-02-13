using Xunit;

namespace problemDetails.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        bool respuesta = false;

        Assert.False(respuesta, "está bien, da false");
    }
}