using CarRental;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    // třídu pro osobu - Person
    // jméno
    // doklad číslo
    // doklad typ
    // datum narození
    // telefon
    // email

    class Person
    {
        public string Name { get; set; } = string.Empty;

        public string DocumentNumber { get; set; }

        public DocumentType Document { get; set; }

        public DateOnly DateOfBirth { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public Car RentedCar { get; set; }
    }

    enum DocumentType
    {
        ID,
        PASSPORT,
        OTHER
    }
}
