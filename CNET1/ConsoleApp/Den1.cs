﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Den1
    {
        void DnyVTydnu()
        {
            string[] dny = ["pondělí", "úterý", "středa", "čtvrtek",
                "pátek", "sobota", "neděle"];

            string DenVTydnu(int x)
            {
                if (x < 0 || x > 6)
                    throw new IndexOutOfRangeException();

                return dny[x - 1];
            }

            Console.WriteLine("Zadávej číslo 1-7 nebo X pro ukončení.");
            string input = Console.ReadLine();

            while (input != "X")
            {
                int number = int.Parse(input);

                if (number < 1 || number > 7)
                {
                    Console.WriteLine("zadané číslo je mimo povolený rozsah");
                }
                else
                {
                    string den_v_tydnu = DenVTydnu(number);
                    Console.WriteLine($"den v týdnu: {den_v_tydnu}");
                }

                Console.WriteLine("Zadávej číslo 1-7 nebo X pro ukončení.");
                input = Console.ReadLine();
            }

            Console.WriteLine("ukončuji program");
        }

        void DnyVTydnuEnum()
        {
            string[] dny = ["pondělí", "úterý", "středa", "čtvrtek",
                "pátek", "sobota", "neděle"];

            string DenVTydnuSlovo(DenVTydnu x)
            {
                return dny[(int)x];
            }

            Console.WriteLine("Zadávej číslo 1-7 nebo X pro ukončení.");
            string input = Console.ReadLine();

            while (input.ToUpper() != "X")
            {
                try
                {
                    int number = int.Parse(input);

                    if (number < 1 || number > 7)
                    {
                        Console.WriteLine("zadané číslo je mimo povolený rozsah");
                    }
                    else
                    {
                        DenVTydnu den = (DenVTydnu)(number - 1);
                        string den_v_tydnu = DenVTydnuSlovo(den);
                        Console.WriteLine($"den v týdnu: {den_v_tydnu}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("neplatný vstup");
                }

                Console.WriteLine("Zadávej číslo 1-7 nebo X pro ukončení.");
                input = Console.ReadLine();
            }

            Console.WriteLine("ukončuji program");

            //    enum DenVTydnu
            //{
            //    PONDELI,
            //    UTERY,
            //    STREDA,
            //    CTVRTEK,
            //    PATEK,
            //    SOBOTA,
            //    NEDELE
            //}
        }

        void TernarniOperator()
        {
            int Bigger(int a, int b)
            {

                //ternarni operator
                return (a > b) ? a : b;

                //if (a > b)
                //    return a;
                //else
                //    return b;
            }
        }

        void DateTimes()
        {
            DateTime dt = new(2025, 2, 17, 14, 38, 50);
            DateTime dt2 = new(2025, 2, 16, 14, 38, 50);


            Console.WriteLine($"den v roce: {dt.DayOfYear}");
            Console.WriteLine($"den v tydnu: {dt.DayOfWeek}");

            DateOnly date_only = new(2025, 2, 17);
            TimeOnly time_only = new TimeOnly(15, 22);

            TimeSpan diff = dt - dt2;

            DateTime x = dt + diff;

            DateTime parsed = DateTime.Parse("2025-2-12");

            Console.WriteLine($"parsed: {parsed}");

            DateTime nyni = DateTime.Now;
        }


        int Age(DateTime birth)
        {
            DateTime now = DateTime.Now;

            TimeSpan diff = now - birth;

            return (int)(diff.TotalDays / 365);
        }

        void AgeTuple()
        {
            // tuple
            (double sum, int count, bool ordered) t1 = (4.5, 3, false);

            var x = t1.sum;
            var y = x + 5.3;
            var date_only = new DateOnly(2025, 2, 17);
            var time_only = new TimeOnly(15, 22);

            (int age, bool hadBday) Age(DateTime birth)
            {
                DateTime now = DateTime.Now;

                var diff = now - birth;

                var age = (int)(diff.TotalDays / 365);
                var hadBday = now.DayOfYear >= birth.DayOfYear;

                return (age, hadBday);
            }
        }


        void den1konec()
        {

            string[] dny = ["pondělí", "úterý", "středa", "čtvrtek",
                "pátek", "sobota", "neděle"];

            (string den, bool vikend) DenVTydnuSlovo(DenVTydnu x)
            {
                bool vikend = (x == DenVTydnu.SOBOTA || x == DenVTydnu.NEDELE);
                string den = dny[(int)x];
                return (den, vikend);
            }

            var zadani = DenVTydnu.NEDELE;
            var vysledek = DenVTydnuSlovo(zadani);
            Console.WriteLine($"{zadani}: {vysledek.den}, vikend:{vysledek.vikend}");

        }
    }
        enum DenVTydnu
        {
            PONDELI,
            UTERY,
            STREDA,
            CTVRTEK,
            PATEK,
            SOBOTA,
            NEDELE
        }
    }


