public class FeatureCollection
{
    public class Geometry
    {
        public string type { get; set; }
        public double[] coordinates { get; set; }
    }

    public class Properties
    {
        public double mag { get; set; }
        public string place { get; set; }
        public long time { get; set; }
    }

    public class Feature
    {
        public string type { get; set; }
        public Geometry geometry { get; set; }
        public Properties properties { get; set; }
    }

    // FeatureCollection properties
    public string type { get; set; }
    public Feature[] features { get; set; }

    public DateTime timeNow()
    {
        return DateTime.Now;
    }

    public string[] DailyEarthquakeList()
    {
        List<string> result = new List<string>();
        var today = timeNow();
        var today_earthquakes = features.Where(f =>
    DateTimeOffset.FromUnixTimeMilliseconds(f.properties.time).UtcDateTime >= today.AddHours(-24) &&
    DateTimeOffset.FromUnixTimeMilliseconds(f.properties.time).UtcDateTime <= today);

        for (int i = 0; i <= 5; i++)
        {
            result.Add($"{today_earthquakes.ElementAt(i).properties.place} - Mag {today_earthquakes.ElementAt(i).properties.mag}");
        }
        return result.ToArray();
    }
}