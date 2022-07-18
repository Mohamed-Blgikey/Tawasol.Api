﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tawasol.DAL.Entity;

namespace Tawasol.DAL.Extend
{
    public class AppUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        [Range(0, 1)]
        public bool Gender { get; set; }

        public DateTime CreatedAt { get; set; }

        public ICollection<ProfilePhoto> ProfilePhotos { get; set; }
        public ICollection<CoverPhoto> CoverPhotos { get; set; }

    }
}
