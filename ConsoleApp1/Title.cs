using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     class Title
    {
        public string title;

        public Title(string title)
        {
            this.title = title;
        }
        public Title() { }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{title}");
        }
    }
}
