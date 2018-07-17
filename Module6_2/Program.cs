using Module6_2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module6_2  //CodeFirst Automatic
{
    class Program
    {
        static void Main(string[] args)
        {
            using (mcs db = new mcs())
            {
                foreach (var stopReason in db.AccessTab)
                {
                    Console.WriteLine(stopReason.TabId + "\t" + stopReason.GroupId + "\t" + stopReason.TabName);
                }
            }
        }
    }
}
