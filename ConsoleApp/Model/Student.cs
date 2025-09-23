// třídu Student
// jméno
// datum narození
// pohlaví
// třida
// info do konzole

namespace ConsoleApp.Model
{
    public class Student
    {
        public string Name { get; set; }
        public DateOnly BirthDate { get; set; }

        public string Gender { get; set; }

        public string ClassName { get; set; }

        public void PrintInfo()
        {
            Console.WriteLine($"{Name} ({BirthDate.ToString("dd. MM. yyyy")}) {ClassName}");
        }
    }
}
