using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace lab13.Models
{
    //table Products
    //relationship: Many Products - 1 Category
    public class Product
    {
        //primary key
        public int ProductId { get; set; }  
        public string ProductName { get; set; }

        [Range(50, 2000)]
        public double ProductPrice { get; set; }    
        public string ProductImage { get; set; }

        //foreign key
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }  
    }
}