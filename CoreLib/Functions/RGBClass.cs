namespace CoreLib;

public class RGBClass
{
    public static Func<string, (int R, int G, int B)> GetRgbValue = delegate (string color)
    {
        return color.ToLower() switch
        {
            "red" => (255, 0, 0),
            "orange" => (255, 165, 0),
            "yellow" => (255, 255, 0),
            "green" => (0, 255, 0),
            "blue" => (0, 0, 255),
            "indigo" => (75, 0, 130),
            "violet" => (238, 130, 238),
            _ => throw new ArgumentException("Invalid rainbow color."),
        };
    };
}
