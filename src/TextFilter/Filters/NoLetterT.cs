namespace TextFilter.Filters;

internal sealed class NoLetterT : ISpec
{
    public bool IsSatisfiedBy(string word) => !word.Contains('t', StringComparison.OrdinalIgnoreCase);
}