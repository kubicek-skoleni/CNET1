// třídu Student
// jméno
// datum narození
// pohlaví
// třida
// info do konzolep

using ConsoleApp.Model;

Student stud1 = new ();

//stud1.Name = "Jan Novák";
stud1.BirthDate = new DateOnly(2012, 3, 15);
stud1.ClassName = GradeName._7A;
stud1.Gender = Gender.MALE;

stud1.PrintInfo();