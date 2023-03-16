using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jo_s_app
{
    internal interface IFDelivary
    {
        void SetOrder(Order order);
        Order GetOrder();
        void Deliver();


    }
}
