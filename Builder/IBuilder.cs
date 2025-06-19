using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public interface IBuilder
    {
        public IBuilder SetTitle(string title);
        public IBuilder SetDescription(string description);
        public IBuilder SetAuthor(string author);
        public IBuilder SetPublisher(string publisher);
        public IBuilder SetPages(int pages);
        public Book GetBook();

    }
}
