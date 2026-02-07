using MetroLisboa.Components;
using MetroLisboa.Services;

const string metroApiClient = "MetroApiClient";

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddHttpClient(metroApiClient, client =>
{
    var baseAddress = builder.Configuration[$"{metroApiClient}:BaseAddress"];
    var authorization = builder.Configuration[$"{metroApiClient}:Authorization"];
    
    client.BaseAddress = new Uri(baseAddress!);
    client.DefaultRequestHeaders.Add("Authorization", authorization);
});

builder.Services.AddScoped<MetroLineService>();
builder.Services.AddSingleton<TimerService>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();