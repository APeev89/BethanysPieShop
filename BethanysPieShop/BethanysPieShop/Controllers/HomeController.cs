using BethanysPieShop.Models;
using BethanysPieShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BethanysPieShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPieRepository _pieRepositry;

        public HomeController(IPieRepository pieRepository)
        {
            _pieRepositry = pieRepository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                PiesOfTheWeek = _pieRepositry.PiesOfTheWeek,
            };
            return View(homeViewModel);
        }
    }
}
