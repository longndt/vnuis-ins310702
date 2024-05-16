using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace lab13.Models
{
    //table Categories
    //relationship: 1 Category - Many Products
    public class Category
    {
        //primary key
        public int CategoryId { get; set; }

        //add validation to field/attribute/column
        [Required]
        [MinLength(5)]
        [MaxLength(100)]
        public string CategoryName { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}