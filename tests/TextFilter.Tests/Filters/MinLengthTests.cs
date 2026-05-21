using TextFilter.Filters;

namespace TextFilter.Tests.Filters;

[TestFixture]
public class MinLengthTests
{
    [TestCase("HELLO")]
    [TestCase("there")]
    [TestCase("What")]
    public void ShouldSatisfy_MinLength3(string word)
    {
        var spec = new MinLength(3);
        
        var result = spec.IsSatisfiedBy(word);
        
        Assert.That(result, Is.True);
    }

    [TestCase("WONDERFUL")]
    [TestCase("amazing")]
    [TestCase("Hospital")]
    public void ShouldSatisfy_MinLength5(string word)
    {
        var spec = new MinLength(5);
        
        var result = spec.IsSatisfiedBy(word);
        
        Assert.That(result, Is.True);
    }
    
    [TestCase("UP")]
    [TestCase("why")]
    [TestCase("You")]
    public void ShouldNotSatisfy_MinLength3(string word)
    {
        var spec = new MinLength(3);
        
        var result = spec.IsSatisfiedBy(word);
        
        Assert.That(result, Is.False);
    }
    
    [TestCase("hello")]
    [TestCase("THERE")]
    [TestCase("Camp")]
    public void ShouldNotSatisfy_MinLength5(string word)
    {
        var spec = new MinLength(5);
        
        var result = spec.IsSatisfiedBy(word);
        
        Assert.That(result, Is.False);
    }
}