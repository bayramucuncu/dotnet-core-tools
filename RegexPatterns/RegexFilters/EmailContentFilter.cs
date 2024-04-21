namespace RegexFilters;

public class EmailContentFilter: BaseContentFilter
{
    protected override string Pattern => @"[\w-\.]+@([\w-]+\.)+[\w-]{2,4}";
    protected override string Replacement => "mail@domain.com";
}