using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Tracking;
using Unity;
namespace Demo_IOC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Implementing IOC using unity Container in a Console application");
            UnityContainer IU = new UnityContainer();



            IU.RegisterType<BL>();
            IU.RegisterType<DL>();



            object p = IU.RegisterType<IProduct, DL>();
            BL ObjDL = IU.Resolve<BL>();
            ObjDL.Write();
            Console.ReadLine();
        }
    }




}