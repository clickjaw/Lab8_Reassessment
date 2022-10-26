using System.Collections;

namespace LendingLibrary.Interfaces
{
    class Program
    {

        private static readonly Library library = new Library();
        private static readonly Backpack<Book> bookBag = new Backpack<Book>();

        static void Main(string[] args)
        {
            LoadBooks();
            UserInterface();

        }

        static void UserInterface()
        {
            Console.Clear();
            while (true)
            {
                Console.WriteLine("Welcome to LendingLibrary");
                Console.WriteLine("Pick an option: ");
                Console.WriteLine("1: View All Books");
                Console.WriteLine("2: Add New Book");
                Console.WriteLine("3: Borrow a Book");
                Console.WriteLine("4: Return a Book");
                Console.WriteLine("5: View Book Bag");
                Console.WriteLine("6: Exit");

                string answer = Console.ReadLine();

                //switch case

                switch (answer)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Library");
                        Console.WriteLine("=======");
                        OutputBooks(library);
                        break;

                    case "2":
                        Console.Clear();
                        AddBook();
                        Console.Clear();
                        break;

                    case "3":
                        Console.Clear();
                        BorrowBook();
                        Console.Clear();
                        break;

                    case "4":
                        Console.Clear();
                        ReturnBook();
                        Console.Clear();
                        break;

                    case "5":
                        Console.Clear();
                        Console.WriteLine("=======");
                        OutputBooks(bookBag);
                        break;

                    case "6":
                        return;

                    default:
                        Console.WriteLine("Invalid option...");
                        break;


                } //switch

            } //while loop

        } //userinterface

        //create a predefined library
        static void LoadBooks()
        {
            library.Add("Alice in Wonderland", "Lewis", "Carrol", 146);
            library.Add("1984", "George", "Orwell", 220);
            library.Add("Game of Thrones", "George", "Martin", 600);
            library.Add("Dune", "Frank", "Herbert", 540);
        }

        static void OutputBooks(IEnumerable<Book> books)
        {
            int counter = 1;
            foreach (Book book in books)
            {
                Console.WriteLine($"{counter++}: {book.Title}, {book.Author.FirstName} { book.Author.LastName}");
                // Console.WriteLine($"{book.Author.FirstName} { book.Author.LastName}");
            }
            Console.WriteLine();
        }

        private static void AddBook()
        {

            Console.WriteLine("Please enter the following information: ");
            Console.WriteLine("Please enter the title of the book: ");
            string title = Console.ReadLine();

            Console.WriteLine("Please enter author's first name: ");
            string first = Console.ReadLine();

            Console.WriteLine("Please enter author's last name: ");
            string last = Console.ReadLine();
            
            Console.WriteLine("Please enter number of pages: ");
            int NumberOfPages = Convert.ToInt32(Console.ReadLine());

            library.Add(title, first, last, NumberOfPages);
        }

        private static void BorrowBook()
        {
            foreach (Book book in library)
            {
                Console.WriteLine($"{book.Title}");
            }
            //ask which book to borrow
            Console.WriteLine("");
            Console.WriteLine("What book do you want to borrow?");
            string selection = Console.ReadLine();

            Book borrowed = library.Borrow(selection);
            //put the book in the bag
            bookBag.Pack(borrowed);
        }

        static void ReturnBook()
        {
            OutputBooks(bookBag);
            Console.WriteLine("Which book would you like to return?");
            int selection = Convert.ToInt32(Console.ReadLine());
            Book bookToReturn = bookBag.Unpack(selection - 1);
            Console.WriteLine("============");
            Console.WriteLine("Book returned to Library.");

            library.Return(bookToReturn);
            // Console.WriteLine(bookToReturn);

        }


    } //class Program
}