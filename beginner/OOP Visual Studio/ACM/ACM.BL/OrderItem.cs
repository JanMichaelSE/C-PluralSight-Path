using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class OrderItem
    {
        private int orderItemId;
        private int quantity;
        private int productId;
        private double? purchasePrice;

        public OrderItem()
        {

        }

        public OrderItem(int orderItemId)
        {
            OrderItemId = orderItemId;
        }
        public int OrderItemId { get => orderItemId; private set => orderItemId = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public double? PurchasePrice { get => purchasePrice; set => purchasePrice = value; }
        
        public int ProductId { get => productId; set => productId = value; }

        public bool Validate()
        {
            var isValid = true;

            if (PurchasePrice == null || Quantity <= 0 || ProductId <= 0)
            {
                isValid = false;
            }

            return isValid;

        }


        public OrderItem Retrieve(Product product)
        {
            // Code that retrieves the defined customer here

            return new OrderItem();
        }

        public List<OrderItem> Retrieve()
        {
            // Code that retrieves the all customers here

            return new List<OrderItem>();
        }


        public bool Save()
        {
            // Code that saves the defined customer here

            return true;
        }

    }
}
