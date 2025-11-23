namespace HelpScoutSharp;

public class Organization : IHasId
{
    public long id { get; set; }

    public string name { get; set; }

    public string website { get; set; }

    public string description { get; set; }

    public string location { get; set; }

    public string logoUrl { get; set; }

    public string[] domains { get; set; }

    public string[] phones { get; set; }

    public string brandColor { get; set; }

    public long customerCount { get; set; }

    public long conversationCount { get; set; }
}