using System.Threading.Tasks;

namespace APIRest_ASPNET5.Hypermedia.Abstract
{
    public interface IResponseEnricher
    {
        bool CanEnrich(ResultExecutingContent context);
        Task Enrich(ResultExecutingContent context);
    }
}
