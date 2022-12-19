using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1._15thdec.Maxex
{
    class Colleage
    {
        string studentName;

        int studentRoll;
        
        public Colleage(string name, int marks)
        {
            this.studentName = name;
            this.studentRoll = marks;
        }
        public override string ToString()
        {
            return $"Name: {studentName},Mark: {studentRoll}";
        }
    }
}
