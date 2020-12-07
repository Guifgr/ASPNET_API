using System.Collections.Generic;

namespace APIRest_ASPNET5.Hypermedia.Abstract
{
    public interface ISupportHypermedia
    {
        List<HypermediaLink> Links { get; set; }
    }
}
