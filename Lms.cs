using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lmsusingOOP
{
    public class Libraryms
    {
        public void Run()
        {
            var library = new Library();
            var admin = new Admin();
            var member = new Member();
            bool flag;

            do
            {
                Console.WriteLine("******************LIBRARY MANAGEMENT SYSTEM******************");
                Console.WriteLine("PRESS 1 FOR MEMBER PORTAL\nPRESS 2 FOR ADMIN PORTAL");
                var mainMenuInput = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (mainMenuInput)
                {
                    case 1:
                        Console.WriteLine("******************LIBRARY MANAGEMENT SYSTEM******************");
                        Console.WriteLine("**************************MEMBER PORTAL**********************");
                        Console.WriteLine("PRESS 1 FOR BORROW BOOK\nPRESS 2 FOR RETURN BOOK");
                        var memberMenuInput = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();

                        switch (memberMenuInput)
                        {
                            case 1:
                                member.BorrowBook(library);
                                break;
                            case 2:
                                member.ReturnBook(library);
                                break;
                            default:
                                Console.WriteLine("Invalid option.");
                                break;
                        }
                        break;

                    case 2:
                        Console.WriteLine("******************LIBRARY MANAGEMENT SYSTEM******************");
                        Console.WriteLine("**************************ADMIN PORTAL***********************");
                        Console.WriteLine("PRESS 1 FOR ADD BOOK\nPRESS 2 FOR DELETE BOOK\nPRESS 3 FOR VIEW BOOK DETAILS\nPRESS 4 FOR EDIT BOOK DETAILS\nPRESS 5 FOR ADD MEMBER\nPRESS 6 FOR DELETE MEMBER\nPRESS 7 FOR VIEW MEMBER DETAILS\nPRESS 8 FOR EDIT MEMBER DETAILS");
                        var adminMenuInput = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();

                        switch (adminMenuInput)
                        {
                            case 1:
                                admin.AddBook(library);
                                break;
                            case 2:
                                admin.DeleteBook(library);
                                break;
                            case 3:
                                admin.ViewBookDetails(library);
                                break;
                            case 4:
                                admin.EditBookDetails(library);
                                break;
                            case 5:
                                admin.AddMember();
                                break;
                            case 6:
                                admin.DeleteMember();
                                break;
                            case 7:
                                admin.ViewMemberDetails();
                                break;
                            case 8:
                                admin.EditMemberDetails();
                                break;
                            default:
                                Console.WriteLine("Invalid option.");
                                break;
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }

                Console.WriteLine("Do you want to continue? (y/n): ");
                flag = Console.ReadLine().ToLower() == "y";

            } while (flag);
        }
    }
}
