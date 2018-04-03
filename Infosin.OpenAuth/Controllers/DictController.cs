using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Infosin.OpenAuth.Application.DictApp;

namespace Infosin.OpenAuth.Controllers
{
    public class DictController : BaseController
    {
        private readonly IDictService _service;
        public DictController(IDictService service)
        {
            _service = service;
        }


        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetAllPageList(int startPage, int pageSize,string dictName)
        {
            int rowCount = 0;
            var result = _service.GetList(startPage, pageSize, out rowCount);
            return Json(new
            {
                total = rowCount,
                rows = result,
            });
        }
    }
}