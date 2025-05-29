using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Author
    {
        private string author;
        public Author(string author)
        {
            this.author = author;
        }
        public Author() { }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{author}");
        }


    }
}
