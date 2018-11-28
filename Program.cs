using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDemo
{
    class Program
    {
        /*
         Adapter Pattern : the main purpose of the adapter pattern is to adapt one interface to another.

            ---------       ------------
            |Client | ----> |Target    |
            ---------       ------------
                            |Request() |
                            ------------
                                 |
                                 ^
                                 ^
                                 |
                             -----------        --------------------
                             |Adapter  | --->>--|Adaptee           |
                             -----------        --------------------
       SpecificRequest()---o |Request()|        |SpecificRequest() |
                             -----------        --------------------
        */
        
        static void Main(string[] args)
        {

            var target = new ConcreteTarget();
            var adaptee = new ConcreteAdaptee();
            var adapter = new ConcreteAdapter(adaptee);

            adapter.Request();
                                                                        
        }
    }
}
