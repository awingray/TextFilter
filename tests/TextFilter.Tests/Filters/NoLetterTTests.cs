using TextFilter.Filters;

namespace TextFilter.Tests.Filters;

using NUnit.Framework;

[TestFixture]
public class NoLetterTTests
{
    private ISpec _spec;

    [SetUp]
    public void SetUp() => _spec = new NoLetterT();
    
    [TestCase("hello")]
    [TestCase("HORSE")]
    [TestCase("car")]
    public void ShouldReturnTrue_DoesNotContainT(string testString)
    {
        var result = _spec.IsSatisfiedBy(testString);
        
        Assert.That(result, Is.True);
    }

    [TestCase("cat")]
    [TestCase("t")]
    [TestCase("tattoo")]
    [TestCase("TTT")]
    [TestCase("haT")]
    public void ShouldReturnFalse_ContainsT(string testString)
    {
        var result = _spec.IsSatisfiedBy(testString);
        
        Assert.That(result, Is.False);
    }
}