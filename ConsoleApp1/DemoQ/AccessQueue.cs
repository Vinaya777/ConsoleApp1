using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DemoQ
{
    class AccessQueue
    {
        int itemid;int count;
        String itemname;

       public AccessQueue(int  id,String name)
        {
            count = id;
            count++;
            itemid = id;
            itemname = name;
        }

        public override string ToString()
        {
            return $"Id{itemid},Name{itemname}";
        }
      
        /*  static void Main(string[] args)
          {


          }*/
       
    }
}
