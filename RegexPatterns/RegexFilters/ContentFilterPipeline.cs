namespace RegexFilters;

public class ContentFilterPipeline : IContentFilterPipeline
{
    public string Process(string input)
    {
        var filters = new IContentFilter[]
        {
            new EmailContentFilter(), 
            new CreditCardContentFilter(), 
            new IbanContentFilter()
        };

        return filters.Aggregate(input, (current, filter) => filter.Replace(current));
    }
}