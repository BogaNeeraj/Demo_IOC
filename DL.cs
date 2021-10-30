using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





namespace Demo_IOC
{
    class DL : IProduct
    {
        public string InsertData()
        {
            string val = "Dependency Variable Injected";
            Console.WriteLine(val);
            return val;
            throw new NotImplementedException();
        }
    }
}
