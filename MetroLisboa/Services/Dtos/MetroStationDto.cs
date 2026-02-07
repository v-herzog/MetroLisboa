using System.Text.Json.Serialization;

namespace MetroLisboa.Services.Dtos;

public class MetroStationDto
{
    [JsonPropertyName("stop_id")]
    public string? StopId { get; set; }

    [JsonPropertyName("tempoChegada1")]
    public string? NextArrival { get; set; }

    [JsonPropertyName("destino")]
    public string? DirectionId { get; set; }
}