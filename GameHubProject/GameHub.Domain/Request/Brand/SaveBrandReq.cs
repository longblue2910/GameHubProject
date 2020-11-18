using System;
using System.Collections.Generic;
using System.Text;

namespace GameHub.Domain.Request.Brand
{
    public class SaveBrandReq
    {
        public int BrandId { get; set; }
        public string BrandName { get; set; }
    }
}
