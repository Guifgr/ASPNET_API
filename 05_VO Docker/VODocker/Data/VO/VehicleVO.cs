using APIRest_ASPNET5.Hypermedia;
using APIRest_ASPNET5.Hypermedia.Abstract;
using System.Collections.Generic;

namespace APIRest_ASPNET5.Data.VO
{
    public class VehicleVO : ISupportHyperMedia
    {
        public long Id { get; set; }

        public string Model { get; set; }

        public long Year { get; set; }

        public string Plate { get; set; }

        public string Color { get; set; }

        public bool Enabled { get; set; }
        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();
    }
}