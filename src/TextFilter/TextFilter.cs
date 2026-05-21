using TextFilter.Filters;

namespace TextFilter;

internal sealed class TextFilter
{
    private readonly ITokenizer _tokenizer;
    private readonly ISpec _spec;
    
    public TextFilter(ITokenizer tokenizer, ISpec spec)
    {
        _tokenizer = tokenizer;
        _spec = spec;
    }

    public string Filter(string text) =>
        string.Join(" ", _tokenizer.Tokenize(text).Where(token => _spec.IsSatisfiedBy(token)));
}