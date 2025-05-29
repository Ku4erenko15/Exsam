using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Book
    {
      private Author author;
        private Title title;
        private Content content;

        public Book()
        {
        }

        public Book(Author author, Title title, Content content)
        {
            this.author = author;
            this.title = title;
            this.content = content;
        }

        public Title GetTitle()
        {
            return title;
        }

        public void Show()
        {
            title.Show();
            author.Show();
            content.Show(); 
        }

    }
}
