using NUnit.Framework;

public class HelloWorldTest
{
    [Test]
    public void TestHelloWorld()
    {
        // Arrange
        string expected = "Hola Mundo";
        
        // Act
        string actual = HelloWorld.GetHelloWorld();
        
        // Assert
        Assert.AreEqual(expected, actual);
    }
}

public class HelloWorld
{
    public static string GetHelloWorld()
    {
        return "Hola Mundo";
    }
}
