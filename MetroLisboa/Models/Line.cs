namespace MetroLisboa.Models;

public class Line
{
    public string Name { get; set; }
    public List<Direction> Directions { get; set; }
    public List<Station> Stations { get; set; } = new ();
}