using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dk.Dwarf.Example.BusinessLayer.Models
{
    public class MealsAPIResponse
    {
        [JsonProperty("meals")]
        public List<MealModel> Models { get; set; }
    }
}
