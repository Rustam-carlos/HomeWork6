using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6
{
    public class Flash : Storage
    {
        private double speed;
        private double capacity;
        private double free_space;
        private int v1;
        private int v2;

        public Flash()
        {
            speed = 130; //MB/c      
            capacity = 16; //Gb 
            free_space = capacity;
            Name = "Flash Drive";
            Model = "16 GB USB3.0";
        }

        public Flash(int v1, int v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public Flash(double V, string F_name, string F_model)
        {
            capacity = 16; //Gb 
            Name = F_name;
            Model = F_model;
        }

        public double Speed
        {
            get { return speed; }
            set { speed = value; }
        }
        public double Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }
        public double FreeSpace
        {
            get { return free_space; }
            set { free_space = value; }
        }

        
    }
}
