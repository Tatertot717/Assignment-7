namespace Assignment_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StatGradeBook book = new("Gradebook.csv");
            Thread t = new Thread(new ThreadStart(book.run));
            t.Start();
            Console.WriteLine("What student would you like to see grades for?");
            string student = Console.ReadLine();
            book.getStudentGrade(student);
        }
    }
}