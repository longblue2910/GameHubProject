using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameHub.WEB.Models.Category;
using GameHub.WEB.Ultilities;
using Microsoft.AspNetCore.Authorization;
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
            var result = ApiHelper<IEnumerable<CategoryView>>.HttpGetAsync($"Category/gets");
            return Json(new { result });
        }
        [HttpPost]
        [Route("/category/save")]
        public JsonResult Save([FromBody] SaveCategory request)
        {
            var result = ApiHelper<CategoryResult>.HttpPostAsync($"category/save", "POST", request);
            return Json(new { data = result });
        }
        [HttpPost]
        [Route("/category/delete/{id}")]
        public IActionResult Delete(int id)
        {
            var result = ApiHelper<CategoryResult>.HttpPatchAsync($"Category/Delete/{id}", null);
            return Json(new { data = result });
        }
        [HttpGet]
        [Route("/category/get/{id}")]
        public JsonResult Get(int id)
        {
            var category = ApiHelper<CategoryView>.HttpGetAsync($"category/get/{id}");
            return Json(new { data = category });
        }
    }
}
