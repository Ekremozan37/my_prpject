namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kaç isim kaydetmek istiyorsunuz:");
            int adet = int.Parse(Console.ReadLine());
            int[] number = new int[adet];
            string[] isimler = new string[adet];
            string[] soyisim = new string[adet];
            int[] giriş = new int[adet];
            byte[] vize = new byte[adet];
            byte[] final = new byte[adet];
            double[] ortalama = new double[adet];
            string[] harfnotu = new string[adet];
            for (int i = 0; i < isimler.Length; i++)
            {

                Console.WriteLine($"{i + 1}.Öğrencinin Numarasını giriniz:");
                number[i] = int.Parse(Console.ReadLine());

                Console.WriteLine($"{i + 1}İsim Giriniz:");
                isimler[i] = Console.ReadLine();

                Console.WriteLine($"{i + 1}Soyadını Giriniz:");
                soyisim[i] = Console.ReadLine();



                do
                {

                    Console.WriteLine($"{i + 1}Vize Notunu Giriniz:");
                    vize[i] = byte.Parse(Console.ReadLine());
                    if (vize[i] > 100)
                    {
                        Console.WriteLine("0-100 arasında değer giriniz!");
                        vize[i] = byte.Parse(Console.ReadLine());
                    }
                } while (vize[i] > 100);
                do
                {
                    Console.WriteLine($"{i + 1}Final Notunu Giriniz:");
                    final[i] = byte.Parse(Console.ReadLine());
                    if (final[i] > 100)
                    {
                        Console.WriteLine("0-100 arasında değer giriniz!");
                        final[i] = byte.Parse(Console.ReadLine());
                    }
                } while (final[i] > 100);



                ortalama[i] = (vize[i] * 0.40) + (final[i] * 0.60);
                if (ortalama[i] >= 85) harfnotu[i] = "AA";
                else if (ortalama[i] >= 75) harfnotu[i] = "BA";
                else if (ortalama[i] >= 60) harfnotu[i] = "BB";
                else if (ortalama[i] >= 50) harfnotu[i] = "CB";
                else if (ortalama[i] >= 40) harfnotu[i] = "CC";
                else if (ortalama[i] >= 30) harfnotu[i] = "DC";
                else if (ortalama[i] >= 20) harfnotu[i] = "DD";
                else if (ortalama[i] >= 10) harfnotu[i] = "FD";
                else harfnotu[i] = "FF";

            }
            Console.WriteLine("\nNumara\t\tAd\t\tSoyad\t\tVize\t\tFinal\t\tOrtalama\tHarf notu ");
            for (int i = 0; i < isimler.Length; i++)
            {
                Console.WriteLine($"{number[i]}\t\t{isimler[i]}\t\t{soyisim[i]}\t\t{vize[i]}\t\t{final[i]}\t\t{ortalama[i]}\t\t{harfnotu[i]}");
            }

            double sınıfortalaması = 0;
            byte mindeğer = 100, maxdeğer = 0;
            for (int i = 0; i < isimler.Length; i++)
            {
                sınıfortalaması += ortalama[i];
                if (vize[i] < mindeğer) mindeğer = vize[i];
                if (vize[i] > maxdeğer) maxdeğer = vize[i];
                if (final[i] < mindeğer) mindeğer = final[i];
                if (final[i] > maxdeğer) maxdeğer = final[i];
            }

            sınıfortalaması /= adet;
            Console.WriteLine("\nSınıf Ortalamsı" + sınıfortalaması);
            Console.WriteLine("En düşük not" + mindeğer);
            Console.WriteLine("En yüksek not" + maxdeğer);

        }

    }
}


