using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lmsusingOOP
{
    public class Book : Person 
    {
        public String name {  get; set; }
       
        public String isbn { get; set; }
        public string auther { get; set; }

        public Book(string name, string isbn, string auther)
        {
            this.name = name;
            this.isbn = isbn;
            this.auther = auther;
        }


    }
}
