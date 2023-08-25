using System;

namespace IndexerMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Create a class BookCollection with a private array of string to
            store book titles. Implement an indexer that allows accessing and
            updating book titles using index. Create a StudentCollection class 
            that stores a collection of students. Implement an indexer that
            allows accessing students by their roll number.*/

            BookCollection bookCollection = new BookCollection(3);
            bookCollection[0] = "First Book";
            bookCollection[1] = "Second Book";
            bookCollection[2] = "Third Book";

            Console.WriteLine(bookCollection[0]);
            Console.WriteLine(bookCollection[1]);
            Console.WriteLine(bookCollection[2]);


            StudentCollection studentCollection = new StudentCollection();
            studentCollection[0] = new Student(0, "Alice");
            studentCollection[1] = new Student(1, "Bob");
            studentCollection[2] = new Student(2, "Charlie");

            
            Console.WriteLine(studentCollection[0].StudentName);
            Console.WriteLine(studentCollection[1].StudentName);
            Console.WriteLine(studentCollection[2].StudentName);

            Console.ReadLine();
        }
    }
}
