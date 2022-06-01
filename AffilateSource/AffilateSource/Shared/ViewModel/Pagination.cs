using AffilateSource.Shared.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductAffilate.ViewModel.ViewModel
{
    public class Pagination<T> : PaginationBase where T : class
    {



        public List<T> Items { get; set; }



    }
}
