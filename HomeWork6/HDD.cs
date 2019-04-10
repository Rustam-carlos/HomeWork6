using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6
{
    public class HDD : Storage
    {
        private double speed;
        private double capacity;
        private double free_space;
        private int v1;
        private int v2;

        public HDD()
        {
            speed = 130; //MB/c      
            capacity = 16; //Gb 
            free_space = capacity;
            Name = "Flash Drive";
            Model = "16 GB USB3.0";
        }

        public HDD(int v1, int v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        
    }
}
