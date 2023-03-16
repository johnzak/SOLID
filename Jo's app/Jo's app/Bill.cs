using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jo_s_app
{
    internal class Bill : IFBill
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

        public decimal CalculateBill()
        {
            decimal billAmount = 0;
            return billAmount;
        }
    }
}