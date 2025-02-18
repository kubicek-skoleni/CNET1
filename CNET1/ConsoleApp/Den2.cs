using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Den2
    {
        void Exceptions()
        {
            string[] dny = ["pondělí", "úterý", "středa", "čtvrtek",
                "pátek", "sobota", "neděle"];
            string DenVTydnu(int x)
            {
                if (x < 0 || x > 6)
                    throw new IndexOutOfRangeException();

                return dny[x - 1];
            }

            try
            {
                var den = DenVTydnu(8);
                Console.WriteLine($"den: {den}");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("index mimo rozsah pole");
            }
            catch (Exception ex)
            {
                Console.WriteLine("nastala chyba");
            }
            finally
            {
                Console.WriteLine("toto se provede vždy");
            }
        }
    }
}
