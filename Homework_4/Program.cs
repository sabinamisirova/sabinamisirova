using System;

namespace Homework_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //            İstifadəçidən number formatlı dəyər daxil edilməsi istənilsin.Daxil edilmiş dəyər qədər 0 - la 200 arasında ədəd generasiya olunsun və bu ədədlərin cəmi ekrana yazdırılsın.
            //int tnt = Convert.ToInt32(Console.ReadLine());
            //Random rand = new Random();
            //int randed = rand.Next(0, 200);
            //Console.WriteLine(randed);
            //Console.WriteLine(randed + tnt);
            //            1 - dən 20 - ə kimi ədədlərin kvadları cəmi ekrana yazdırılsın.
            //for (int i = 1; i <= 20; i++)
            //    Console.WriteLine(Math.Pow(i,2));
            //3(?).  1 - dən 100 - ə kimi ədədlər ekrana yazdırılsın. ( )++ +
            //for (int i = 1; i <= 100; i++)
            //    Console.WriteLine(i);
            //4.  1 - dən 100 - ə qədər ancaq 3 - ə bölünən ədədlər ekrana yazdırılsın. (for ilə) +++
            //for (int i = 1; i < 100; i++)
            //    if (i % 3 == 0)
            //        Console.WriteLine(i);
            //5.  1 - dən 100 - ə qədər ədədlər ekrana yazdırılsın. (36 və 67 istisna olmaqla)+++
            //for (int i = 1; i < 100; i++)
            //    if (i != 36 && i != 67)
            //        Console.WriteLine(i);
            //6.  1 - dən 100 - ə ədədlər dövrə salınsın.İlk 17 - ə bölünən ədəd tapılanda proqram ekrana “17 - ə bölünən ilk ədəd tapıldı” yazılsın++ +
            //for (int i = 1; i < 100; i++)
            //    if (i % 17 == 0)
            //        continue;
            //        Console.WriteLine("17 - e bolunen ilk eded tapildi");

            //7(?).String dəyər təyin edilsin. 1000 iterasiyalı dövr qurulsun.
            //    Hər iterasiyada  təyin etdiyimiz dəyərin üzərinə “iteration number i” gəlsin.i dinamik olaraq iterasiya nömrəsindən alınsın. 
            //    Dövr tamamlandıqdan sonra ən sonda ekrana təyin edilmiş dəyər(başlanğıcda təyin etdiyimiz,
            //    dövrdə üzərinə iteration number əlavə edilən dəyər) yazılsın.\

            //string firstWord = "Hello World";
            //string dynamicWord = firstWord;
            //for (int i = 0; i <=1000; i++)
            //{
            //    dynamicWord += i;
            //}

            //Console.WriteLine($"İlk deyer {firstWord}");
            //Console.WriteLine($"Dinamik deyer {dynamicWord}");

            //8.  100 - dən 1 - ə kimi ədədləri azalan qaydada ekrana yazdırın.
            //for (int i = 100; i> 0; i--)
            //    Console.WriteLine(i);
            //9.Math bütün funksionallıqlarına aid nümunə yazın.

            //int tbt = Math.Min(5, 7);
            //int tbt1 = Math.Max(5,7);
            //double tbt2 = Math.Round(6.9);
            //double tbt3 = Math.Floor(6.99);
            //double tbt4 = Math.Ceiling(6.999);
            //int tbt5 = Math.Abs(-6);
            //double tbt6 = Math.Atan(7.89);
            //Console.WriteLine(tbt);
            //Console.WriteLine(tbt1);
            //Console.WriteLine(tbt2);
            //Console.WriteLine(tbt3);
            //Console.WriteLine(tbt4);
            //Console.WriteLine(tbt5);
            //Console.WriteLine(tbt6);

            //10(?).String name adlı variable təyin edilsin.Daha sonra yeni string variable yaradın və əgər name nulldursa “test”,
            //əks halda name -in dəyərini alsın.
            string name = Console.ReadLine();
            string n = "Misirova";
            if (name == null)
            Console.WriteLine("test");
            else 
            Console.WriteLine(name);



            //11(?).Istifadəçidən dəyər alınsın. Daxil edilmiş dəyər “bir” dirsə, ekrana “bir”, “iki”dirsə ekrana “iki”, “üç”dürsə ekrana “üç”, heç biri deyilsə, “tapılmadı”yazılsın.

            //int tin = Convert.ToInt32(Console.ReadLine());
            //if (tin == 1)
            //    Console.WriteLine("bir");
            //else if (tin == 2)
            //    Console.WriteLine("iki");
            //else if (tin == 3)
            //    Console.WriteLine("uc");
            //else
            //    Console.WriteLine("tapilmadi");

            //12.Switch - ya aid nümunə yazın.

            //int swt = Convert.ToInt32(Console.ReadLine());
            //switch (swt)
            //{
            //    case 5:
            //        Console.WriteLine("elaci");
            //        break;
            //    case 4:
            //        Console.WriteLine("zerbeci");
            //        break;
            //    case 3:
            //        Console.WriteLine("zeif ");
            //        break;
            //    case 2:
            //        Console.WriteLine("oxumayan");
            //        break;
            //    default:
            //        Console.WriteLine("Duzgun qiymet daxil edin");
            //        break;
            //}
            //13.Nullable double dəyişəni təyin edin. Əgər dəyişənin dəyəri “null”dursa, ekrana “nulldur”, əks halda dəyəri yazdırılsın.
            //double? dbl = 5 ;
            //if (dbl == null)
            //    Console.WriteLine("null");
            //else
            //    Console.WriteLine(dbl);
            //14. 10 - dən 300 - ə kimi ədədləri 2 vahid artmaqla ekrana yazdırın.
            //for (int i = 10; i < 300; i = i + 2)
            //    Console.WriteLine(i);
            //15. 200 - dən 40 - a kimi ədədləri 12 vahid azalmaqla ekrana yazdırın.
            //for (int i = 200; i > 40; i = i - 12)
            //    Console.WriteLine(i);
            //16.İstifadəçidən dəyər daxil etməsi tələb edilsin.Əgər dəyər üzərində riyazi əməliyyat aparmaq mümkündürsə, 
            //“siz ədəd daxil etdiniz”, əks halda “siz mətn daxil etdiniz” yazısı console-a yazdırılsın.

            //try
            //{
            //    int deyer=Convert.ToInt32(Console.ReadLine());
            //    double dey2 = Math.Pow(deyer, 3);
            //    Console.WriteLine(dey2);
            //}
            //catch
            //{
            //    Console.WriteLine("siz metn daxil etdiniz");
            //}




        }
    }
}
