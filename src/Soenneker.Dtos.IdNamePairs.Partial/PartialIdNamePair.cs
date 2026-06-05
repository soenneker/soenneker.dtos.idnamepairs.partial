using Soenneker.Attributes.PublicOpenApiObject;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Soenneker.Dtos.IdNamePairs.Partial;

/// <summary>
/// A flexible ID/name container where either field may be missing, used when either of them isn't guaranteed.
/// </summary>
[PublicOpenApiObject]
public record PartialIdNamePair
{
    /// <summary>
    /// Gets or sets id.
    /// </summary>
    [JsonPropertyName("id")]
    [JsonProperty("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Gets or sets name.
    /// </summary>
    [JsonPropertyName("name")]
    [JsonProperty("name")]
    public string? Name { get; set; }
}