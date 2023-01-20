namespace PratikVKIMethod
{
    public class Program
    {
        public static void Main() {
            Giris();     
        }
        static void Giris()
        {
            Console.Clear();
            Console.WriteLine("Vücut Kitle Indeksi Hesaplama Programına hoşgeldiniz. Lütfen aşağıda istenenleri yazınız. ");
            var oprnt = Operantlar();
            double vki = VKIhesap(oprnt.kilo, oprnt.boy);
            Console.Write($"Hastanın boyu: {oprnt.boy}, kilosu {oprnt.kilo}, VK indeksi {vki}, Teşhis: ");
            switch (vki)
            {
                case (<= 18.49):
                    RenkliYaz("ZAYIF", ConsoleColor.Blue);
                    break;
                case (< 24.99):
                    RenkliYaz("İDEAL", ConsoleColor.Green);
                    break;
                case (< 29.99):
                    RenkliYaz("HAFİF KİLOLU", ConsoleColor.DarkYellow);
                    break;
                case (>= 30):
                    RenkliYaz("OBEZ", ConsoleColor.Red);
                    break;
            }
            yeniIslem();
        }
        static double VKIhesap(double a, double b)
        {
            double vki = (a / (b * b));
            return (vki);
        }
        static (double boy, double kilo) Operantlar()
        {
            RenkliYaz("Hastanın Boyu (m): ",ConsoleColor.Cyan);
            double boy = Convert.ToDouble(Console.ReadLine());
            RenkliYaz("Hastanın Ağırlığı (kg): ", ConsoleColor.Cyan);
            double kilo = Convert.ToDouble(Console.ReadLine());
            return (boy, kilo);
        }
        static void yeniIslem()
        {
            RenkliYaz("Yeni bir işlem yapmak ister misiniz? (E/H)", ConsoleColor.Yellow);
            switch(Console.ReadLine())
            {
                case ("E"):
                case ("e"):
                    Giris();
                    break;
                case ("H"):
                case ("h"):
                    Environment.Exit(0);
                    break;
                default:
                    RenkliYaz("Hatalı bir işlem yaptınız.Yeniden denemek için ENTER a basınız.",ConsoleColor.Red);
                    Console.ReadLine();
                    yeniIslem();
                    break;
                    
            }
        }
        static void RenkliYaz(string mesaj, ConsoleColor yaziRengi)
        {
            Console.ForegroundColor = yaziRengi;
            Console.WriteLine(mesaj);
            Console.ResetColor();
        }
    }   
}
