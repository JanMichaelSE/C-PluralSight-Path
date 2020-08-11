using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
     public class Order: EntityBase, ILoggable
    {
        
        private int orderId;
        private int customerId;
        private int shippingAddressId;
        private List<OrderItem> orderItems;
        private DateTimeOffset? orderDate;


        public Order() : this(0)
        {

        }

        public Order(int orderId)
        {
            OrderId = orderId;
            OrderItems = new List<OrderItem>();
        }

        
        public int OrderId { get => orderId; private set => orderId = value; }
        public DateTimeOffset? OrderDate { get => orderDate; set => orderDate = value; }
        public int CustomerId { get => customerId; set => customerId = value; }
        public int ShippingAddressId { get => shippingAddressId; set => shippingAddressId = value; }
        internal List<OrderItem> OrderItems { get => orderItems; set => orderItems = value; }

        public override bool Validate()
        {
            var isValid = true;

            if (OrderDate == null)
            {
                isValid = false;
            }

            return isValid;

        }

        public Order Retrieve(int orderId)
        {
            // Code that retrieves the defined customer here

            return new Order();
        }

        public List<Order> Retrieve()
        {
            // Code that retrieves the all customers here

            return new List<Order>();
        }


        public bool Save()
        {
            // Code that saves the defined customer here

            return true;
        }

        public string Log()
        {
            return $"{OrderId}: Date: {OrderDate.Value.Date}, Status: {EntityState.ToString()}";
        }
    }
}
