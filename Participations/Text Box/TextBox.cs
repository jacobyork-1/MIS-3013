//Jacob York
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Box
{
    class TextBox
    {
        // + means public 
        // - means private

        //+ Padding : int 
        //the padding is listed as an integer b/c it is the space before and after the test property
        public int Padding { get; set; }

        //+ BackColor : ConsoleColor
        //the background color of the text box
        public ConsoleColor BackColor { get; set; }

        //+ ForeColor : ConsoleColor
        //the foreground color (color of the text) 
        public ConsoleColor ForeColor { get; set; }

        //+ Text : String
        //estabilishing the text to be outputted as a string
        public string Text { get; set; }

        //+ TextBox() with no return value
        //defult/empty constructor for the TextBox class b/c of empty parameters
        public TextBox()
        {

        }

        //+ DisplayText() : void
        //return type of void does not return any value
        public void DisplayText()
        {
            Console.ForegroundColor = ForeColor;
            Console.BackgroundColor = BackColor;
            //interpolates the padding before and after the text that is outputted 
            Console.WriteLine($"{new string(' ', Padding)}{Text}{new string(' ', Padding)}");
        }

    }
}
