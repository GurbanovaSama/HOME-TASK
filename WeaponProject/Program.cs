namespace WeaponProject
{
    internal class Program
    {
        public static FireMode GetFireModeFromInput(int input)
        {
            switch (input) 
            { 
                case 0:
                    return FireMode.Single;
                case 1:
                    return FireMode.Automatic;
                default:
                    Console.WriteLine("This choice is incorrect");
                    return null;
            }
        }



        static void Main(string[] args)
        {
            Console.WriteLine("Enter the information");

            Console.Write("Maximum bullet capacity of comb");
            int maxBulletCapacity = int.Parse(Console.ReadLine());

            Console.Write("Starting bullet count");
            int startingBulletCount = int.Parse(Console.ReadLine());

            Console.Write("Firing mode: 0-single, 1-automatic");
            int fireModeInput = int.Parse(Console.ReadLine());
            FireMode fireMode = GetFireModeFromInput(fireModeInput);

            Weapon weapon = new Weapon(maxBulletCapacity, startingBulletCount, fireMode);

            bool runnig = true;

            while (runnig)
            {
                Console.WriteLine("\n Make your choice");
                Console.WriteLine("0 - İnformasiya almaq üçün");
                Console.WriteLine("1 - Shoot metodu üçün");
                Console.WriteLine("2 - Fire metodu üçün");
                Console.WriteLine("3 - GetRemainBulletCount metodu üçün");
                Console.WriteLine("4 - Reload metodu üçün");
                Console.WriteLine("5 - ChangeFireMode metodu üçün");
                Console.WriteLine("6 - Proqramdan dayandırmaq üçün");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 0: 
                        Console.WriteLine($"Bullet capacity of comb: {weapon.GetRemainBulletCount()}");
                        break;
                    case 1:
                        weapon.Shoot();
                        break;
                    case 2:
                        weapon.Fire();
                        break;
                    case 3:
                        Console.WriteLine("The number of bullets needed for a full charge:" + weapon.GetRemainBulletCount());
                        break;
                    case 4:
                        weapon.Reload();
                        break;  
                    case 5:
                        weapon.ChangeFireMode();
                        break;
                    case 6:
                        runnig = false;
                        break;
                    default:
                        Console.WriteLine("Sorry, you made the wrong choice");
                        break;


                }


            }

        }
    }
}
