using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    public class SepetManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi :" + product.Name);
        }

        public void Add2(string productName, string description,double fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi :" + productName);
        }




    }
}
