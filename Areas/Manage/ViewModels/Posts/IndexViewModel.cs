using Jane.Csm.Web.Infrastructure.Data.Helpers;
using Jane.Csm.Web.Infrastructure.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jane.Csm.Web.Areas.Manage.ViewModels.Posts
{
    public class IndexViewModel
    {
        public Page<Post> Posts { get; set; }
    }
}
