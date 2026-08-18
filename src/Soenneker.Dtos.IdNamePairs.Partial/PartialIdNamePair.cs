using Soenneker.Attributes.PublicOpenApiObject;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Soenneker.Dtos.IdNamePairs.Partial;

/// <summary>
/// Represents a partial resource reference in which an identifier, a display name, or both may be supplied.
/// </summary>
[PublicOpenApiObject]
public record PartialIdNamePair
{
    /// <summary>
    /// Stable resource identifier, when known.
    /// </summary>
    [JsonPropertyName("id")]
    [JsonProperty("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Human-readable resource name, when known.
    /// </summary>
    [JsonPropertyName("name")]
    [JsonProperty("name")]
    public string? Name { get; set; }
}
