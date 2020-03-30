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
            //refers back to the TextBox constructor which was empty/default
            TextBox textbox1 = new TextBox();
            //refers back to the parameters created in the TextBox class
            textbox1.Padding = 5;
            textbox1.BackColor = ConsoleColor.White;
            textbox1.ForeColor = ConsoleColor.Blue;
            textbox1.Text = "This is the first text box.";

            //characteristics of text box 2
            TextBox textbox2 = new TextBox();
            textbox2.Padding = 10;
            textbox2.BackColor = ConsoleColor.DarkGreen;
            textbox2.ForeColor = ConsoleColor.Yellow;
            textbox2.Text = "This is the second text box.";

            textbox1.DisplayText();
            textbox2.DisplayText();

            Console.ReadKey();
        }
    }
}
