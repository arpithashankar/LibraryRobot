using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BookAssignment
{
    class bookLib
    {
        // to display book details
        public void Display()
        {
            Console.WriteLine("The Library book details");
            string[] lines = File.ReadAllLines(@"E:\learning\book.txt");

            foreach (string line in lines)
                Console.WriteLine(line);
        }
        
        // to add book details

        public void AddBook(string Data)
        {
            StreamWriter sw = File.AppendText(@"E:\learning\book.txt");
            sw.WriteLine(Data);
            sw.Close();

        }

        //to delete book
        public void DelBook(string BookName)
        {
            string strOldText;
            string n = "";
            StreamReader sr = File.OpenText(@"E:\learning\book.txt");
            while ((strOldText = sr.ReadLine()) != null)
            {
                if (!strOldText.Contains(BookName))
                {
                    n += strOldText + Environment.NewLine;
                }
            }
            sr.Close();
            File.WriteAllText(@"E:\learning\book.txt", n);
        }

       //to search a book 
        public void Search(string ISBNnumber)
        {
            StreamReader reader = new StreamReader(@"E:\learning\book.txt");
            string record = reader.ReadLine();
            while (record != null)
            {
                if (record.Contains(ISBNnumber))
                {

                    Console.WriteLine("The details of the book as follows \n" + record);
                }
                
                record = reader.ReadLine();
            }
            reader.Close();
            
        }
    }
}
