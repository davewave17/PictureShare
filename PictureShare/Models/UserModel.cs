﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace PictureShare.Models
{
    public class UserModel : IdentityUser
    {
        public string FirstName { get; set; }
        public string Surname { get; set; }

    }
}
