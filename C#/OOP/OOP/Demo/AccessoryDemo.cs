using OOP.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Demo
{
    class AccessoryDemo
    {
        public Accessory createAccessoryTest(int id, string name)
        {
            Accessory accessory = new Accessory() { id = id, name = name };

            return accessory;
        }

        public void printAccessoryTest(Accessory accessory)
        {
            Console.WriteLine("Accessory");
            Console.WriteLine("id:" + accessory.id);
            Console.WriteLine("name:" + accessory.name);
            Console.WriteLine();
        }
    }
}
