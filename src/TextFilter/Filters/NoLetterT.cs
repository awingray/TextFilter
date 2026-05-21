namespace TextFilter.Filters;

public sealed class NoLetterT : ISpec
{
    // Maybe some validation here would be nice
    public bool IsSatisfiedBy(string word) => !word.Contains('t', StringComparison.OrdinalIgnoreCase);
}