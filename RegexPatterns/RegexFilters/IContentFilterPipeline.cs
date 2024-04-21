namespace RegexFilters;

public interface IContentFilterPipeline
{
    string Process(string input);
}