using System;

namespace Home_Work_2
{
    class Program
    {
        static void Main(string[] SabinaHomework)
        {
            /* 1- “02.03.2021 tarixində hava soyuq idi” cümləsində 02.03.2021 tarixini string format və interpolation istifadə edərək(ayrı ayrılıqda) console-a yazdırın. Tarix cari tarix olsun(DateTime istifadə edin).*/

            var date4 = DateTime.Now;
            var date5 = date4.ToString("dd/MM/yyyy");
            Console.WriteLine($"{date5} tarixinde hava soyuq idi");

            /* 2 - string tipindən name adlı variable yaradın və string format istifadə edərək ekrana “My name is x” yazdırın. X yerinə name variablesinin dəyəri olsun.*/

            string x = "Sabina";
            Console.WriteLine("My name is " + x);

            /* 3- string tipindən olan variablenin dəyərinin uzunluğunu ekrana yazdırın. */

            /*1-ci usul: */

            string full_name = "Sabina Misirova";
            var leng = full_name.Length;
            Console.WriteLine(leng);

            /*2-ci usul: */

            string full_name_ = "Sabina Misirova";
            Console.WriteLine(full_name_.Length);

            /* 4- DateTime ilə cari tarix götürülsün və format edilərək “dd/MM/yyyy hh:mm” formatına salınsın.*/

            var time = DateTime.Now.ToString("dd/MMMM/YYYY hh:mm");
            Console.WriteLine(time);

            /* 5- String tipindən olan dəyərin başlıqdan və sondan, sondan və başlıqdan olan boşluqlarını silin.*/

            string deyer = "    Sabina Misirova    ";
            var deyerlower = deyer.Trim();
            Console.WriteLine(deyerlower);

            string deyer3 = "    Sabina Misirova    ";
            var deyer2 = deyer3.Trim();
            Console.WriteLine(deyer2);


            /* 6- String tipindən olan dəyərdə a hərflərini b hərfi ilə əvəz edin..*/

            string metn = "Kod yazmaqdan daha maraqli mesguliyyet var mi?";
            var b = metn.Replace("a", "b");
            Console.WriteLine(b);



            /* 7- Parse metodunu 3 fərqli data type üçün yazın.*/

            var dogum_t = int.Parse("27011999");
            Console.WriteLine(dogum_t);

            float dogum_t1 = int.Parse("10051995");
            Console.WriteLine(dogum_t1);

            double dogum_t2 = int.Parse("23101964");
            Console.WriteLine(dogum_t2);

            /* 8- String contains üçün nümunə yazın.*/

            string cumle = "Back end developer olanlardan neyim eskikdir?";
            var me = cumle.Contains("Back end");
            Console.WriteLine(me);

            /* 9-String ends and starts with üçün nümunə yazın.*/

            string numune = "Kod yazmaga baslayanda sanki dunya qaralib ustune cokur";
            var kod = numune.StartsWith("Kod");
            Console.WriteLine(kod);
            var kod2 = numune.EndsWith("dunya");
            Console.WriteLine(kod2);

            /* 10- Stringin bütün hərflərini əvvəlcə böyük, daha sonra kiçik hərflərə dəyişin.*/

            string numune12 = "Kod yazmaga baslayanda sanki dunya qaralib ustune cokur";
            var numune2 = numune12.ToLower();
            Console.WriteLine(numune2);

            /* 11-	String daxilində ilk və son a hərfinin indexini ekrana yazdırın.*/

            string sabi = "Havalar getdikce soyusa da shaxta hele ki yoxdur.";
            var sa = sabi.IndexOf("a");
            Console.WriteLine(sa);
            var asd = sabi.LastIndexOf("a");
            Console.WriteLine(asd);

            //?????????  TAPSİRİQ 12-String dəyərin 5-ci indexinə test sözü yazdırın */

            /*string word = "Hello World";
            string replaceText = word.Insert(5, "Salam");
            Console.WriteLine(replaceText);
            return;  */

            /* 13-String 3-cü indexdən 5-ci indexə qədər olan hissəsini kəsin. */

            string strn = "Axsam teatra getmek daha maraqli olur";
            var str8 = strn.Substring(3, 5);
            Console.WriteLine(str8);

            /*string strn = "Axsam teatra getmek daha maraqli olur";
            var str13 = strn.Substring(2,4);
            Console.WriteLine(str13);*/


            /* 14-String dəyərin 3-cü simvoldan sona qədər, 
             * daha sonra isə əldə edilmiş dəyərdən 2-ci simvoldan 4 simvol sonraya qədər kəsin və nəticəni ekrana yazdırın.*/

            string str = "hesabatlar bugun aparilmalidir";
            Console.WriteLine(str);
            var str2 = str.Substring(3, str.Length - 3);
            Console.WriteLine(str2);
            var str3 = str2.Substring(2, 4);
            Console.WriteLine(str3);

            /*string str="hesabatlar bugun aparilmalidir";
            Console.WriteLine(str);
            var str2 = str.Substring(2,str.Length-2);
            Console.WriteLine(str2);
            var str3 = str2.Substring(1,3);
            Console.WriteLine(str3);*/

            /* 15-Datetime-in metodlarına aid nümunələr yazın.*/

            DateTime time5 = new DateTime(1999, 01, 27, 12, 6, 2);
            DateTime time6 = time5.AddDays(4);
            DateTime time7 = time5.AddYears(23);
            DateTime time8 = time5.AddHours(6);

            Console.WriteLine(time5);
            Console.WriteLine(time6);
            Console.WriteLine(time7);
            Console.WriteLine(time8);

            /* 16-Verilmiş stringə əsasən datetime yaradın və üzərinə 3 ay, 2 gün, 4 saat, 2 dəqiqə və 34 saniyə gəlin.*/

            DateTime time10 = new DateTime(1995, 05, 19, 9, 35, 28);
            DateTime time11 = time10.AddMonths(3);
            DateTime time12 = time11.AddDays(2);
            DateTime time13 = time12.AddHours(4);
            DateTime time14 = time13.AddMinutes(2);
            DateTime time15 = time14.AddSeconds(34);
            Console.WriteLine(time10);
            Console.WriteLine(time15);


            /* 17- Həftənin gününü ekrana yazdırın.*/

            var item = DateTime.Now.ToString("dddd");
            Console.WriteLine(item);

            /* 18-Int tipindən variable təyin edin və dəyər assign edib ekrana yazdırın.*/

            int reqem = 187625;
            Console.WriteLine(reqem);

            /* 19-Bool tipindən variable təyin edin və dəyər assign edib ekrana yazdırın.*/

            string abd = "543";
            string ashd = "758347";
            bool muqayise = abd == ashd;
            Console.WriteLine(muqayise);

            /* 20-String tipindən variable təyin edin və dəyər assign edib ekrana yazdırın.*/

            string str78 = "Sabina Misirova";
            Console.WriteLine(str78);

            /* 21-Char tipindən variable təyin edin və dəyər assign edib ekrana yazdırın.*/

            char ch = 'S';
            Console.WriteLine(ch);

            /* 22-Cari tarixi ekrana yazdırın.*/

            var vaxt = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(vaxt);

            /* 23- Double, float və decimal tipindən variable təyin edin və dəyər assign edib ekrana yazdırın.*/

            float kesr = 34.8754f;
            Console.WriteLine(kesr);

            double kesr2 = 4092.388748;
            Console.WriteLine(kesr2);

            decimal kesr3 = 4984657.64969309890M;
            Console.WriteLine(kesr3);

            /* 24- Cari tarixin ilini ekrana yazdırın.*/

            var item2 = DateTime.Now.ToString("yyyy");
            Console.WriteLine(item2);

            /* 25-	Int tipindən 2 variable təyin edin və dəyər assign edin. Daha sonra ekrana həmin ədədlərin hasilini yazdırın.*/

            int dyr = 2701;
            int dry = 1005;
            Console.WriteLine(dyr * dry);

            /* 26-	Int tipindən 2 variable təyin edin və dəyər assign edin. Daha sonra ekrana birinci ədədin ikinci ədədə bölünməsindən alınan qalığı yazdırın.*/

            int dyr21 = 13;
            int dry23 = 3;
            Console.WriteLine(dyr21 % dry23);

            /* 27- Istifadeciye sual verinki nece yasin var. Ekrana onun yasi ile oz yasiniz arasinda ferqi yazdirin.*/

            int age_me = 23;
            Console.WriteLine("Senin neçe yaşin var? ");
            string userInput = Console.ReadLine();
            int ferq = age_me - int.Parse(userInput);
            Console.WriteLine($"Menim {age_me} yasim var ");
            Console.WriteLine($"Bizim yas ferqimiz: {Math.Abs(ferq)}");

            /* 28-	Istifadecinin adini,soyadini,nomresini,yasini ayri-ayri sorucun ve birlerdirib ekrana yazdirin*/

            Console.WriteLine("Istifadeci adi: ");
            string userinput1 = Console.ReadLine();
            Console.WriteLine("Istifadeci soyadi: ");
            string userinput2 = Console.ReadLine();
            Console.WriteLine("Istifadeci nomresi: ");
            string userinput3 = Console.ReadLine();
            Console.WriteLine("Yash: ");
            string userinput4 = Console.ReadLine();
            Console.WriteLine($"{userinput1} {userinput2} {userinput3} {userinput4}");
        }
    }
}
