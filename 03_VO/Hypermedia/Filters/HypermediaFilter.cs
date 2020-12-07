using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace APIRest_ASPNET5.Hypermedia.Filters
{
    public class HyperMediaFilter : ResultFilterAttribute
    {
        private readonly HyperMediaFilterOptions _hypermediaFilterOptions;

        public HyperMediaFilter(HyperMediaFilterOptions _hypermediaFilterOptions)
        {
            _hypermediaFilterOptions = _hypermediaFilterOptions;
        }

        public override void OnResultExecuting(ResultExecutingContext context)
        {
            TryEnrichResult(context);
            base.OnResultExecuting(context);
        }

        private void TryEnrichResult(ResultExecutingContext context)
        {
            throw new NotImplementedException();
        }
    }
}