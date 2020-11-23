using System;
using System.Collections.Generic;
using System.Text;

namespace GameHub.Domain.Request.Rate
{
    public class SaveRateReq
    {
        public int RateId { get; set; }
        public int GameId { get; set; }
        public int Vote { get; set; }
        public string UserId { get; set; }
    }
}
