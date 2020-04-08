using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes2___Toys
{
    class Toy
    {
        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        private string Aisle;

        public Toy()
        {
            Manufacturer = "";
            Name = "";
            Price = 1;

        }
        public string GetAisle()
        {
            string input = Manufacturer;
            string ManufacturerChar = input.Substring(0, 1);
            Console.WriteLine($"{ManufacturerChar.ToUpper()}");

            Random random = new Random();
            int num = random.Next(1, 24);

        }

    }
}
