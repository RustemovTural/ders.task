using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    internal class Weapon
    {
        public int CapacityBullet {  get; set; }
        public int CurrentBullet { get; set;}
        public bool FireMood { get; set; }
        public Weapon(int capacitybullet,int currentbullet,bool firemood)
        {
            CapacityBullet = capacitybullet;
            CurrentBullet = currentbullet;
            FireMood = firemood;
        }public void Shoot() 
        {
            if (CurrentBullet > 0)
            {
                if (FireMood = true)
                {
                    Console.WriteLine("Avtomatik atis");
                }
                else
                {
                    Console.WriteLine("Tekli atis");
                }

            }
            else
            {
                Console.WriteLine("gulle yoxdur");
            }

        }
        public int GetRemainBulletCount()
        {
            return CapacityBullet;
        }
        public void Reload()
        {
            CapacityBullet = CurrentBullet;
            Console.WriteLine("Gulle dolduruldu");
        }
        public void ChangeFireMode()
        {
            if(FireMood = true)
            {
                Console.WriteLine("avtoamtik atis");
            }
            else
            {
                Console.WriteLine("tekli atis");
            }
        }

    }
    
}
