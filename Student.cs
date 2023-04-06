namespace Assignment_7
{
    public class Student
    {
        private int Id { get; }
        private string Name { get; }
        private double tAvg;
        private double hAvg;
        private double qAvg;
        private int final;
        private int mid;
        private int[] q;
        private int[] h;

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
            mid = int.Parse(split[23]);
            final = int.Parse(split[24]);
        }

        public void calcQuizAvg()
        {
            qAvg = (q.Sum() - q.Min())/9F;
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
            return ();
        }
    }
}
