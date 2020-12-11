using APIRest_ASPNET5.Hypermedia;
using APIRest_ASPNET5.Hypermedia.Abstract;
using System.Collections.Generic;

namespace APIRest_ASPNET5.Data.VO
{
    public class ClientVO : ISupportHyperMedia
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public string CNH { get; set; }

        public long Age { get; set; }

        public string Gender { get; set; }

        public bool Enabled { get; set; }

        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();
    }
}