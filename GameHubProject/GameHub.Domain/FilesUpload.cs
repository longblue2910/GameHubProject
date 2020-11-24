using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace GameHub.Domain
{
    public class FilesUpload
    {
        public IEnumerable<IFormFile> Files { get; set; }

    }
}
