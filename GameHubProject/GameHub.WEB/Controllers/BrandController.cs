using GameHub.WEB.Models.Brand;
using GameHub.WEB.Models.Category;
using GameHub.WEB.Ultilities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GameHub.WEB.Controllers
{
    public class BrandController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public JsonResult Gets()
        {
            List<BrandView> result = ApiHelper<List<BrandView>>.HttpGetAsync($"brand/gets");
            return Json(new { result });
        }
        [HttpPost]
        [Route("/brand/save")]
        public JsonResult Save([FromBody] SaveBrand request)
        {
            var result = ApiHelper<BrandResult>.HttpPostAsync($"brand/save", "POST", request);
            return Json(new { data = result });
        }
        [HttpPost]
        [Route("/brand/delete/{id}")]
        public IActionResult Delete(int id)
        {
            var result = ApiHelper<BrandResult>.HttpPatchAsync($"Brand/Delete/{id}", null);
            return Json(new { data = result });
        }
        [HttpGet]
        [Route("/brand/get/{id}")]
        public JsonResult Get(int id)
        {
            var brand = ApiHelper<BrandView>.HttpGetAsync($"brand/get/{id}");
            return Json(new { data = brand });
        }
    }
}
