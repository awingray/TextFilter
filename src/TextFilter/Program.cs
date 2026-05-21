using System.Text;
using TextFilter;
using TextFilter.Filters;

const string testString = "hello:  , how are   you doing?\n THIS IS A TEST/ string (). Lorem?'IPSUM";

var wordSpec = new WordSpec().AddSpec(new NoLetterT());
var tokenizedString = new Tokenizer().Tokenize(testString);



string GetWordFromText(string text)
{
    // I think this is possible using linq
    var word = new StringBuilder();
    foreach (var  c in text)
    {
        if (!char.IsLetter(c)) break;
        word.Append(c);
    }
    return word.ToString();
}



