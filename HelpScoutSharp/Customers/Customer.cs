﻿namespace HelpScoutSharp;

public class Customer : IHasId
{
    public class Embedded
    {
        public class CustomerEmail : IHasId
        {
            public long id { get; set; }
            public string type { get; set; }
            public string value { get; set; }
        }

        public class CustomerPhone : IHasId
        {
            public long id { get; set; }
            public string type { get; set; }
            public string value { get; set; }
        }

        public class CustomerChat : IHasId
        {
            public long id { get; set; }
            public string type { get; set; }
            public string value { get; set; }
        }

        public class CustomerSocialProfile : IHasId
        {
            public long id { get; set; }
            public string type { get; set; }
            public string value { get; set; }
        }

        public class CustomerWebsite : IHasId
        {
            public long id { get; set; }
            public string value { get; set; }
        }

        public class CustomerAddress
        {
            public string city { get; set; }

            public string state { get; set; }

            public string postalCode { get; set; }

            public string country { get; set; }

            public string[] lines { get; set; }
        }

        public class CustomerProperty
        {
            public class CustomerPropertySource
            {
                public string name { get; set; }
            }

            public string name { get; set; }

            public string slug { get; set; }

            public CustomerPropertySource source { get; set; }

            public string text { get; set; }

            public string type { get; set; }

            public string value { get; set; }
        }

        public CustomerEmail[] emails { get; set; }

        public CustomerPhone[] phones { get; set; }

        public CustomerChat[] chats { get; set; }

        public CustomerSocialProfile[] social_profiles { get; set; }

        public CustomerWebsite[] websites { get; set; }

        public CustomerAddress address { get; set; }

        public CustomerProperty[] properties { get; set; }
    }

    public long id { get; set; }

    public string firstName { get; set; }

    public string lastName { get; set; }

    public string phone { get; set; }

    public string photoUrl { get; set; }

    public string jobTitle { get; set; }

    public string photoType { get; set; }

    public string background { get; set; }

    public string location { get; set; }

    public string organization { get; set; }

    public string gender { get; set; }

    public string age { get; set; }

    public DateTime createdAt { get; set; }

    public DateTime updatedAt { get; set; }

    public Embedded _embedded { get; set; }
}
