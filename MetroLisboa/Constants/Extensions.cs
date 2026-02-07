namespace MetroLisboa.Constants;

public static class Extensions
{
    public static string? ToMinutes(this string? seconds)
    {
        var result = int.TryParse(seconds, out var value);
        if (!result || value < 0)
            return null;
        
        return $"{value / 60:D2}:{value % 60:D2}";
    }
}