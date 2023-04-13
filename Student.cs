namespace Assignment_7
{
    public class Student
    {
        private int Id;
        private string Name;
        private double tAvg;
        private double hAvg;
        private double qAvg;
        private int final;
        private int mid;
        private int[] q;
        private int[] h;

        public string getName()
        {
            return Name;
        }
        public int getId()
        {
            return Id;
        }


        public Student(string line)
        {
            string[] split = line.Split(',');
            Name = split[0];
            Id = int.Parse(split[1]);
            q = new int[10];
            h = new int[10];
            for (int i = 2; i < 12; i++)
            {
                q[i - 2] = int.Parse(split[i]);
                h[i - 2] = int.Parse(split[i + 10]);
            }
            mid = int.Parse(split[22]);
            final = int.Parse(split[23]);
        }

        public void calcQuizAvg()
        {
            qAvg = (q.Sum() - q.Min()) / 9F;
        }
        public void calcHWAvg()
        {
            hAvg = (h.Sum() - h.Min()) / 9F;
        }
        public void calcOverallAvg()
        {
            tAvg = (qAvg * .4) + (hAvg * .1) + (mid * .2) + (final * .3);
        }
        public string getGrade()
        {
            return ("Quiz 1: " + q[0] + "\nQuiz 2: " + q[1] + "\nQuiz 3: " + q[2] + "\nQuiz 4: " + q[3] + "\nQuiz 5: " + q[4] + "\nQuiz 6: " + q[5] + "\nQuiz 7: " + q[6] + "\nQuiz 8: " + q[7] + "\nQuiz 9: " + q[8] + "\nQuiz 10: " + q[9] + "\nQuiz Average: " + qAvg + "\nHW 1: " + h[0] + "\nHW 2: " + h[1] + "\nHW 3: " + h[2] + "\nHW 4: " + h[3] + "\nHW 5: " + h[4] + "\nHW 6: " + h[5] + "\nHW 7: " + h[6] + "\nHW 8: " + h[7] + "\nHW 9: " + h[8] + "\nHW 10: " + h[9] + "\nHW Average: " + hAvg + "\nMidterm: " + mid + "\nFinal Exam: " + final + "\nOverall Average: " + tAvg);
        }
    }
}
