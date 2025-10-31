﻿using Flurl;
using System.Threading.Tasks;

namespace HelpScoutSharp
{
    public class RatingService : ServiceBase
    {
        public RatingService(string accessToken)
            : base(accessToken, "ratings")
        {
        }

        public async Task<Rating> GetAsync(long ratingId)
        {
            return await _client.GetAsync<Rating>(new Url(_serviceUri).AppendPathSegment(ratingId).ToUri());
        }
    }
}
