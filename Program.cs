using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Schema
{
    class Program
    {
        static void Main(string[] args)
        {
            Asset a = new Asset("Truck", 111);
            AssetTracking A = new AssetTracking("Sydney", "Melbourne", a);
            A.Tracker(A);
            A.Print();
            Console.ReadKey();
        }
    }
}
