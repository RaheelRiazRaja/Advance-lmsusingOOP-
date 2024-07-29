using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lmsusingOOP
{
    public class Admin : IAdmin
    {
        public void AddBook(Library library)
        {
            Console.WriteLine("******************ADD BOOK******************");
            Console.Write("Enter Book Name: ");
            var bookName = Console.ReadLine();
            Console.Write("Enter Book ISBN No.: ");
            var bookIsbnNo = Console.ReadLine();
            Console.Write("Enter Author Name: ");
            var bookAuthorName = Console.ReadLine();
            var book = new Book(bookName, bookIsbnNo, bookAuthorName);
            library.Books.Add(book);
            Console.WriteLine("Book Added Successfully.");
        }

        public void DeleteBook(Library library)
        {
            Console.WriteLine("******************DELETE BOOK******************");
            Console.Write("Enter Book ISBN No.: ");
            var bookIsbnNo = Console.ReadLine();
            var book = library.GetBookByIsbn(bookIsbnNo);
            if (book != null)
            {
                library.Books.Remove(book);
                Console.WriteLine("Book Deleted Successfully.");
            }
            else
            {
                Console.WriteLine("Book Not Found.");
            }
        }

        public void ViewBookDetails(Library library)
        {
            Console.WriteLine("******************BOOK DETAILS******************");
            Console.Write("Enter Book ISBN No.: ");
            var bookIsbnNo = Console.ReadLine();
            var book = library.GetBookByIsbn(bookIsbnNo);
            if (book != null)
            {
                Console.WriteLine($"Book Name: {book.name}\nBook ISBN No.: {book.isbn}\nBook Author: {book.auther}");
            }
            else
            {
                Console.WriteLine("Book Not Found.");
            }
        }

        public void EditBookDetails(Library library)
        {
            Console.WriteLine("******************EDIT BOOK DETAILS******************");
            Console.Write("Enter Book ISBN No.: ");
            var bookIsbnNo = Console.ReadLine();
            var book = library.GetBookByIsbn(bookIsbnNo);
            if (book != null)
            {
                Console.Write("Enter New Book Name: ");
                book.name = Console.ReadLine();
                Console.Write("Enter New Book Author: ");
                book.auther = Console.ReadLine();
                Console.WriteLine("Book Details Updated Successfully.");
            }
            else
            {
                Console.WriteLine("Book Not Found.");
            }
        }

        public void AddMember()
        {
            Console.WriteLine("******************ADD MEMBER******************");
            Console.Write("Please Enter Member Name: ");
            var memberName = Console.ReadLine();
            Console.Write("Please Enter Member ID: ");
            var memberId = Console.ReadLine();
            Console.Write("Please Enter Member Address: ");
            var memberAddress = Console.ReadLine();
            var fileName = $@"D:\Projects\lms\member\{memberId}.txt";
            if (!File.Exists(fileName))
            {
                File.WriteAllText(fileName, "Member Name      : " + memberName);
                File.AppendAllText(fileName, "\nMember ID       : " + memberId);
                File.AppendAllText(fileName, "\nMember Address  : " + memberAddress);
                Console.WriteLine("Member Added Successfully.");
            }
            else
            {
                Console.WriteLine("Member with Same ID Already Exists.");
            }
        }

        public void DeleteMember()
        {
            Console.WriteLine("******************DELETE MEMBER******************");
            Console.Write("Please Enter Member ID: ");
            var memberId = Console.ReadLine();
            var fileName = $@"D:\Projects\lms\member\{memberId}.txt";
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
                Console.WriteLine("Member Deleted Successfully.");
            }
            else
            {
                Console.WriteLine("Member Not Found.");
            }
        }

        public void ViewMemberDetails()
        {
            Console.WriteLine("******************MEMBER DETAILS******************");
            Console.Write("Please Enter Member ID: ");
            var memberId = Console.ReadLine();
            var fileName = $@"D:\Projects\lms\member\{memberId}.txt";
            if (File.Exists(fileName))
            {
                var fileData = File.ReadAllText(fileName);
                Console.WriteLine(fileData);
            }
            else
            {
                Console.WriteLine("Member Not Found.");
            }
        }

        public void EditMemberDetails()
        {
            Console.WriteLine("******************EDIT MEMBER DETAILS******************");
            Console.Write("Please Enter Member ID: ");
            var memberId = Console.ReadLine();
            var fileName = $@"D:\Projects\lms\member\{memberId}.txt";
            if (File.Exists(fileName))
            {
                Console.Write("Please Enter Member Name: ");
                var memberName = Console.ReadLine();
                Console.Write("Please Enter Member Address: ");
                var memberAddress = Console.ReadLine();
                File.WriteAllText(fileName, "Member Name      : " + memberName);
                File.AppendAllText(fileName, "\nMember ID       : " + memberId);
                File.AppendAllText(fileName, "\nMember Address  : " + memberAddress);
                Console.WriteLine("Member Details Updated Successfully.");
            }
            else
            {
                Console.WriteLine("Member Not Found.");
            }
        }
    }
}
