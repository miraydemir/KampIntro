using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi.");
        }

        public void Update (Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }

        
    }    // void emirdi. Git yap bitir. sonuç değeri kullanmaya devam edemiyorum.
         //  return kullanırken int gibi bir değişken ataman gerekiyor ve böylece işlem sonucunu başka bir isme atayabilme imkanı tanıyor.
    
}
