using System.Collections.Generic;

namespace APIRest_ASPNET5.Hypermedia.Abstract
{
    public interface ISupportHyperMedia
    {
        List<HyperMediaLink> Links { get; set; }
    }
}