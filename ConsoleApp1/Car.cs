using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Car : Vehicle, IDestroyable
    {
        public string DestructionSound { get; set; }

        public List<IDestroyable> DestroyablesNearBy;


        public Car(float speed, string Color) 
        {
            this.Speed = speed;
            this.Color = Color;
            DestructionSound = "CarExplosionSound.mp3";
            DestroyablesNearBy=new List<IDestroyable>();
        }

        

        public void Destroy()
        {
            Console.WriteLine("Playing destruction sound {0}", DestructionSound);
            Console.WriteLine("Create fire");

            foreach(IDestroyable destroyable in DestroyablesNearBy)
            {
                destroyable.Destroy();
            }
        }
    }
}
