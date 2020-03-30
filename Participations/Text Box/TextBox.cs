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
        public int Padding { get; set; }

        public ConsoleColor BackGround { get; set; }

        public ConsoleColor ForeGround { get; set; }

        public string Text { get; set; }

        public TextBox()
        {

        }

        public void DisplayText()
        {
            Console.ForegroundColor = this.ForeGround;
            Console.BackgroundColor = this.BackGround;
            string textOutput = new string(' ', this.Padding) + this.Text + new string(' ', this.Padding);
            Console.WriteLine(textOutput);
        }

    }
}
