using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jo_s_app
{
    internal class Customer : IFCustomer
    {
    public string Name { get; set; }
    public string Address { get; set; }
 
    public string GetName()
    {
        return Name;
    }
 
    public void SetName(string name)
    {
        Name = name;
    }
 
    public string GetAddress()
    {
        return Address;
    }
 
    public void SetAddress(string address)
    {
        Address = address;
    }
}
}
