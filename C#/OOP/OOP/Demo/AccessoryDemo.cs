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
            Accessory accessory = new Accessory(id, name);

            return accessory;
        }

        public void printAccessoryTest(Accessory accessory)
        {
            Console.WriteLine("Accessory");
            Console.WriteLine("id:" + accessory.Id);
            Console.WriteLine("name:" + accessory.Name);
            Console.WriteLine();
        }
    }
}
