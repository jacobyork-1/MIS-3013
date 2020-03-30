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
            TextBox textbox1 = new TextBox();
            textbox1.BackGround = ConsoleColor.DarkCyan;
            textbox1.ForeGround = ConsoleColor.Blue;
            textbox1.Padding = 3;
            textbox1.Text = "This is a the first text box.";

            textbox1.DisplayText();

            Console.ReadKey();
        }
    }
}
