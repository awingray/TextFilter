using System.Text;
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

    public string Filter(string text)
    {
        // I'm 100% sure we can use linq for this
        var filteredString = new StringBuilder();
        var tokenizedString = _tokenizer.Tokenize(text);
        foreach (var token in tokenizedString)
        {
            var word = GetWordFromToken(token);
            if (_spec.IsSatisfiedBy(word)) 
                filteredString.Append(token);
        }
        
        return filteredString.ToString();
    }
    
    private string GetWordFromToken(string token)
    {
        // I think this is possible using linq
        var word = new StringBuilder();
        foreach (var  c in token)
        {
            if (!char.IsLetter(c)) break;
            word.Append(c);
        }
        return word.ToString();
    }


}