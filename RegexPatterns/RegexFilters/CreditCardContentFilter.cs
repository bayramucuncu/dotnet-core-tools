namespace RegexFilters;

public class CreditCardContentFilter: BaseContentFilter
{
    protected override string Pattern => @"([0-9]{4})[-| ]??([0-9]{4})[-| ]?([0-9]{4})[-| ]?([0-9]{4})";
    protected override string Replacement => "0000 0000 0000 0000";
}