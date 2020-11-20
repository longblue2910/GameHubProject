//using GameHub.Domain;
//using GameHub.Domain.Response;
//using Microsoft.AspNetCore.Hosting;
//using Microsoft.AspNetCore.Mvc;
//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Threading.Tasks;

//namespace GameHub.API.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class FileUploadController : ControllerBase
//    {
//        private readonly IWebHostEnvironment webHostEnvironment;

//        public FileUploadController(IWebHostEnvironment webHostEnvironment)
//        {
//            this.webHostEnvironment = webHostEnvironment;
//        }
//        public async Task<List<Result>> Post([FromForm] FilesUpload filesUpload)
//        {
//            var result = new List<Result>();
//            if (filesUpload.Files.Count() > 0)
//            {
//                try
//                {
//                    if (!Directory.Exists(webHostEnvironment.WebRootPath + "\\images\\"))
//                    {
//                        Directory.CreateDirectory(webHostEnvironment.WebRootPath + "\\images\\");
//                    }
//                    foreach (var file in filesUpload.Files)
//                    {
//                        var fileName = $"{Guid.NewGuid()}{Path.GetExtension(file.FileName)}";
//                        await using (FileStream fileStream = System.IO.File.Create(webHostEnvironment.WebRootPath + "\\images\\" + fileName))
//                        {
//                            file.CopyTo(fileStream);
//                            fileStream.Flush();
//                            result.Add(new Result()
//                            {
//                                Id = 1,
//                                Message = fileName
//                            });
//                        }
//                    }
//                }
//                catch (Exception e)
//                {
//                    result.Add(new Result()
//                    {
//                        Id = 0,
//                        Message = e.Message.ToString()
//                    });
//                }
//            }
//            else
//            {
//                result.Add(new Result()
//                {
//                    Id = 0,
//                    Message = "Error"
//                });
//            }
//            return result;
//        }

//    }
//}
