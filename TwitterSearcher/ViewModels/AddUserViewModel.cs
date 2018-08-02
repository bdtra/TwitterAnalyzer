﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TwitterSearcher.ViewModels
{
    public class AddUserViewModel
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Verify { get; set; }

        public int UserID { get; set; }


        public AddUserViewModel()
        {

        }
    }
}
