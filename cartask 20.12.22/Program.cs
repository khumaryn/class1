using System;

namespace cartask_20._12._22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //car task
            Car car = new Car
            {
                Brand = "Bentley",
                Model = "Bentayga",
                FuelFor1Km = 2,// masinin 1 km ucun xerclediyi benzin
                Millage =20,// Masinin bu vaxtadək neçə km sürüldüyü
                CurrentFuel = 80 //masinin hazirki benzin miqdari
            };

            car.Drive();


            




        }

    }
}

