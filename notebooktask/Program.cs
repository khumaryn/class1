using System;

namespace notebooktask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // task1 Notebook class

            Notebook notebook1 = new Notebook
            {
                Name = "Computer",
                BrandName = "HP",
                Price = 3499,

            };
            Notebook notebook2 = new Notebook
            {
                Name = "Computer",
                BrandName = "Lenova",
                Price = 2949,

            };
            Notebook notebook3 = new Notebook
            {
                Name = "Computer",
                BrandName = "Asus",
                Price = 3780,

            };
            Notebook[] notebooks = { notebook1, notebook2, notebook3 };
            var minmax = MinMax(notebooks);
        }
        static int MinMax(Notebook[] arr)
        { 
         int min = Convert.ToInt32(Console.ReadLine());
         int max = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i<arr.Length; i++)
            {
                if (arr[i].Price > min && arr[i].Price<max)
                
                    Console.WriteLine(arr[i].BrandName);
                else
                {
                    Console.WriteLine("min max deyerleri duzgun daxil edilmeyib");

                }
                
                
            }
            
            

            
           

            
            
        }
       
    }
}
