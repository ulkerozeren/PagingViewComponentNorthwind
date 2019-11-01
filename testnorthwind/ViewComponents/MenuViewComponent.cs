using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testnorthwind.Interfaces;

namespace testnorthwind.ViewComponents
{    
    public class MenuViewComponent: ViewComponent
    {
        private readonly IUnitOfWork _unitOfWork;
        public MenuViewComponent(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IViewComponentResult Invoke()
        {
            var categories = _unitOfWork.CategoryRepository.List();
            return View(categories);
        }
    }
}
