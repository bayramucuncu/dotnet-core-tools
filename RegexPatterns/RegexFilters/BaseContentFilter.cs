using System.Text.RegularExpressions;

namespace RegexFilters;

public abstract class BaseContentFilter: IContentFilter
{
    protected abstract string Pattern { get; }
    protected abstract string Replacement { get; }

    public virtual string Replace(string input)
    {
        var response = Regex.Replace(input, Pattern, Replacement);
        
        return response;
    }

    public virtual IEnumerable<string> Matches(string input)
    {
        var response = Regex.Matches(input, Pattern);
        
        return response.Select(x=>x.Value);
    }
}