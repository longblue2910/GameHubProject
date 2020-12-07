using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameHub.Domain.Request.Role
{
    public class SelectItem
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public bool Selected { get; set; }

    }
}
