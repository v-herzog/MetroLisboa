using System.Text.Json.Serialization;

namespace MetroLisboa.Services.Dtos;

public class MetroDataDto
{
    [JsonPropertyName("resposta")]
    public List<MetroStationDto>? Response { get; set; }
}