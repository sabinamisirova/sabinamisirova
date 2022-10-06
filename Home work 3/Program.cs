using System;

namespace Home_work_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.İstifadəçidən input alınsın. Alınmış inputdakı başlanğıcdan olan boşluqlar silinsin. 

            string str = Console.ReadLine();
            Console.WriteLine(str.TrimStart());

            //2.İstifadəçidən alınmış inputda “e” və “q” hərfləri varsa,ekrana “Can not enter e or q symbol” yazılsın.

            string str2 = Console.ReadLine();
             if (str2.Contains('e') || str2.Contains('q'))
             {
                Console.WriteLine("Can not enter e or q symbol");

             }

            //3.İstifadəçidən alınmış inputdakı bütün boşluqlar silinsin. (yalnız başlanğıc və sondakı deyil, hamısı)Daha sonra dəyərin bütün hərfləri böyüklə əvəzlənib ekrana yazdırılsın.

            string str3 = Console.ReadLine();
            Console.WriteLine(str3.ToUpper().Trim());

            //4.İstifadəçidən input alınsın. Alınmış inputun 2ci simvolundan sonra 5 simvol ekrana çap edilsin. Əgər əmliyyatın icrası mümkün deyilsə, “can not execute operation” mesajı yazdırılsın

            string str4 = Console.ReadLine();
            if (str4.Length >= 7)
            {
                string str5 = str4.Substring(2, 5);
            }
            else
            {
                Console.WriteLine("can not execute operation");
            }

            //5.Istifadəçidən input alınsın.Alınmış input null və ya boşluqlardan ibarətdirsə, ekrana “value can not be empty or whitespace” yazılsın.
           
            string str5 = Console.ReadLine();
            var str6 = str5 ?? "null";
            Console.WriteLine("value can not be empty or whitespace");

            //6.String tipli constant variable yaradın və dəyərini ekrana yazdırın.

            const string sab = "Sabina";
            Console.WriteLine(sab);

            //7.  0 - 100 arasında integer tipli Random dəyər generasiya edin və ekrana yazdırın.

            Random rand = new Random();
            int randed = rand.Next(0, 100);
            Console.WriteLine(rameded);

            //8.  10 - 2333 arasında integer tipli Random dəyər generasiya edin və ekrana yazdırın.

            Random radn = new Random();
            int radned = radn.Next(10, 2333);
            Console.WriteLine(radned);

            //9.GUİD generasiya edin və ekrana yazdırın.

            Guid gid = Guid.NewGuid();
            Console.WriteLine(gid);

            //10.İstidadəçidən ədəd daxil etməsini tələb edin və daxil edilmiş ədəd 10 - dan böyüksə, ekrana “10 - dan böyük”, 10 - dan kiçiksə ekrana “10 - dan kiçik”, digər halda isə “10 - a bərabər” yazılsın.

            int str7 = Convert.ToInt32(Console.ReadLine());
            if (str7 > 10)
            {
                Console.WriteLine("10 - dan böyük");
            }
            else if (str7 < 10)
            {
                Console.WriteLine("10 - dan kiçik");
            }
            else
            {
                Console.WriteLine("10 - a bərabər");
            }

            //11.Istifadəçidən string dəyər daxil etməsini tələb edin. Daxil edilmiş dəyərin uzunluğu 6 - dan böyüksə,  ekrana “6 - dan böyük”, 6 - dan kiçiksə ekrana “6 - dan kiçik”, digər halda isə “6 - a bərabər” yazılsın.
           
            string str8 = Console.ReadLine();
            if (str8.Length > 6)
            {
                Console.WriteLine("6 - dan böyük");
            }
            else if (str8.Length < 6)
            {
                Console.WriteLine("6 - dan kiçik");
            }
            else
            {
                Console.WriteLine("6 - a bərabər");
            }

            //12.İstifadəçidən dəyər alınsın, alınmış dəyər 6 və ya 7 - dirsə, ekrana “düzgün cavab” yazdırılsın.

            int str9 = int.Parse(Console.ReadLine());
            if ((str9 == 6) || (str9 == 7))
            {
                Console.WriteLine("düzgün cavab");
            }

            //13.İstifadəçidən dəyər alınsın, alınmış dəyər 1 və 10 aralığındadırsa, ekrana “1 - 10 aralığı”,  10 - 20 aralığındadırsa “10 - 20 aralığı”, əks halda “nəticə tapılmadı” yazılsın.

            int a = int.Parse(Console.ReadLine());
            int x = 1;
            int y = 10;
            int z = 20;
            if (a > x && a < y)
                Console.WriteLine($"{a} deyiseni 1 ve 10 reqem araliqindadir");
            else if (a > y && a < z)
                Console.WriteLine($"{a} deyiseni 10 ve 20 reqem araliqindadir");
            else
                Console.WriteLine("netice tapilmadi !");

            //14.Ədədin tək və ya cüt olduğunu tapın. Əgər ədəd cütdürsə ekrana “cüt ədəd”, əks halda “tək ədəd” yazılsın.

            int a = int.Parse(Console.ReadLine());
            if (a % 2 == 0)
                Console.WriteLine("cut eded");
            else
                Console.WriteLine("tek eded");


            //15. 0 - 100 arasi random ədəd generasiya edilsin və əgər generasiya olunmuş ədəd 50 - dən böyükdürsə, ekrana yazdırılsın.
 
            Random rd = new Random();
            int rded = rd.Next();
            if (rded > 50)
                Console.WriteLine(rded);

            //17.İstifadəçidən dəyər daxil etməsi tələb edilsin və daxil edilmiş dəyərdə yalnız 1 “t” hərfinin olub olmamasını yoxlayın.  Əgər yalnız 1 “t” hərfi varsa, “dəyərdə tək t hərfi var” yazısı ekrana yazdırılsın.

            string tsr = Console.ReadLine();
            var tsr2 = tsr.IndexOf('t');
            var tsr3 = tsr.LastIndexOf('t');
            if (tsr2 == tsr3)
                Console.WriteLine("deyerde tek t herfi var");
            else
                Console.WriteLine("deyerde cox t herfi var");



        }
    }
}
