using System;
using System.Collections.Generic;
using System.Text;

namespace GameHub.Domain.Response.Rate
{
    public class RateView
    {
        public int RateId { get; set; }
        public int Vote { get; set; }
        public string UserId { get; set; }
    }
}
