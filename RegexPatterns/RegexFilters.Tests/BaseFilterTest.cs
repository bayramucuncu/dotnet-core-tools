namespace RegexFilters.Tests;

public abstract class BaseFilterTest
{
    protected abstract IContentFilter Filter { get; }
    
    public virtual string ContentFilter_Replace_ReplacesMatchedRegexContentOfInput(string actual)
    {
        var result = Filter.Replace(actual);

        return result;
    }

    public virtual IEnumerable<string> ContentFilter_Matches_ReplacesMatchedRegexContentOfInput(string actual)
    {
        var result = Filter.Matches(actual);
        
        return result;
    }
}