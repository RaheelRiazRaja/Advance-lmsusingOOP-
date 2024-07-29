namespace lmsusingOOP
{
    public class Member :  IMember
    {
        public void BorrowBook(Library library)
        {
            Console.WriteLine("******************BORROW BOOK******************");
            Console.Write("Enter Book ISBN No. to Borrow: ");
            var bookIsbnNo = Console.ReadLine();
            var book = library.GetBookByIsbn(bookIsbnNo);
            if (book != null && !library.BorrowedBooks.Contains(bookIsbnNo))
            {
                library.BorrowedBooks.Add(bookIsbnNo);
                Console.WriteLine("Book Borrowed Successfully.");
            }
            else
            {
                Console.WriteLine("Book is not available or already borrowed.");
            }
        }

        public void ReturnBook(Library library)
        {
            Console.WriteLine("******************RETURN BOOK******************");
            Console.Write("Enter Book ISBN No. to Return: ");
            var bookIsbnNo = Console.ReadLine();
            if (library.BorrowedBooks.Contains(bookIsbnNo))
            {
                library.BorrowedBooks.Remove(bookIsbnNo);
                Console.WriteLine("Book Returned Successfully.");
            }
            else
            {
                Console.WriteLine("Book was not borrowed.");
            }
        }


    }
}
