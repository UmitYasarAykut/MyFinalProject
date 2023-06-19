using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Category : IEntity
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }       
        
        //public bool ProductName { get; set; }
        //public int ProductId { get; set; }
        //public decimal UnitPrice { get; set; }

    }
}
