namespace Assignment_7
{
    internal class GradeBook
    {
        protected LinkedList<Student> students = new();

        public GradeBook(string filename)
        {
            try
            {
                StreamReader stringReader = new StreamReader(filename);
                string line = "";
                while (!stringReader.EndOfStream)
                {
                    line = stringReader.ReadLine();
                    Student toadd = new(line);
                    students.AddLast(toadd);
                }
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
        }

        public Student getStudent(string name)
        {
            foreach (Student student in students)
            {
                if (student.getName().Equals(name))
                {
                    return (student);
                }
            }
            return (null);
        }

        public void getStudentGrade(string name)
        {
            foreach (Student student in students)
            {
                if (student.getName().Equals(name))
                {
                    Console.WriteLine(student.getGrade());
                    return;
                }
            }
            Console.WriteLine("No Student Found");
        }

        public LinkedList<string> getAllStudentNames()
        {
            LinkedList<string> toreturn = new();
            foreach (Student student in students)
            {
                toreturn.AddLast(student.getName());
            }
            return toreturn;
        }
    }
}
