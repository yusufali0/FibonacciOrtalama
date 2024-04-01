namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Terim Sayisi Girin");
            int terim = Convert.ToInt32(Console.ReadLine());
            int a = 0, b = 1, c;
            int toplam = 0;
            Console.WriteLine("Fibonnaci");


            for (int i = 0; i < terim; i++)
            {
                Console.WriteLine(a + " ");
                toplam += a;
                c = a + b;
                a = b;
                b = c;
            }

            double ortalama=(double)toplam/terim;
            Console.WriteLine("ortalama= "+ortalama);
            Console.ReadLine();

           
        }
    }
}
