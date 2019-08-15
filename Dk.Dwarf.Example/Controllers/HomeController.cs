using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Dk.Dwarf.Example.Models;
using Dk.Dwarf.Example.BusinessLayer.Services;
using Dk.Dwarf.Example.BusinessLayer.Models;

namespace Dk.Dwarf.Example.Controllers
{
    public class HomeController : Controller
    {
        readonly MealsService _mealsService;
        readonly DrinksService _drinksService;
        public HomeController(MealsService mealsService, DrinksService drinksService)
        {
            _mealsService = mealsService ?? throw new ArgumentNullException(nameof(mealsService));
            _drinksService = drinksService ?? throw new ArgumentNullException(nameof(drinksService));
        }
        public IActionResult Index()
        {
            var model = new HomeViewModel {
                Meals = _mealsService.GetMeals().Select(m => new SelectModel<MealModel>(m)).ToList(),
                Drinks = _drinksService.GetDrinks().Select(d => new SelectModel<DrinkModel>(d)).ToList()
            };
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
