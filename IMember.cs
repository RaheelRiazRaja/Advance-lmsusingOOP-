using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lmsusingOOP
{
    public interface IMember
    {
        void BorrowBook(Library library);
        void ReturnBook(Library library);
    }
}
