using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module6_3.Modul;

namespace Module6_3 // Data Base First
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new MCSEntities())
            {
                foreach (var r in db.AccessTabs)
                {
                    Console.WriteLine(r.strTabName + "\t\t\t\t\t" + r.strTabGroupName);
                }
            }
        }
    }
}
