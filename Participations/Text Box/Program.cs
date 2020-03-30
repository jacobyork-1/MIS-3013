//Jacob York
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Box
{
    class Program
    {
        static void Main(string[] args)
        {
            TextBox textbox1 = new TextBox
            {
                Padding = 5,
                BackColor = ConsoleColor.White,
                ForeColor = ConsoleColor.Blue,
                Text = "This is the first text box."
            };

            TextBox textbox2 = new TextBox
            {
                Padding = 10,
                BackColor = ConsoleColor.DarkGreen,
                ForeColor = ConsoleColor.Yellow,
                Text = "This is the second text box."
            };

            textbox1.DisplayText();
            textbox2.DisplayText();

            Console.ReadKey();
        }
    }
}
