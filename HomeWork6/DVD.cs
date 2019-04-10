using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6
{
    public class DVD: Storage
    {
        private int v1;
        private int v2;

        private int type { get; set; }
        private double speed { get; set; }
        private double capacity { get; set; }
        private double free_space { get; set; }

        public DVD()
        {
            type = 1;
            speed = 130; //MB/c
            capacity = 4.5;
            free_space = capacity;
            Name = "DVD RW disk";
            Model = "4.5 GB ";
        }

        public DVD(int v1, int v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        
    }
}
