using System.Timers;
using MetroLisboa.Models;

namespace MetroLisboa.Services;

public class TimerService
{
    private readonly HttpClient _httpClient;
    private readonly System.Timers.Timer _timer;

    public List<Line> CurrentMetroStatuses { get; private set; } = [];
    public event Action OnChange;
    public DateTime LastUpdated { get; private set; }

    public TimerService(IHttpClientFactory httpClientFactory)
    {
        _httpClient = httpClientFactory.CreateClient("MetroApiClient");

        _timer = new System.Timers.Timer(10000);
        _timer.Elapsed += OnTimerElapsed;
        _timer.AutoReset = true;
        _timer.Enabled = true;
        
        _ = FetchMetroDataAsync();
    }

    private async void OnTimerElapsed(object sender, ElapsedEventArgs e)
    {
        await FetchMetroDataAsync();
    }

    private async Task FetchMetroDataAsync()
    {
        var metroLineService = new MetroLineService(_httpClient);
        
        CurrentMetroStatuses = await metroLineService.GetAllAsync();
        LastUpdated = DateTime.Now;
        
        OnChange?.Invoke();
    }
}