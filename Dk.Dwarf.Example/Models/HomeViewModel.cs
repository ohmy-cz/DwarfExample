using Dk.Dwarf.Example.BusinessLayer.Models;
using System.Collections.Generic;

namespace Dk.Dwarf.Example.Models
{
    public class HomeViewModel
    {
        public List<SelectModel<MealModel>> Meals { get; set; }
        public List<SelectModel<DrinkModel>> Drinks { get; set; }
    }
}
