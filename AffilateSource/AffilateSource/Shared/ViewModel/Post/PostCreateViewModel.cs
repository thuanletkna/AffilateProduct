using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AffilateSource.Shared.ViewModel.Post
{
    public class PostCreateViewModel
    {
        public int Id { get; set; }

        public int CategoryId { get; set; }
        public int CategoryParentId { get; set; }

        public string StatusId { get; set; }

        public string Title { get; set; }

        public string SeoAlias { get; set; }

        public string Description { get; set; }
        public string ImagePost { get; set; }


        public string Detail { get; set; }



        public string Note { get; set; }


        public string OwnerUserId { get; set; }

        public string Labels { get; set; }
        public DateTime CreateDate { get; set; }
        //public IFormFile PostImage { set; get; }
        //public List<PostDetailVm> DetailPost { get; set; }
    }
}
