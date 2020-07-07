using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            bookLib list = new bookLib();

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("1 to Display");
                Console.WriteLine("2 to Add book");
                Console.WriteLine("3 to Delete book");
                Console.WriteLine("4 to Search a book");
                Console.WriteLine("5 to Exit");
                Console.WriteLine("Enter your choice");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch(choice)
                {
                    case 1:
                        list.Display();
                        break;
                    case 2:
                        Console.WriteLine("Enter the Author name");
                        string AuthorName = Console.ReadLine();
                        Console.WriteLine("Enter the Book name");
                        string BookName = Console.ReadLine();
                        Console.WriteLine("Enter the ISBN");
                        string ISBN = Console.ReadLine();
                        string FullText = (AuthorName + "," + BookName + "," + ISBN);
                        list.AddBook(FullText);
                        break;
                    case 3:
                        Console.WriteLine("Enter the name of the book to be deleted ");
                        string BookN = Console.ReadLine();
                        list.DelBook(BookN);
                        break;
                    case 4:
                        Console.WriteLine("Enter the ISBN to search");
                        string ISBNno = Console.ReadLine();
                        list.Search(ISBNno);
                        break;
                    case 5:
                        Console.WriteLine("Thank you");
                        break;
                    default:
                        Console.WriteLine("Please enter the right choice");
                        break;
                    
                }

            }
        }
    }
}
