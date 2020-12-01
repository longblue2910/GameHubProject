using System;
using System.Collections.Generic;
using System.Text;

namespace GameHub.Domain.Common1
{
    public class PagingResultBase : RequestBase 
    {
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
    }
}
