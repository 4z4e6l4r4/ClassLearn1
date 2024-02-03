using System.Collections.Concurrent;

namespace ClassLearn1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Torun torun = new Torun();
            torun.Para();
            torun.Bisiklet();

            Console.WriteLine("--------------------------");
            Console.WriteLine("Dede");
            Dede dede = new Dede();

            dede.Araba();
            dede.Altin();

            Console.WriteLine("---------------------");
            Console.WriteLine("Miras + varlık: ");
            Torun torun1 = new Torun();
            torun1.Araba();
            torun1.Altin();
            torun1.Bisiklet();
            torun1.Para();

            //Yalnızca mirası çekmek istediğimiz zaman ata dan nesne oluşturuyoruz
            Console.WriteLine("---------------------");
            Console.WriteLine("Miras:");
            Dede torun2 = new Torun();
            torun2.Araba();
            torun2.Altin();

        }

        class Torun : Dede
        {
            public void Para()
            {
                Console.WriteLine("1000 Tl");
            }
            public void Bisiklet()
            {
                Console.WriteLine("Salcano 21 Vites Bisiklet");
            }
        }

        class Dede
        {
            public void Araba()
            {
                Console.WriteLine("Bugatti Veiron");
            }

            public void Altin()
            {
                Console.WriteLine("20 kg");
            }
        }

       



    }
}