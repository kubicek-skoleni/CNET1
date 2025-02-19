using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental
{
    /// <summary>
    /// Autopůjčovna - místo kde půjčujeme auta
    /// </summary>
    class CarDealer
    {
        //public CarDealer()
        //{
        //    //inicializace prázdného listu
        //    CarsForRent = new List<Car>();
        //}
        public string Adress { get; set; } = "Sochorova 1";

        public string Name { get; set; } = "Půjčovna";

        /// <summary>
        /// Auta k půjčení v této provozovně
        /// </summary>
        public List<Car> CarsForRent { get; set; } = new List<Car>();

        public override string ToString()
        {
            return $"{Name} ({CarsForRent.Count()})";
        }
    }
}
