using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lmsusingOOP
{
    public  interface IAdmin
    {
        void AddBook(Library library);
        void DeleteBook(Library library);
        void ViewBookDetails(Library library);
        void EditBookDetails(Library library);
        void AddMember();
        void DeleteMember();
        void ViewMemberDetails();
        void EditMemberDetails();
    }
}
