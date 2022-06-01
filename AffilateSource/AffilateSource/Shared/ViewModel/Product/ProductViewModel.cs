using AffilateSource.Shared.ViewModel;
using AffilateSource.Shared.ViewModel.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAffilate.ViewModel.ViewModel.Product
{
    public class ProductViewModel
    {
        public DataEnvelope<ProductHomeViewModel> ProductListAll { get; set; }
        public ProductHomeViewModel GetProductById { get; set; }
        public DataEnvelope<ProductHomeViewModel> ProductListAllByCategoryid { get; set; }
        public List<CategoryQuickVM> GetDanhMucKhuyenMai { get; set; }
    }
}
