using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandLineApi.Core.Pagination
{
    public class PaginationRule
    {
        /*public static PaginationModel<IEnumerable<TSource>> PaginationAsync <TSource>
            (IEnumerable<TSource> source, int pageSize, int pageNumber)
        {
            var count = source.Count();
            var pageRes = new PaginationModel<IEnumerable<TSource>>
                {
                    PageSize = (pageSize >10 || pageSize< 1) ? 10 : pageSize,
                    CurrentPage = pageNumber >= pageSize ? pageNumber : 1,
                    PreviousPage = pageNumber > 0 ? pageNumber - 1 : 0,
                };
            pageRes.TotalNumberOfPages = (int)Math.Ceiling(count/(double)(pageRes.PageSize));
            var list = source.Skip((pageRes.CurrentPage - 1) * pageRes.PageSize).Take(pageRes.PageSize).ToList();
            return pageRes;
        }*/
    }
}
