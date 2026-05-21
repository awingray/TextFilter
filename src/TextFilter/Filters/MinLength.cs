namespace TextFilter.Filters;

public sealed class MinLength : ISpec
{
    private readonly int _length;
    
    public MinLength(int length) => _length = length;
    
    public bool IsSatisfiedBy(string word)  => word.Length > _length;
}