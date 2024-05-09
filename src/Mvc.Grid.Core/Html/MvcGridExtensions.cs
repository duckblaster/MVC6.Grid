using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NonFactors.Mvc.Grid
{
    public static class MvcGridExtensions
    {
        public static HtmlGrid<T> Grid<T>(this IHtmlHelper html, IEnumerable<T> source) where T : class
        {
            return new HtmlGrid<T>(html, new Grid<T>(source, html.ViewContext.HttpContext.RequestServices.GetRequiredService<ModelExpressionProvider>()));
        }
        public static HtmlGrid<T> Grid<T>(this IHtmlHelper html, String partialViewName, IEnumerable<T> source) where T : class
        {
            return new HtmlGrid<T>(html, new Grid<T>(source, html.ViewContext.HttpContext.RequestServices.GetRequiredService<ModelExpressionProvider>())) { PartialViewName = partialViewName };
        }

        public static Task<IHtmlContent> AjaxGrid(this IHtmlHelper html, String dataSource)
        {
            return html.PartialAsync("MvcGrid/_AjaxGrid", dataSource);
        }

        public static IServiceCollection AddMvcGrid(this IServiceCollection services)
        {
            return services.AddMvcGrid(filters => { });
        }
        public static IServiceCollection AddMvcGrid(this IServiceCollection services, Action<IGridFilters> configure)
        {
            IGridFilters filters = new GridFilters();
            configure(filters);

            return services.AddSingleton(filters);
        }
    }
}
