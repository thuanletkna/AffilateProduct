using ProductAffilate.ViewModel.ViewModel.Post;
using ProductAffilate.ViewModel.ViewModel.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AffilateSource.Shared.ViewModel.Post
{
    public class ListPostDetailVm : ProductHomeViewModel
    {
        public string Content { get; set; }
        public int ProductId { get; set; }
        public int PostId { get; set; }
        public int StatusIdDetail { get; set; }
        public int StatusId { get; set; }
        public int SortDetail { get; set; }
    }
}
