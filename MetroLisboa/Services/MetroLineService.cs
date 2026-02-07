using MetroLisboa.Constants;
using MetroLisboa.Models;
using MetroLisboa.Services.Dtos;
using System.Text.Json;

namespace MetroLisboa.Services;

public class MetroLineService
{
    private readonly HttpClient _httpClient;

    public MetroLineService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<Line>> GetAllAsync()
    {
        try
        {
            var response = await _httpClient.GetAsync("tempoEspera/Estacao/todos");
            response.EnsureSuccessStatusCode();

            var jsonResponse = await response.Content.ReadAsStringAsync();
            var data = JsonSerializer.Deserialize<MetroDataDto>(jsonResponse);
            if (data?.Response is null)
                return new();

            var lines = MetroLines.GetAll();
            
            foreach (var arrival in data!.Response)
            {
                var stations = lines.SelectMany(x => x.Stations)
                    .Where(x => x.Id == arrival.StopId);

                var direction = stations.SelectMany(x => x.Platforms)
                    .FirstOrDefault(x => x.Direction.Id == arrival.DirectionId);

                if (direction != null)
                    direction.NextArrival = arrival.NextArrival.ToMinutes();
            }

            return lines;
        }
        catch (HttpRequestException ex)
        {
            Console.WriteLine($"An error occurred while fetching metro data: {ex.Message}");
        }
        catch (JsonException ex)
        {
            Console.WriteLine($"An error occurred while deserializing metro data: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while parsing metro data: {ex.Message}");
        }
        
        return new();
    }
}