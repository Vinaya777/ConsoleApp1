using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*WAP to add elements to arraylist  0th location keep Integer, 
 *1st location String now print each element and display contents*/
namespace ConsoleApp1.DemoSr.VideoAssignment
{
    class Arr2
    { public class ArrayList

        {
            
            static void Main(string[] args)
            {
                ArrayList al = new ArrayList();


                int[] myarray = new int[3];
                myarray[0] = 10;
                myarray[1] = 30;
                myarray[2] = 40;
                myarray[3] = 50;
                myarray[5] = 10;
                Array.Resize(ref myarray, 6);
                myarray[6] = 80;
                Console.WriteLine(myarray[0]);
                Console.ReadLine();
            }
        }
    }
}
