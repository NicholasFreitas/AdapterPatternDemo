using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDemo
{
    class ConcreteTarget : ITarget
    {
        public void Request()
        {
            Console.WriteLine("Specific Implementation");
        }
    }
}
