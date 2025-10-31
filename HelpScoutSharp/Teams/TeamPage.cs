namespace HelpScoutSharp
{
    public class TeamPage : IPage<Team>
    {
        public class Embedded
        {
            public Team[] teams { get; set; }
        }

        public Embedded _embedded { get; set; }

        public Page page { get; set; }

        public Team[] entities => _embedded.teams;
    }
}
