using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HOL2.Models
{
    public class product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public IEnumerable<product> GetProducts()
        {
            return new List<product>()
            {
                new product { ProductId = 1,ProductName ="Product1",Price=900.00},
                 new product { ProductId = 2,ProductName ="Product2",Price=700.00},
                  new product { ProductId = 3,ProductName ="Product3",Price=650.00},
                   new product { ProductId = 4,ProductName ="Product4",Price=950.00},
                    new product { ProductId = 5,ProductName ="Product5",Price=800.00},


            };
        }

    }
}