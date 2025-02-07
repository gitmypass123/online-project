﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Models
{
    public class ProductTypes
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "ProductType")]
        public String ProductType { get; set; }
    }
}
