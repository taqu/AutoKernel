using System;
using System.ComponentModel;
using System.Linq;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using AutoKernels.Skills.Web.Google;
using Microsoft.SemanticKernel.SkillDefinition;
using Microsoft.SemanticKernel.Skills.Web;

namespace AutoKernels.Skills.Web;

/// <summary>
/// Web search engine skill in Japanese
/// </summary>
public sealed class WebSearchEngineSkillJp
{
    public const string CountParam = "count";
    public const string OffsetParam = "offset";
    public const string LanguageParam = "language";

    private static readonly Dictionary<string, string> LangCodeToLr = new Dictionary<string, string>()
    {
        {"en","lang_en"},
        {"ja","lang_ja"},
    };

    private readonly GoogleConnectorJp _connector;

    public WebSearchEngineSkillJp(GoogleConnectorJp connector)
    {
        this._connector = connector;
    }

    [SKFunction, Description("Perform a web search.")]
    public async Task<string> SearchAsync(
        [Description("Text to search for")] string query,
        [Description("Number of results")] int count = 1,
        [Description("Number of results to skip")] int offset = 0,
        CancellationToken cancellationToken = default)
    {
        string lr = "lang_ja";
        var results = await this._connector.SearchAsync(query, count, offset, lr, cancellationToken).ConfigureAwait(false);
        if (!results.Any())
        {
            throw new InvalidOperationException("Failed to get a response from the web search engine.");
        }

        return count == 1
            ? results.FirstOrDefault() ?? string.Empty
            : JsonSerializer.Serialize(results);
    }
}
