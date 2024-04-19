public class Film
{
    public string title { get; set; }
    public int episode_id { get; set; }
    public string opening_crawl { get; set; }
    public string director { get; set; }
    public string producer { get; set; }
    public string release_date { get; set; }
    public List<People> characters { get; set; }
    public List<Planet> planets { get; set; }
    public List<Starship> starships { get; set; }
    public List<string> vehicles { get; set; }
    public List<Species> species { get; set; }
    public DateTime created { get; set; }
    public DateTime edited { get; set; }
    public string url { get; set; }
}