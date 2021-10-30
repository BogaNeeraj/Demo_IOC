using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_IOC
{
    class BL
    {
        IProduct IProduct_Obj;
        public BL(IProduct _ObjProduct)
        {
            IProduct_Obj = _ObjProduct;
        }
        public void Write()
        {
            IProduct_Obj.InsertData();
        }
    }

    
}



