using System.Text;

const string testString = "hello:  , how are   you doing?\n THIS IS A TEST/ string (). Lorem?'IPSUM";

string GetWordFromText(string text)
{
    var word = new StringBuilder();
    foreach (var  c in text)
    {
        if (!char.IsLetter(c)) break;
        word.Append(c);
    }
    return word.ToString();
}

string[] TextIterator(string text) => testString.Split(' ', '?', ',', '\'', ';'); // This is hideous but it will do for now

foreach (var c in TextIterator(testString))
{
    Console.WriteLine(GetWordFromText(c));
}



