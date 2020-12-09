using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Linq;
using System.Threading.Tasks;

namespace APIRest_ASPNET5.Hypermedia.Filters
{
    public class HyperMediaFilter : ResultFilterAttribute
    {
        private readonly HyperMediaFilterOptions _hyperMediaFilterOptions;

        public HyperMediaFilter(HyperMediaFilterOptions hyperMediaFilterOptions)
        {
            _hyperMediaFilterOptions = hyperMediaFilterOptions;
        }

        public override void OnResultExecuting(ResultExecutingContext context)
        {
            TryEnrichResult(context);
            base.OnResultExecuting(context);
        }

        private void TryEnrichResult(ResultExecutingContext context)
        {
            if (context.Result is OkObjectResult okObjectResult)
            {
                var Enricher = _hyperMediaFilterOptions
                    .ContentResponseEnricherList
                    .FirstOrDefault(x => x.CanEnrich(context));
                if (Enricher != null) Task.FromResult(Enricher.Enrich(context));
            };
        }
    }
}