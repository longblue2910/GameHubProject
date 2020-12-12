using System;
using System.Collections.Generic;
using System.Text;

namespace GameHub.Domain.Response.Category
{
    public class CategoryView
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string StatusName { get; set; }
    }
}
