using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameHub.WEB.Models.Category;
using GameHub.WEB.Ultilities;
using Microsoft.AspNetCore.Mvc;

namespace GameHub.WEB.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public JsonResult Gets()
        {
            List<CategoryView> result = ApiHelper<List<CategoryView>>.HttpGetAsync($"category/gets");
            return Json(new { result });
        }
        [HttpPost]
        [Route("/category/save")]
        public JsonResult Save([FromBody] SaveCategory request)
        {
            var result = ApiHelper<CategoryResult>.HttpPostAsync($"category/save", "POST", request);
            return Json(new { data = result });
        }
    }
}
