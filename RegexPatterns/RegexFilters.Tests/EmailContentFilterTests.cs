using NUnit.Framework;

namespace RegexFilters.Tests;

public class EmailContentFilterTests: BaseFilterTest
{
    protected override IContentFilter Filter { get; } = new EmailContentFilter();

    [TestCase("bayram@ucuncu.com", ExpectedResult = "mail@domain.com")]
    [TestCase("bayram.ucuncu@ucuncu.com", ExpectedResult = "mail@domain.com")]
    [TestCase("bayram", ExpectedResult = "bayram")]
    [TestCase("my email bayram.ucuncu@ucuncu.com of company", ExpectedResult = "my email mail@domain.com of company")]
    public override string ContentFilter_Replace_ReplacesMatchedRegexContentOfInput(string actual)
    {
        return base.ContentFilter_Replace_ReplacesMatchedRegexContentOfInput(actual);
    }
    
    [TestCase("mail addresses are bayram@ucuncu.com, bayram.ucuncu@ucuncu.com ok", 
       ExpectedResult = new []{"bayram@ucuncu.com", "bayram.ucuncu@ucuncu.com"})]
    public override IEnumerable<string> ContentFilter_Matches_ReplacesMatchedRegexContentOfInput(string actual)
    {
        return base.ContentFilter_Matches_ReplacesMatchedRegexContentOfInput(actual);
    }
}