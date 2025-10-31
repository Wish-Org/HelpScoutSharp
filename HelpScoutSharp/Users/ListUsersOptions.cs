namespace HelpScoutSharp;

public class ListUsersOptions : ListOptions
{
    public string email { get; set; }

    public long? mailbox { get; set; }
}
