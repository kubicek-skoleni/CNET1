// třídu Student
// jméno
// datum narození
// pohlaví
// třida
// info do konzolep

using ConsoleApp.Model;

Student stud1 = new ();

stud1.Name = "Jan Novák";
stud1.BirthDate = new DateOnly(2012, 3, 15);
stud1.ClassName = "7.A";
stud1.Gender = "M";

stud1.PrintInfo();