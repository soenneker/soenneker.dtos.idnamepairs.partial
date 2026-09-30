using Soenneker.Attributes.PublicOpenApiObject;
using System.Text.Json.Serialization;

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
    public string? Id { get; set; }

    /// <summary>
    /// Human-readable resource name, when known.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}
