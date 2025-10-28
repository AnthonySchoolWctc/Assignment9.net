public class CharacterDTO
{
  public UInt64 Id { get; set; }
  public string? Name { get; set; }
  public List<string> Series { get; set; } = [];
  public List<string> Alias { get; set; } = [];
  public string Display()
  {
    return $"Id: {Id}\nName: {Name}\nSeries: {string.Join(", ", Series)}\n";
  }
  public string DisplayNameAndSeries()
  {
    return $"Name: {Name}\nSeries: {string.Join(", ", Series)}\n";
  }
  public string DisplayNameAndSeriesAndAlias()
  {
    return $"Name: {Name}\nSeries: {string.Join(", ", Series)}\nAlias's: {string.Join(", ", Alias)}";
  }
  
}
