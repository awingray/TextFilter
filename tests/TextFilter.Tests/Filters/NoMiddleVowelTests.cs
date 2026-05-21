using TextFilter.Filters;

namespace TextFilter.Tests.Filters;

[TestFixture]
public class NoMiddleVowelTests
{
    private ISpec _spec;

    [SetUp]
    public void SetUp() => _spec = new NoMiddleVowel();
    
    [TestCase("sky")]    
    [TestCase("Fly")]    
    [TestCase("SYMPHONY")] 
    public void ShouldSatisfy_WhenMiddleHasNoVowel(string word)
    {
        Assert.That(_spec.IsSatisfiedBy(word), Is.True);
    }

    [TestCase("cat")] 
    [TestCase("bee")]  
    [TestCase("SLEEP")] 
    [TestCase("open")] 
    [TestCase("land")]  
    public void ShouldNotSatisfy_WhenMiddleHasVowel(string word)
    {
        Assert.That(_spec.IsSatisfiedBy(word), Is.False);
    }

    [TestCase("CAT")]
    [TestCase("Sleep")]
    [TestCase("OPEN")]
    public void ShouldNotSatisfy_RegardlessOfCase(string word)
    {
        Assert.That(_spec.IsSatisfiedBy(word), Is.False);
    }
}