using TextFilter.Filters;

namespace TextFilter;

internal sealed class WordSpec : ISpec
{
    private readonly ICollection<ISpec> _specs = [];

    public WordSpec AddSpec(ISpec spec)
    {
        _specs.Add(spec);
        return this;
    }

    public bool IsSatisfiedBy(string word) => _specs.All(spec => spec.IsSatisfiedBy(word));
}