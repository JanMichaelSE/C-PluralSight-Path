using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Product : EntityBase, ILoggable
    {
        private int productId;
        private string productName;
        private string description;
        private decimal? currentPrice;


        public Product()
        {

        }

        public Product(int productId)
        {
            ProductId = productId;
        }

        public int ProductId { get => productId; private set => productId = value; }
        public string ProductName { get => productName.InsertSpaces(); set => productName = value;}
        public string Description { get => description; set => description = value; }
        public decimal? CurrentPrice { get => currentPrice; set => currentPrice = value; }

        public string Log()
        {
            return $"{ProductId}: {ProductName}, Detail: {Description}, Status: {EntityState.ToString()}";
        }

        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName) || CurrentPrice == null)
            {
                isValid = false;
            }

            return isValid;

        }    
    }
}
