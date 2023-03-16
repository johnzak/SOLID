using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jo_s_app
{
    internal class LunchOrder : Order

    {
        public LunchOrder(string orderId, string itemName, int quant, int totalBillAmt)
        {
        }

        public void prepareOrder()
        {
            Console.WriteLine("Prepareing Lunch");
        }
    }
}
