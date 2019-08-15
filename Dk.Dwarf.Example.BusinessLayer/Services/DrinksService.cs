using Dk.Dwarf.Example.BusinessLayer.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Dk.Dwarf.Example.BusinessLayer.Services
{
    public class DrinksService
    {
        readonly string _ApiEndpoint;
        public DrinksService(string apiEndpoint)
        {
            _ApiEndpoint = apiEndpoint ?? throw new ArgumentNullException(nameof(apiEndpoint));
        }

        public List<DrinkModel> GetDrinks()
        {
            var result = new List<DrinkModel>();
            using (WebClient wc = new WebClient())
            {
                var json = wc.DownloadString(_ApiEndpoint + "/beers");
                result = JsonConvert.DeserializeObject<List<DrinkModel>>(json);
            }
            return result;
        }
    }
}
