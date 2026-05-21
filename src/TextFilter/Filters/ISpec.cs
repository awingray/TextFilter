namespace TextFilter.Filters;

// Trying to use specification pattern but kinda forgot how to do that...
internal interface ISpec
{
    bool IsSatisfiedBy(string word);
}