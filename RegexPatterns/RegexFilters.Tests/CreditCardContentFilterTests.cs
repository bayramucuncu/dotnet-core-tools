using NUnit.Framework;

namespace RegexFilters.Tests;

public class CreditCardContentFilterTests: BaseFilterTest
{
    protected override IContentFilter Filter { get; } = new CreditCardContentFilter();

    [TestCase("6062 8288 8866 6688", ExpectedResult = "0000 0000 0000 0000")]
    [TestCase("x 8288 8866 6688", ExpectedResult = "x 8288 8866 6688")]
    [TestCase(" 6062 8288 8866 6688 ", ExpectedResult = " 0000 0000 0000 0000 ")]
    [TestCase("my card number 6062 8288 8866 6688 of company", ExpectedResult = "my card number 0000 0000 0000 0000 of company")]
    public override string ContentFilter_Replace_ReplacesMatchedRegexContentOfInput(string actual)
    {
        return base.ContentFilter_Replace_ReplacesMatchedRegexContentOfInput(actual);
    }
    
    [TestCase("mail card numbers are 3569 9900 1009 5841, 6771 7980 2100 0008 ok", 
        ExpectedResult = new []{"3569 9900 1009 5841", "6771 7980 2100 0008"})]
    public override IEnumerable<string> ContentFilter_Matches_ReplacesMatchedRegexContentOfInput(string actual)
    {
        return base.ContentFilter_Matches_ReplacesMatchedRegexContentOfInput(actual);
    }
}