using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jo_s_app
{
    internal class BreakfastOrder : Order


    {
        public BreakfastOrder(string orderId, string itemName, int quant, int totalBillAmt) 
        {
        }

        public void prepareOrder()
        {
            Console.WriteLine("Prepareing Breakfast");

        }
    }

}
