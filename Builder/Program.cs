// See https://aka.ms/new-console-template for more information
using Builder;

IBuilder bookBuilder = new BookBuilder();
var book = bookBuilder
    .SetTitle("The Great Gatsby")
    .SetAuthor("F. Scott Fitzgerald")
    .SetPublisher("Scribner")
    .SetPublisher("fd")
    .GetBook();