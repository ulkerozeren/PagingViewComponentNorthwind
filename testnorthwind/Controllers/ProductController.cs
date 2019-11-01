using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using testnorthwind.Interfaces;
using testnorthwind.Models;

namespace testnorthwind.Controllers
{
    public class ProductController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public ProductController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            return View();
        }
     //   public IActionResult GetByCategoryId(int id)
        public IActionResult GetByCategoryId(int id, int page = 1, int pageSize = 3)
        {
            var productList= _unitOfWork.ProductRepository.GetByCategoryId(id);
            X.PagedList.PagedList<Product> model = new X.PagedList.PagedList<Product>(productList.Where(x => x.CategoryID == id), page, pageSize);
            return View(model);
        }
    }
}