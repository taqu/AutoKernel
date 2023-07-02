using AutoKernels.Diagnostics;
using Google.Apis.CustomSearchAPI.v1;
using Google.Apis.Services;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.SemanticKernel.Skills.Web;

namespace AutoKernels.Skills.Web.Google;

/// <summary>
/// Google search connector.
/// </summary>
public sealed class GoogleConnectorJp : IWebSearchEngineConnector, IDisposable
{
    private readonly ILogger _logger;
    private readonly CustomSearchAPIService _search;
    private readonly string? _searchEngineId;

    /// <summary>
    /// Google search connector.
    /// </summary>
    /// <param name="apiKey">Google Custom Search API (looks like "ABcdEfG1...")</param>
    /// <param name="searchEngineId">Google Search Engine ID (looks like "a12b345...")</param>
    /// <param name="logger">Optional logger</param>
    public GoogleConnectorJp(
        string apiKey,
        string searchEngineId,
        ILogger<GoogleConnectorJp>? logger = null) : this(new BaseClientService.Initializer { ApiKey = apiKey }, searchEngineId, logger)
    {
        Verify.NotNullOrWhiteSpace(apiKey);
    }

    /// <summary>
    /// Google search connector.
    /// </summary>
    /// <param name="initializer">The connector initializer</param>
    /// <param name="searchEngineId">Google Search Engine ID (looks like "a12b345...")</param>
    /// <param name="logger">Optional logger</param>
    public GoogleConnectorJp(
        BaseClientService.Initializer initializer,
        string searchEngineId,
        ILogger<GoogleConnectorJp>? logger = null)
    {
        Verify.NotNull(initializer);
        Verify.NotNullOrWhiteSpace(searchEngineId);

        this._search = new CustomSearchAPIService(initializer);
        this._searchEngineId = searchEngineId;
        this._logger = logger ?? NullLogger<GoogleConnectorJp>.Instance;
    }

    /// <inheritdoc/>
    public async Task<IEnumerable<string>> SearchAsync(
        string query,
        int count,
        int offset,
        CancellationToken cancellationToken)
    {
        if (count <= 0) { throw new ArgumentOutOfRangeException(nameof(count)); }

        if (count > 10) { throw new ArgumentOutOfRangeException(nameof(count), $"{nameof(count)} value must be between 0 and 10, inclusive."); }

        if (offset < 0) { throw new ArgumentOutOfRangeException(nameof(offset)); }

        var search = this._search.Cse.List();
        search.Cx = this._searchEngineId;
        search.Q = query;
        search.Num = count;
        search.Start = offset;

        var results = await search.ExecuteAsync(cancellationToken).ConfigureAwait(false);

        return results.Items.Select(item => item.Snippet);
    }

    /// <inheritdoc/>
    public async Task<IEnumerable<string>> SearchAsync(
        string query,
        int count,
        int offset,
        string language,
        CancellationToken cancellationToken)
    {
        if (count <= 0) { throw new ArgumentOutOfRangeException(nameof(count)); }

        if (count > 10) { throw new ArgumentOutOfRangeException(nameof(count), $"{nameof(count)} value must be between 0 and 10, inclusive."); }

        if (offset < 0) { throw new ArgumentOutOfRangeException(nameof(offset)); }

        var search = this._search.Cse.List();
        search.Cx = this._searchEngineId;
        search.Q = query;
        search.Num = count;
        search.Start = offset;
        search.Lr = string.IsNullOrEmpty(language) ? "lang_en" : language;

        var results = await search.ExecuteAsync(cancellationToken).ConfigureAwait(false);

        return results.Items.Select(item => item.Snippet);
    }

    private void Dispose(bool disposing)
    {
        if (disposing)
        {
            this._search.Dispose();
        }
    }

    public void Dispose()
    {
        this.Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }
}
