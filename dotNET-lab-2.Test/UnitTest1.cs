namespace dotNET_Lab_2.Test;

public class UnitTest1
{
    [Fact]
    public void FormatUsdPrice_ProperFormat_ShouldReturnProperString()
    {
        var data = 0.05;
        var expected = "$" + data;

        var result = MyFormatter.FormatUsdPrice(data);

        // Assert.StartsWith("$", result);
        // Assert.Contains(".", result);

        Assert.Equal(expected.Replace(",", "."), result);
    }
}