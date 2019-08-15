using Newtonsoft.Json;

namespace Dk.Dwarf.Example.BusinessLayer.Models
{
    public class DrinkModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("tagline")]
        public string Tagline { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("image_url")]
        public string Thumbnail { get; set; }
    }
}
