using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        Student(string line) 
        {
        string[] split = line.Split(',');
            Name = split[0];
            Id = int.Parse(split[1]);
            q = new int[10];
            h = new int[10];
            for (int i = 2; i < 12; i++)
            {
                q[i-2] = int.Parse(split[i]);
                h[i - 2] = int.Parse(split[i + 10]);
            }
        }
    }
}
