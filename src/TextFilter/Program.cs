using TextFilter;
using TextFilter.Filters;

const string testString = "hello:  , how are   you doing?\n THIS IS A TEST/ string (). Lorem?'IPSUM";

var wordSpec = new WordSpec().AddSpec(new NoLetterT());
var textFilter = new TextFilter.TextFilter(new Tokenizer(), wordSpec);

Console.WriteLine(textFilter.Filter(testString));


