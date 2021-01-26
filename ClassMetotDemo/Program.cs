using System;

namespace ClassMetotDemo
{
    class Program
    {
        private void Musteri(Buyer buyer)
        {

            buyer.BuyerName = "Yilmaz";
            buyer.BuyerSurname = "IYIGUN";
            buyer.BuyerPNumber = 06;

           
        }
        static void Main(string[] args)
        {
            Buyer musteri1 = new Buyer();
            musteri1.BuyerName="Yilmaz";
            musteri1.BuyerSurname = "IYIGUN";
            musteri1.BuyerPNumber = 06;

            BuyerManager control = new BuyerManager();
            control.Add(musteri1);
            control.Update(musteri1);
            control.Delete(musteri1);
            control.List(musteri1);
            
            
        }
    }
}
