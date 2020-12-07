using APIRest_ASPNET5.Hypermedia.Abstract;
using System.Collections.Generic;

namespace APIRest_ASPNET5.Hypermedia.Filters
{
    public class HipermediaFilterOptions
    {
        public List<IResponseEnricher> ContentResponseEnricherList { get; set; } = new List<IResponseEnricher>();
    }
}
