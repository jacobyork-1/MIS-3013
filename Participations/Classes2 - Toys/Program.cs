//Jacob York
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes2___Toys
{
    class Program
    {
        static void Main(string[] args)
        {
            Toy toy1 = new Toy();
            toy1.Manufacturer = "";
            toy1.Name = "";
            toy1.Price = 0;

            toy1.Toys = new List<Toy>();
            toy1.Toys.Add("Ball");
            toy1.Toys.Add("Swing");
            toy1.Toys.Add("lighter");

            Console.WriteLine($"{toy1.GetAisle()}, {toy1}");

            

            Console.ReadKey();
        }
    }
}
