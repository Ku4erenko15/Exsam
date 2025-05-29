using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Content
    {
        public string content;

        public Content(string content)
        {
            this.content = content;
        }
        public Content() { }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"{content}");
        }

    }
}
