using System.Numerics;

namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1) Verilmish metnde {a} simvolun sayi {b} simvolun sayinda nece defe coxdur?    **yazdim**
            string text = "aaabbbaa";
            char text1 = 'a';
            int count = 0;
            foreach (char result in text)
            {
                if (result == text1)
                {
                    count++;

                }
            }
            Console.WriteLine($"a simvolu b simvolundan : {count} boyukdur");
            //2) Verilmish metnde sol terefden tek yerde dayanan simvollarin hamisi {a} simvoludurmu?   **yazdim**
            string text2 = "ababbbcc";
            char text21 = 'a';

            bool netice = false;
            foreach (char result2 in text2)
            {
                if (result2 % 2 == 0 && result2 == 'a')
                {
                    netice = true;
                }
            }
            Console.WriteLine(netice);

            //3) Verilmish metnde sol terefden tek yerde dayanan simvollardan necesi {b} -ye beraberdir. **yazdim**
            string text3 = "aaabbbccc";
            char text31 = 'b';
            bool netice3 = false;
            foreach (char result3 in text3)
            {
                if (result3 % 2 == 0 && result3 == 'b')
                {
                    netice3 = true;
                }
            }
            Console.WriteLine(netice3);
            //4) Verilmish metnde sol terefden ilk rast gelinen {a} simvolunun yeri tek ededdi yoxsa cut ? **yazdim**
            string text4 = "babbcde";
            char[] symbols4 = new[] { 'a' };
            int index4 = text4.IndexOfAny(symbols4);
            for (int i = 0; i < text4.Length; ++i)
            {
                if (index4 % 2 == 0)
                {
                    Console.WriteLine("a simvolunun yeri cutdur");
                    break;

                }
                else
                {
                    Console.WriteLine("a simvolunun yeri tekdir");
                    break;
                }
            }






            /*  bool netice4 = false;*/
            //5) Verilmish metnde sol terefden saydiqda {a},{b},{c} simollarindan hansi birinci gelir? **yazdim**
            string text5 = "bca";
            char[] symbols = new[] { 'a', 'b', 'c' };
            Console.WriteLine(text5.IndexOfAny(symbols));
            //6) Verilmish metnde {a} simvolunun sol terefden ve sag terefden indexleri eydidirmi? **yazdim**
            string text6 = "abc";
            char[] symbols6 = new[] { 'a' };
            int firstIndex = text6.IndexOfAny(symbols6);
            int lastIndex = text6.LastIndexOfAny(symbols6);
            for (int i = 0; i < text6.Length; i++)
            {
                if (firstIndex == lastIndex)
                {
                    Console.WriteLine("{a} simvolunun sol terefden ve sag terefden indexleri eydidir");
                    break;
                }
                else
                {
                    Console.WriteLine("{a} simvolunun sol terefden ve sag terefden indexleri eyni deyil");
                    break;
                }
            }
            //7) Verilmish metnde {a} simvolu {b} simvolundan qabaq ve oda {c} simvolundan qabaq gelirmi? **yazdim**
            string text7 = "abc";
            int text71a = text7.IndexOf("a");
            int text71b = text7.IndexOf("b");
            int text71c = text7.IndexOf("c");
            if (text71a < text71b && text71b < text71c)
            {
                Console.WriteLine("{a} simvolu {b} simvolundan qabaq ve oda {c} simvolundan qabaq gelir");
            }
            else
            {
                Console.WriteLine("{a} simvolu {b} simvolundan qabaq ve oda {c} simvolundan qabaq gelmir");
            }


            //8) Verilmish metnde ilk qabagima cixan {a} simvolundan sonra gelen simvolu 10 defe dalbadal cap et. **yazdim**
            string text8 = "ac";
            text8 = text8.Substring(1);
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(text8);
            }
            //9) Verilmish metinde ilk 3 simvol, son 3 simvolun tersine formasina beraberdirmi.?  **yazabilmedim**



            //10) Verilmish metinde butun reqemleri legv et. **yazdim**
            string text10 = "ab23456";
            text10 = text10.Remove(1);
            Console.WriteLine(text10);


            //11) Verilmish metinde butun {a} simvollarinin qabagina {b} simvolunu ve eyni zamandan butun {b} **yazdim**
            //simvollarinin qabagina {a} simvolunu yaz. 
            string text11 = "Azerbaycan";
            char x1 = 'a';
            char y1 = 'b';
            char[] symbols11 = new[] { x1, y1 };
            int index = -1;
            do
            {
                index = text11.IndexOfAny(symbols11, index + 1);
                if (index != -1 && text11[index] == x1)
                {
                    text11 = text11.Insert(index, y1.ToString());
                    index++;
                }
                else if (index != -1 && text11[index] == x1)
                {
                    text11 = text11.Insert(index, y1.ToString());
                    index++;
                }

            } while (index < text11.Length && index != -1);
            Console.WriteLine(text11);


            //12) Verilmish metinde en ilk ve en son {a} simvolundan bashqa yerde qalan butun {a} simvollarini yox et. **Yazdim** 
            string text12 = "abbcc";
            text12 = text12.Remove(1, 3);
            Console.WriteLine(text12);

            //13) Verilimish metinde butun simvollari ardicil shekilde biri balaca, biri boyuk formada cap et. //yazdim
            string text13 = "aabbccddee";
          
            for (int i = 0; i < text13.Length; i++)
            {
                char cuurentChar = text13[i];
                if (i % 2 == 0)
                {
                    Console.Write(char.ToUpper(cuurentChar));
                    break;

                }
                else
                {
                    Console.Write(char.ToLower(cuurentChar));
                    break;
                }
            }


            //14) Verilmish metinde butun tek yerde dayanan simvollari ondan sonra gelen simvolun BOYUK formasi ile evez et. 
            string text14 = "abcdefgy";
            for (int z = 0; z < text14.Length; z++)
            {
                char newChar = text14[z];
                if (z % 2 == 0  )
                {
                    Console.Write(char.ToUpper(newChar));

                }
                else
                {
                    Console.Write(char.ToLower(newChar));
                }

            }
            // 15)* Verilmish metinde ilk ve son simvol eynidirse,ve metn daxilinde yanashi gelen {a} simvolu varsa,
            //ve metn daxilinde {b} simvolu yoxdursave metn daxilinde {b} simvolu yoxdursa
            //neticede alinan metn zerkalni olub olmadigini yoxla.
            string text15 = "abc";
            char[] newChar15 = new[] { 'a' };
            int index15 = text15.IndexOfAny(newChar15);
            int index152 = text15.LastIndexOfAny(newChar15);
            if(index15 == index152)
            {

            }

        }
    }   
    }
          
    

