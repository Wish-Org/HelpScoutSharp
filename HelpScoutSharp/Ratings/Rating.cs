﻿using System;

namespace HelpScoutSharp
{
    public class Rating : IHasId
    {
        public class RatingCustomer : IHasId
        {
            public long id { get; set; }

            public string email { get; set; }

            public string firstName { get; set; }

            public string lastName { get; set; }

            public string photoUrl { get; set; }
        }

        public class RatingUser : IHasId
        {
            public long id { get; set; }

            public string email { get; set; }

            public string firstName { get; set; }

            public string lastName { get; set; }
        }

        public long id { get; set; }

        public long threadId { get; set; }

        public long conversationId { get; set; }

        public long mailboxId { get; set; }

        public string comments { get; set; }

        public string rating { get; set; }

        public DateTime createdAt { get; set; }

        public DateTime modifiedAt { get; set; }

        public RatingUser user { get; set; }

        public RatingCustomer customer { get; set; }
    }
}
