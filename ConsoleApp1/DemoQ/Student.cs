using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DemoQ
{
    class Student
    {
		int id, marks;
		String name;

		public Student() { }

		public Student(int id, int marks, String name)
		{
			
			this.id = id;
			this.marks = marks;
			this.name = name;
		}

        public override string ToString()
        {
            return $"";
        }

        public int CompareTo(Student o)
		{
			if (this.name.CompareTo(o.name) == 0)
				return 0;
			else if (this.name.CompareTo(o.name) < 0)
				return 1;
			else
				return -1;
		}

	}
}
