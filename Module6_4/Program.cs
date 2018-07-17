using Module6_2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Module6_4 // Model First
{
    class Program
    {
        static void Main(string[] args)
        {
            // Expl01();
            Exmpl02();
        }



        private static void addExample02(AccessTab tab)
        {

            Console.WriteLine(tab.TabName);

            foreach (var user in tab.AccessUsers)
            {
                Console.WriteLine("\t-->" + user.UserId);
            }
        }

        //Прямая загрузка eager loading
        public static void Expl01()
        {
            mcs db = new mcs();
            db.Database.Log = (s => System.Diagnostics.Debug.WriteLine(s));

            List<AccessTab> tabs = db.AccessTab.Include(c => c.AccessUsers).ToList();

        }

        //Явная загрузка explicit loading
        public static void Exmpl02()
        {
            mcs db = new mcs();
            //Загрузка одной вкладки
            AccessTab tab = db.AccessTab.Where(w => w.TabId == 1).FirstOrDefault();

            //Загрузка связанных данных с этой вкладкой 
            //db.Entry(tab).Collection(c => c.AccessUsers).Load();
            addExample02(tab);
            //Console.WriteLine(tab.TabName);

            //foreach (var user in tab.AccessUsers)
            //{
            //    Console.WriteLine("\t-->" + user.UserId);
            //}
        }


        //

    }

}
