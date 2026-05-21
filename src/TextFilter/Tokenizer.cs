namespace TextFilter;

// Most likely don't need an interface here...
internal interface ITokenizer
{
    string[] Tokenize(string testString);
}

internal sealed class Tokenizer : ITokenizer
{
    // This is hideous and doesn't scale but it will do for now
    // I just realized one hour in that this actually doesn't work...
    // This is all I got, if this were implemented properly, it should return proper word tokens.
    public string[] Tokenize(string testString) => testString.Split(' ', '?', ',', '\'', ';', '\n', '(', ')', '.'); 
}