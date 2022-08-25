using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using L04_14.Document.Parts;

namespace L04_14.Document
{
    internal class Document
    {
        private Title title;
        private Body body;
        private Footer footer;
        public Document(Title title, Body body, Footer footer)
        {
            this.title = title;
            this.body = body;
            this.footer = footer;
        }
        public void Show()
        {
            title.Show();
            body.Show();
            footer.Show();
        }
    }
}
