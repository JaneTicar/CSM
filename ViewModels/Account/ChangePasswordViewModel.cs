﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jane.Csm.Web.ViewModels.Account
{
    public class ChangePasswordViewModel
    {
        public string OldPassword { get; set; }

        public string NewPassword { get; set; }

        public string ConfirmNewPassword { get; set; }
    }
}
