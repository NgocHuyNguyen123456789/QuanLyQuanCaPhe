using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ProductDTO
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string purchasePrice { get; set; }
        public string sellingPrice { get; set; }

        public ProductDTO(string Id, string Name, string purchasePrice, string sellingPrice)
        {
            this.Id = Id;
            this.Name = Name;
            this.purchasePrice = purchasePrice;
            this.sellingPrice = sellingPrice;
        }

    }
}
