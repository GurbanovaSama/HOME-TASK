using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponProject
{
    public class FireMode
    {
        public string Name { get; set; }

        private FireMode(string name)
        {
            Name = name;
        }

        public static readonly FireMode Single = new FireMode("Təkli");
        public static readonly FireMode Automatic = new FireMode("Avtomatik");
     
    }

    public class Weapon
    {
        private int maxBulletCapacity;
        private int startingBulletCount;
        private FireMode fireMode;

        public Weapon(int maxBulletCapacity, int bulletCount, FireMode fireMode)
        {
            if ( maxBulletCapacity <= 0)
            {
                Console.WriteLine("Error");
                return;
            }
            if (bulletCount < 0)
            {
                Console.WriteLine("Error");
                return;
            }
            if (bulletCount > maxBulletCapacity)
            {
                Console.WriteLine("Error");
                return;
            }

            this.maxBulletCapacity = maxBulletCapacity;
            this.startingBulletCount = bulletCount;
            this.fireMode = fireMode;
        }

        public void Shoot()
        {
            if(startingBulletCount > 0)
            {
                startingBulletCount--;
                Console.WriteLine("Number of bullets remaining" + startingBulletCount);
            }
            else
            {
                Console.WriteLine("No bullets");
            }
        }

        public void Fire()
        {
            int bulletsFired = startingBulletCount;
            startingBulletCount = 0;
            Console.WriteLine($"Bullets fired:  {bulletsFired}, number of bullets remaining:  {startingBulletCount} ");
        }

        public int GetRemainBulletCount()
        {
            return maxBulletCapacity - startingBulletCount;
        }

        public void Reload()
        {
            startingBulletCount = maxBulletCapacity;
            Console.WriteLine("Recharged");
        }

        public void ChangeFireMode()
        {
            if ( fireMode == FireMode.Single)
            {
                fireMode = FireMode.Automatic;
            }
            else
            {
                fireMode = FireMode.Single;
            }
            Console.WriteLine("Fire mode has changed" + fireMode);
        }


       
    }
}
