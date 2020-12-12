using GameHub.Domain.Common1;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameHub.Domain.Request.User
{
    public class GetUserPagingRequest : PagingResultBase
    {
        public string Keyword { get; set; }
    }
}
