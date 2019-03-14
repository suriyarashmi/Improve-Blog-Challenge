using System;
using Newtonsoft.Json;

namespace SimpleBlog.FrontEnd.Models 
{
    public class Post 
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }

        //Colour page
        [JsonProperty("colour")]
        public ColourGroup Colour{get; set;}

        [JsonProperty("image")]
        public string Image { get; set; }
    }
}