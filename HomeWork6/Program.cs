using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6
{
    class Program
    {
        static void Main(string[] args)
        {
            Storage hdd1 = new HDD(1000, 480);
            Storage dvd1 = new DVD(9, 21);
            Storage flash1 = new Flash(16, 119);
            Storage[] storage = new Storage[] { hdd1, dvd1, flash1 };
            for (int i = 0; i < 3; i++)
            {
                storage[i].CopyData("Video", 980);
                storage[i].Info(1);
                Console.ReadLine();
            }



            HDD hdd = new HDD(1000, 480);
            hdd.CopyData("Video", 980);
            hdd.Info(980);

            DVD dvd = new DVD(9, 21);
            dvd.CopyData("file", 4);
            dvd.Info(4);

            Flash flash = new Flash(16, 119);
            flash.CopyData("text", 1);
            flash.Info(1);
            Console.ReadLine();
        }
    }
}
