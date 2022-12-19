using System;
using System.Collections.Generic;
using System.Text;

namespace cartask_20._12._22
{
    internal class Car
    {
        public string Brand;
        public string Model;
        public int FuelFor1Km;
        public int Millage;
        public int CurrentFuel;
        public void Drive()
        {
            Console.WriteLine("getmek istediyiniz km qeyd edin");
            int getmekistenilenyol = Convert.ToInt32(Console.ReadLine());
            //əgər benzin kifayət edirsə
          
            int lazimibenzin = getmekistenilenyol * FuelFor1Km; 
            if (lazimibenzin <= CurrentFuel)
            //maşının millage dəyəri və benzini azalır,
            {
                CurrentFuel-= FuelFor1Km*getmekistenilenyol;//**getmek istenilen yol gedilikden sonra ne qeder benzon qalirsa onu tapmis olura,
                Millage+= getmekistenilenyol;
                Console.WriteLine("benzin kifayet edir");
                Console.WriteLine(CurrentFuel);
                Console.WriteLine(Millage);
            }
            else
                Console.WriteLine("benzin kifayet etmir");
            

        }
    }
}

