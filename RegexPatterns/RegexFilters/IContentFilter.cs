namespace RegexFilters;

public interface IContentFilter
{
    string Replace(string input);
    IEnumerable<string> Matches(string input);
}