//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace lab11
{
    using System;
    using System.Collections.Generic;
    
    public partial class Inventory
    {
        public Inventory()
        {
            this.Orders = new HashSet<Order>();
        }
    
        public int CarId { get; set; }
        public string Make { get; set; }
        public string Color { get; set; }
        public string PetName { get; set; }
    
        public virtual ICollection<Order> Orders { get; set; }
    }
}
