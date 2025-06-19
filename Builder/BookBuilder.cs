using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class BookBuilder : IBuilder
    {
        private Book _book;

        public BookBuilder()
        {
            _book = new Book();
        }
        public IBuilder SetAuthor(string author)
        {
            _book.Author = author;
            return this;
        }

        public IBuilder SetDescription(string description)
        {
            _book.Description = description;
            return this;

        }

        public IBuilder SetPages(int pages)
        {
            _book.Pages = pages;
            return this;

        }

        public IBuilder SetPublisher(string publisher)
        {
            _book.Publisher = publisher;
            return this;

        }

        public IBuilder SetTitle(string title)
        {
            _book.Title = title;
            return this;

        }
        public Book GetBook()
        {
            return _book;
        }

    }
}
