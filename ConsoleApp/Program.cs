using ConsoleApp.Model;
using System.Text.Json;


var stud1 = new Student()
{
    Name = "Jan Novák",
    BirthDate = new DateOnly(2005, 10, 5),
    Gender = Gender.MALE,
    ClassName = GradeName._9A,
};

var stud2 = new Student("Petr Svoboda",
                new DateOnly(2004, 3, 15),
                Gender.MALE,
                GradeName._9B);


//var json_student = JsonSerializer.Serialize<Student>(stud1);
//File.WriteAllText("student.json", json_student);

var file_content = File.ReadAllText("student.json");
Student student_from_file = JsonSerializer
    .Deserialize<Student>(file_content);

List<Student> students = new List<Student>();

// LINQ  
students.Where(x => x.ClassName == GradeName._9A)
    .Select(x => x.Name)
    .ToList();
