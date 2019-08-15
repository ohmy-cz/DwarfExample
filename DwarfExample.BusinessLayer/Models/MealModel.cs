﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Models
{
    public class MealModel
    {
        [JsonProperty("idMeal")]
        public int Id { get; set; }
        [JsonProperty("strMeal")]
        public string Name { get; set; }
        [JsonProperty("strCategory")]
        public string Category { get; set; }
        [JsonProperty("strArea")]
        public string Area { get; set; }
        [JsonProperty("strInstructions")]
        public string Instructions { get; set; }
        [JsonProperty("strMealThumb")]
        public string Thumbnail { get; set; }
    }
}
