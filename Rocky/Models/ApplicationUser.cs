﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rocky.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
    }
}
