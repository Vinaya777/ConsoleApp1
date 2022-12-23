using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1._15thdec.Company
{

    public enum DepartmentCourse { IT,Computer,EAndTC};
    class AccessCompany
    {
        static void Main(string[] args)
        {
            List<Employe> employes = new List<Employe>()
            {
                new Employe()
                {
                    nameemp="manisha",departments=new List<Department>()
                    {
                        new Department(){ courseType=DepartmentCourse.IT,deptCourse="HR",deptId=205},
                        new Department(){ courseType=DepartmentCourse.Computer,deptCourse="DEVELOPER",deptId=206},
                        new Department(){ courseType=DepartmentCourse.EAndTC,deptCourse="Testing",deptId=205},
                        new Department(){ courseType=DepartmentCourse.IT,deptCourse="Designing",deptId=232}
                    },

                },
                new Employe()
                {
                    nameemp="RAJ",departments=new List<Department>()
                    {
                        new Department(){ courseType=DepartmentCourse.IT,deptCourse="HR",deptId=215},
                        new Department(){ courseType=DepartmentCourse.Computer,deptCourse="DEVELOPER",deptId=276},
                        new Department(){ courseType=DepartmentCourse.EAndTC,deptCourse="Testing",deptId=296},
                        new Department(){ courseType=DepartmentCourse.IT,deptCourse="Designing",deptId=232}
                    },

                },
                new Employe()
                {
                    nameemp="Tanmay",departments=new List<Department>()
                    {
                        new Department(){ courseType=DepartmentCourse.IT,deptCourse="HR",deptId=205},
                        new Department(){ courseType=DepartmentCourse.Computer,deptCourse="DEVELOPER",deptId=206},
                        new Department(){ courseType=DepartmentCourse.EAndTC,deptCourse="Testing",deptId=205},
                        new Department(){ courseType=DepartmentCourse.IT,deptCourse="Designing",deptId=232}
                    },

                }
            };

            foreach  (var Employe in employes  )
            {
                Console.WriteLine(Employe.nameemp);
                foreach (var Department in Employe.departments)
                {
                    Console.WriteLine($"Course :{Department.courseType}, Role:{Department.deptCourse},Department Id:{Department.deptId}, Department Coursess{Department.deptCourse}");
                }
                Console.ReadLine();
            }
        }
    }
}
