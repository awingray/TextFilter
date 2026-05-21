using TextFilter.Filters;

namespace TextFilter;

// Most likely don't need an interface here, but i will just do it for demonstration
internal interface IWordSpec 
{
    bool All(string word);
}

internal sealed class WordSpec : IWordSpec
{
    private readonly ICollection<ISpec> _specs = [];

    public WordSpec AddSpec(ISpec spec)
    {
        _specs.Add(spec);
        return this;
    }

    public bool All(string word) => _specs.All(spec => spec.IsSatisfiedBy(word));
}