using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product  //Entity (ürün, varlık gibi)
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }  //hangi kategoriye dahil bir ürün
        public string ProductName { get; set; }  // ürün ismi   
        public double UnitPrice { get; set; } // fiyatı
        public int UnitInStock { get; set; }  //Stok adedi

    } // bu tip classlarda sadece ve sadece özellik olur.
            //CRUD
}
