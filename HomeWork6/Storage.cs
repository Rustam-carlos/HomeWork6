using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6
{
    public abstract class Storage
    {
        const int GbOnMb = 8000;
        private int _memory;
        private int _speed = 680;
        private int _time;

        public string Name { get; set; }
        public string Model { get; set; }


        public int Memory
        {
            get
            {
                Console.WriteLine("Объем = ");
                return _memory;
            }
            set
            {
                _memory = value;
            }
        }

        public int Speed
        {
            get
            {
                Console.WriteLine("Скорость = ");
                return _speed;
            }
            set
            {
                _speed = value;
            }
        }

        public void CopyData(string file, int memory)
        {
            Console.WriteLine(file);
            Console.WriteLine("Память носителя = " + _memory);
            Console.WriteLine("Память файла = " + memory);
            _time = (memory * GbOnMb) / _speed;
            Console.WriteLine("Время затраченное = " + _time + " сек");
        }
        public void Info(int memory)
        {
            _memory = _memory - memory;
            Console.WriteLine("Свободно памяти = " + _memory);
        }
    }
}
