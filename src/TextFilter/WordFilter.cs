using TextFilter.Filters;

namespace TextFilter;

internal sealed class WordFilter
{
    private readonly ICollection<ISpec> _specs;

    public WordFilter AddSpec(ISpec spec)
    {
        _specs.Add(spec);
        return this;
    }
}