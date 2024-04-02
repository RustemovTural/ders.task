using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exit = true;
            Weapon weapon1=new Weapon(12,6,true);
            do
            {
                Console.Write("Seçiminizi daxil edin");
                Console.WriteLine("0 - İnformasiya almaq üçün");
                Console.WriteLine("1 - Ateş açmaq üçün");
                Console.WriteLine("2 - GetRemainBulletCount metodu üçün");
                Console.WriteLine("3 - Reload metodu üçün");
                Console.WriteLine("4 - ChangeFireMode metodu üçün");
                Console.WriteLine("5 - Proqramdan çıxmaq üçün");
                string input= Console.ReadLine();
                switch(input)
                {
                    case "0":
                     
                        break;
                        
                    case "1":weapon1.Shoot();
                        break;
                    case "2":
                        Console.WriteLine("Qalan gülə sayı: " + weapon1.GetRemainBulletCount());
                        break;
                    case "3":weapon1.Reload();
                        break;
                    case "4":weapon1.ChangeFireMode();
                        break;
                    case "5":
                        exit=true;
                        
                        return;
                    default:Console.WriteLine("duzgun secim edin");
                        break;
                        


                };
                   
            }while (exit!=true);
            
             
        }
    }
}
