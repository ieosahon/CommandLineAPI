using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandLineApi.Core.Pagination
{
    public class PaginationModel<T>
    {
        public T PageItems { get; set; }
        public int PageSize { get; set; }
        public int CurrentPage { get; set; }
        public int TotalNumberOfPages { get; set; }
        public int PreviousPage { get; set; }
    }
}
