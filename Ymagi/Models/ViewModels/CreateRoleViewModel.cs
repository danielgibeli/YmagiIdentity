﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ymagi.Models.ViewModels
{
    public class CreateRoleViewModel
    {
        [Required]
        public int RoleName { get; set; }
    }
}
