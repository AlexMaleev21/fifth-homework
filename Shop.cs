using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz5
{
    internal class Shop : IDisposable
    {
        public string ShopName { get; set; }
        public string ShopAdress { get; set; }
        public string ShopType { get; set; }

        private bool disposed = false;

        public Shop(string shopName, string shopAdress, string shopType)
        {
            ShopName = shopName;
            ShopAdress = shopAdress;
            ShopType = shopType;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Shop Name: {ShopName}");
            Console.WriteLine($"Shop Adress: {ShopAdress}");
            Console.WriteLine($"Shop Type: {ShopType}");
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public virtual void Dispose(bool disposing)
        {
            if (disposed) return;
            if (disposing)
            {
                Console.WriteLine();
                Console.WriteLine($"{ShopName} has been disposed");
            }
            disposed = true;
        }
        ~Shop()
        {
            Console.WriteLine();
            Console.WriteLine("Destructor called");
            Dispose(false);
        }
    }
}
