using Newtonsoft.Json;
using System;

namespace ngServer
{

    public partial class Seccion : ISeccion
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("time")]
        public string Time { get; set; }

        [JsonProperty("location")]
        public Location Location { get; set; }

        [JsonProperty("ImageUrl")]
        public string ImageUrl { get; set; }

        [JsonProperty("secciones", NullValueHandling = NullValueHandling.Ignore)]
        public Seccione[] Secciones { get; set; }
    }

    public interface ISeccion
    {

    }

    public partial class Location
    {
        [JsonProperty("room")]
        public string Room { get; set; }

        [JsonProperty("campus")]
        public string Campus { get; set; }
    }

    public partial class Seccione
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("profesor")]
        public string Profesor { get; set; }

        [JsonProperty("duracion")]
        public string Duracion { get; set; }

        [JsonProperty("descripcion")]
        public string Descripcion { get; set; }
    }
}