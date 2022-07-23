using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using L01_03.Book.Parts;

namespace L01_03.Book
{
    internal class Book
    {
        Title title = null;
        Author author = null;
        Content content = null;
        void InitialBook()
        {
            this.title = new Title();
            this.author=new Author();
            this.content = new Content();
        }
        public Book(string title, string author, string content)
        {
            InitialBook();
            this.title.title = title;
            this.author.author = author;
            this.content.content = content;
        }
        public Book()
        {
            InitialBook();
        }
        public string Title
        {
            set
            {
                this.title.title = value;
            }
        }
        public string Author
        {
            set
            {
                this.author.author = value;
            }
        }
        public string Content
        {
            set
            {
                this.content.content = value;
            }
        }
        public void Show()
        {
            this.title.Show();
            this.author.Show();
            this.content.Show();
        }

    }
}
