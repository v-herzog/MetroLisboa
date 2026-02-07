namespace MetroLisboa.Models;

public class Station
{
    public string Id { get; set; }
    public string Name { get; set; }
    public List<Platform> Platforms { get; set; } = new ();
}