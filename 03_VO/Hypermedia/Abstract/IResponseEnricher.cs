using System.Threading.Tasks;

namespace APIRest_ASPNET5.Hypermedia.Abstract
{
    public interface IResponseEnricher
    {
        bool CanEnrich(ResultExecuteContent context);
        Task Enrich(ResultExecuteContent context);
    }
}
