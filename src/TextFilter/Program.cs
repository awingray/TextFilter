using TextFilter;
using TextFilter.Filters;

var testString = await File.ReadAllTextAsync("input.txt");

var wordSpec = new WordSpec()
    .AddSpec(new NoLetterT())
    .AddSpec(new MinLength(3))
    .AddSpec(new NoMiddleVowel());
var textFilter = new TextFilter.TextFilter(new Tokenizer(), wordSpec);

Console.WriteLine(textFilter.Filter(testString));


