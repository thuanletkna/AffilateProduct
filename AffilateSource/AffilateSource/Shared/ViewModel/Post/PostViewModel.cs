using AffilateSource.Shared.ViewModel;
using AffilateSource.Shared.ViewModel.Category;
using AffilateSource.Shared.ViewModel.Post;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAffilate.ViewModel.ViewModel.Post
{
    public class PostViewModel
    {
        public DataEnvelope<PostHomeViewModel> PostListAll { get; set; }
        public DataEnvelope<PostHomeViewModel> GetAllPostByCategoryIdPaging { get; set; }
        public List<CategoryQuickVM> GetDanhMucKinhNghiem { get; set; }
        public List<ListPostDetailVm> DetailPostbyId { get; set; }
        public PostHomeViewModel GetPostById { get; set; }
    }
}
