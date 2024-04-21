namespace RegexFilters;

public class IbanContentFilter: BaseContentFilter
{
    protected override string Pattern => @"\b[A-Z]{2}\d\d(?:(?: ?[A-Z\d]{4}){2,6} ?[A-Z\d]{3}|( ?[A-Z\d]{4}){3,7}(?: ?[A-Z\d]{1,2})?)\b";
    protected override string Replacement => "IBAN";
}