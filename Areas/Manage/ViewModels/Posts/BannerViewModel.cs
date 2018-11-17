﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jane.Csm.Web.Areas.Manage.ViewModels.Posts
{
    public class BannerViewModel
    {
        public Guid? PostId { get; set; }

        public IFormFile Thumbnail { get; set; }
    }
}
