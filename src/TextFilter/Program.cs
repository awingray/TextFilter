using TextFilter;
using TextFilter.Filters;

const string testString = "hello:  , how are   you doing?\n THIS IS A TEST/ string (). Lorem?'IPSUM";

var wordSpec = new WordSpec()
    .AddSpec(new NoLetterT())
    .AddSpec(new MinLength(3));
var textFilter = new TextFilter.TextFilter(new Tokenizer(), wordSpec);

Console.WriteLine(textFilter.Filter(testString));


