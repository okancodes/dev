using System.Runtime.Intrinsics.X86;

namespace PratikVKI
{
    public class Program
    {
        public static void Main()
        {
            string yenidenMi = "";
            do
            {

                Console.Clear();
                Console.WriteLine("Boyunuz (cm): ");
                double boy = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Kilonuz (kg): ");
                double kilo = Convert.ToDouble(Console.ReadLine());
                double boym = (boy / 100);
                double vki = (kilo / (boym * boym));
                //Console.Write("Hastanın Boyu (m): ");
                //Console.WriteLine(boym);
                //Console.Write("Hastanın Kilosu (kg): ");
                //Console.WriteLine(kilo);
                //Console.Write("Hastanın VK indeksi: ");
                //Console.WriteLine(vki);
                //Console.Write("Teşhis: ");
                Console.Write("Hastanın; boyu: {0} m, kilosu: {1} kg, VK indeksi: {2}, Teşhis: ", boym, kilo, vki);

                if (vki >= 0 && vki <= 18.49)
                {
                    Console.WriteLine("ZAYIF");
                }
                else if (vki > 18.5 && vki < 24.99)
                {
                    Console.WriteLine("İDEAL");
                }
                else if (vki >= 25 && vki <= 29.99)
                {
                    Console.WriteLine("HAFİF KİLOLU");
                }
                else if (vki >= 30)
                {
                    Console.WriteLine("OBEZ");
                }
                bool gecerliMi = false;
                do
                {

                    Console.WriteLine("Yeni bir hesaplama yapmak istiyor musunuz?(Evet için E, Hayır için H yazarak Enter a basın.)");
                    yenidenMi = Console.ReadLine();
                    if (yenidenMi == "E" || yenidenMi == "e" || yenidenMi == "H" || yenidenMi == "h")
                    {
                        gecerliMi = true;
                    }
                    if (yenidenMi == "H" || yenidenMi == "h")
                    {
                        Environment.Exit(0);
                    }
                    Console.WriteLine("Hatalı bir giriş yaptınız.");


                } while (gecerliMi == false);
            } while (yenidenMi == "E" || yenidenMi == "e");


        }
    }
}

