// třídu Student
// jméno
// datum narození
// pohlaví
// třida
// info do konzole

using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp.Model
{
    public class Student
    {
        public Student() { }

        public Student(string _name, DateOnly _birthDate, Gender _gender, GradeName _grade)
        {
            Name = _name;
            BirthDate = _birthDate;
            Gender = _gender;
            ClassName = _grade;
        }
        public string Name { get; set; } = "";
        public DateOnly BirthDate { get; set; } = new DateOnly(2000, 1, 1);

        public Gender Gender { get; set; }

        public GradeName ClassName { get; set; }

        public void PrintInfo()
        {
            Console.WriteLine($"{Name} ({BirthDate.ToString("dd. MM. yyyy")}) {GetGradeName()}");
        }

        public string GetGradeName()
        {
            return ClassName.ToString().Replace("_", "").Insert(1, ".");
        }
    }

    public enum GradeName
    {
        _1A,
        _1B,
        _2A,
        _2B,
        _3A,
        _3B,
        _4A,
        _4B,
        _5A,
        _5B,
        _6A,
        _6B,
        _7A,
        _7B,
        _8A,
        _8B,
        _9A,
        _9B,
    }
}
