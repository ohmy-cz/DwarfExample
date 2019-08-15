using Dk.Dwarf.Example.BusinessLayer.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;

namespace Dk.Dwarf.Example.BusinessLayer.Services
{
    public class MealsService
    {
        readonly string _ApiEndpoint;
        public MealsService(string apiEndpoint)
        {
            _ApiEndpoint = apiEndpoint ?? throw new ArgumentNullException(nameof(apiEndpoint));
        }

        public List<MealModel> GetMeals()
        {
            var result = new List<MealModel>();
            using (WebClient wc = new WebClient())
            {
                var json = wc.DownloadString(_ApiEndpoint);
                result = JsonConvert.DeserializeObject<MealsAPIResponse>(json).Models;
            }
            return result;
        }
    }
}
