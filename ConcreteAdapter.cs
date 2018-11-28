using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDemo
{
    class ConcreteAdapter : IAdapter
    {
        IAdaptee Adaptee;

        public ConcreteAdapter(IAdaptee adaptee)
        {
            Adaptee = adaptee;
        }
        public void Request()
        {
            Adaptee.SpecificRequest();
        }
    }
}
