using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace lmsusingOOP
{
    public  class Library
    {
        public List<Book>  Books {  get; set; }
        public List<string> BorrowedBooks{ get; set; }

        public Library()
        {
            Books = new List<Book>();
            BorrowedBooks = new List<string>();
        }

        public Book GetBookByIsbn(string isbn)
        {
            return Books.FirstOrDefault(b => b.isbn == isbn);
        }

    }

}
