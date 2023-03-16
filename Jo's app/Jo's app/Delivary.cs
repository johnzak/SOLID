using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jo_s_app
{
    internal class Delivary : IFDelivary
    {
        public Order Order { get; set; }

        public void SetOrder(Order order)
        {
            Order = order;
        }

        public Order GetOrder()
        {
            return Order;
        }

        public void Deliver()
        {
            this.Order = Order;
        }
    }
}
