using Vai.Parse;

namespace Vai.Testes;

public class ParserTests
{
    [Fact]
    public void Parser_ShouldBe_Ok()
    {
        // Arrange
        string number = "1";

        // Act
        int result = Parser.ParseToInt(number.AsSpan());

        // Assert
        Assert.Equal(1, result);
    }
}
