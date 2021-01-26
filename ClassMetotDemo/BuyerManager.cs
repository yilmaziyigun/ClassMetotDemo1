using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class BuyerManager
    {
        
        public void Add(Buyer buyer)
        {
            Console.WriteLine("Musteri Eklendi: "+buyer.BuyerName+" "+buyer.BuyerSurname+" "+buyer.BuyerPNumber);
            Console.WriteLine("");
        }
        public void Update(Buyer buyer)
        {
            Console.WriteLine("Musteri Guncelledi: " + buyer.BuyerName +" "+ buyer.BuyerSurname +" "+ buyer.BuyerPNumber);
            Console.WriteLine("");
        }
        public void Delete(Buyer buyer)
        {
            Console.WriteLine("Musteri Silindi: " +buyer.BuyerName +" " +buyer.BuyerSurname + " "+ buyer.BuyerPNumber);
            Console.WriteLine("");
        }
        public void List(Buyer buyer)
        {
         
                Console.WriteLine("Musteri Listelendi: " + buyer.BuyerName +" " + buyer.BuyerSurname +" " + buyer.BuyerPNumber);
                Console.WriteLine("");
            
        }
    }
}
