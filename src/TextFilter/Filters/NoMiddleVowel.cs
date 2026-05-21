namespace TextFilter.Filters;

public sealed class NoMiddleVowel : ISpec
{
    public bool IsSatisfiedBy(string word)
    {
        // guard against null and whitespace??
        var isEven = word.Length % 2 == 0;
        var middle = word.Length / 2;
        if (isEven)
        {
            return !IsVowel(word[middle]) && !IsVowel(word[middle - 1]);
        } 
        
        return !IsVowel(word[middle]);
        
    }

    private bool IsVowel(char c) => new[] { 'a', 'e', 'i', 'o', 'u' }.Contains(char.ToLower(c));
}