using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DemoSr.VideoAssignment
{
   public class JoinTwoArrayList
    {
        static void Main(string[] args)
        {
            /* List<JoinTwoArrayList> clist = new List<JoinTwoArrayList>();
             clist.Add();

             ArrayList countrylist1 = new ArrayList();

             List<JoinTwoArrayList> cclist = new List<JoinTwoArrayList>();

             ArrayList countrylist2 = new ArrayList();*/

            Console.WriteLine("-----------------------------------");



            List<string> CountryList = new List<string>();

            CountryList.Add("Bangladesh");

            CountryList.Add("India");

            CountryList.Add("Pakistan");

            CountryList.Add("Nepal");

            CountryList.Add("Maldives");

            CountryList.Add("Srilanka");

            CountryList.Add("Bhutan");

            CountryList.Add("Afganistan");
            Console.WriteLine(CountryList);

            Console.WriteLine("\n Count number of  List item  ");
            Console.WriteLine("\n There are: {0}, {0}", CountryList.Count, "\n  Country  inthis  CountryList");

           Console.ReadLine();





        }
    }
}
