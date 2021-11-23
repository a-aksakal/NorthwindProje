using System;
using System.Collections.Generic;

#nullable disable

namespace NorthwindProje_WFA.Models
{
    public partial class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public byte[] Picture { get; set; }

        public virtual ICollection<Product> Products { get; set; }

        public override string ToString()
        {
            return $"{CategoryName}";
        }

        public void GetDescription()
        {

        }

    }

    
}
