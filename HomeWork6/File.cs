using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6
{
    public class File
    {
        public double size;

        public File()
        {
            Size = 780;
        }

        public File(double sz)
        {
            size = sz;
        }

        public double Size
        {
            get { return size; }
            set { size = value; }
        }
    }
}
