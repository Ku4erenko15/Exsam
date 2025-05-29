using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Author author = new Author("Лев Толстой");
            Title title = new Title("Война и мир");
            Content content = new Content("Роман");
            Book one = new Book(author, title, content);
            one.Show();
            Console.ReadKey();
        }
    }
}
