internal class Program
{
    private static void Main(string[] args)
    {
        //Abdülhalik Turhan

        //0-1000 arası 2 sayı üretip bu sayılar arasındaki sayıları alt alta ekrana yazan program

        int rastgele, i;

        Random rnd = new Random();

        int sayi1 = rnd.Next(0, 1001);
        int sayi2 = rnd.Next(0, 1001);

        Console.WriteLine("Birinci Sayi: " + sayi1);
        Console.WriteLine("İkinci Sayi: " + sayi2);
        Console.WriteLine(" ");
        if (sayi1 < sayi2)
        {
            for (i = sayi1; i <= sayi2; i++)
            {
                Console.WriteLine(i);
            }
        }
        else
        {
            for (i = sayi2; i <= sayi1; i++)
            {
                Console.WriteLine(i);
            }
        }



        Console.ReadKey();
    }
}