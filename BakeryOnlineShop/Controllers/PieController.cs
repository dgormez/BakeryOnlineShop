using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BakeryOnlineShop.Model;
using BakeryOnlineShop.ViewModel;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BakeryOnlineShop.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository _pieRespository;
        private readonly ICategoryRepository _categoryRepository;

        public PieController(IPieRepository pieRespository, ICategoryRepository categoryRepository)
        {
            _pieRespository = pieRespository;
            _categoryRepository = categoryRepository;
        }

        public ViewResult List()
        {
            PiesListViewModel piesLisViewModel = new PiesListViewModel();
            piesLisViewModel.Pies = _pieRespository.Pies;
            piesLisViewModel.CurrentCategory = "Cheese Cakes";

            //ViewBag.CurrentCategory = "Cheese cakes";
            return View(piesLisViewModel);
        }

        // GET: /<controller>/
        /*public IActionResult Index()
        {
            return View();
        }*/
    }
}
