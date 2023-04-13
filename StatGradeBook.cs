using System.Diagnostics;

namespace Assignment_7
{
    internal class StatGradeBook : GradeBook
    {
        public StatGradeBook(string filename) : base(filename)
        {
        }

        public void run()
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            LinkedList<string> names = getAllStudentNames();
            int numstudents = names.Count();
            int numprocessed = 0;
            foreach (Student student in students)
            {
                student.calcQuizAvg();
                student.calcHWAvg();
                student.calcOverallAvg();
                numprocessed++;
                if (numprocessed % 100 == 0 || numprocessed == numstudents) { Console.WriteLine("Calculating Grades: " + numprocessed + " out of " + numstudents); }
            }
            watch.Stop();
            Console.WriteLine("Complete in: " + watch.Elapsed.TotalSeconds.ToString() + " sec");
        }
    }
}
