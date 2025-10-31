namespace HelpScoutSharp
{
    public class MemberPage : IPage<User>
    {
        public class Embedded
        {
            public User[] users { get; set; }
        }

        public Embedded _embedded { get; set; }

        public Page page { get; set; }

        public User[] entities => _embedded.users;
    }
}
