using BethanysPieShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace BethanysPieShop.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository _pieRepositry;
        private readonly ICategoryRepository _categoryRepository;

        public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
        {
            _pieRepositry = pieRepository;
            _categoryRepository = categoryRepository;
        }
      public ViewResult List()
        {
            return View(_pieRepositry.AllPies);
        }
    }
}
