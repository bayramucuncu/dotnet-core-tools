using NUnit.Framework;

namespace RegexFilters.Tests;

public class ContentFilterPipelineTests
{
    [Test]
    public void Process_WithPipelines_ReplacesInputs()
    {
        var pipeline = new ContentFilterPipeline();

        const string input = "Email: bayram@u.com, card number: 6062 8288 8866 6688, iban: TR60 0004 6008 3588 8000 0017 36";
        const string output = "Email: mail@domain.com, card number: 0000 0000 0000 0000, iban: IBAN";

        var result = pipeline.Process(input);
        
        Assert.That(result, Is.EqualTo(output));
    }
}