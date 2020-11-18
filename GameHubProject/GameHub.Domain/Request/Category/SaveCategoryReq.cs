using System;
using System.Collections.Generic;
using System.Text;

namespace GameHub.Domain.Request.Category
{
    public class SaveCategoryReq
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
