using NUnit.Framework;

namespace RegexFilters.Tests;

public class IbanContentFilterTests: BaseFilterTest
{
    protected override IContentFilter Filter { get; } = new IbanContentFilter();

    [TestCase("DE89370400440532013000", ExpectedResult = "IBAN")]
    [TestCase(" DE89370400440532013000 ", ExpectedResult = " IBAN ")]
    [TestCase(" TR68 0013 2000 0000 0000 0012 99 ", ExpectedResult = " IBAN ")]
    [TestCase("bayram", ExpectedResult = "bayram")]
    [TestCase("my iban AT61 1904 3002 3457 3201 of company", ExpectedResult = "my iban IBAN of company")]
    public override string ContentFilter_Replace_ReplacesMatchedRegexContentOfInput(string actual)
    {
        return base.ContentFilter_Replace_ReplacesMatchedRegexContentOfInput(actual);
    }
    
    [TestCase("mail addresses are TR60 0004 6008 3588 8000 0017 36, BY86AKBB10100000002966000000 ok", 
        ExpectedResult = new []{"TR60 0004 6008 3588 8000 0017 36", "BY86AKBB10100000002966000000"})]
    public override IEnumerable<string> ContentFilter_Matches_ReplacesMatchedRegexContentOfInput(string actual)
    {
        return base.ContentFilter_Matches_ReplacesMatchedRegexContentOfInput(actual);
    }
}