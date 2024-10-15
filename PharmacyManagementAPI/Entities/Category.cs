﻿using System.ComponentModel.DataAnnotations;

namespace PharmacyManagementAPI.Entities
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
