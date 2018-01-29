using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom {
    class Program {
        static void Main(string[] args) {
            DateTime classStart = new DateTime(2017, 8, 28, 9, 10, 0); //year, month, day, hours, minutes, seconds
            Classroom newClass = new Classroom("3A", classStart);

            newClass.ClassList.Add(new Student("Me", 7, 3));
            newClass.ClassList.Add(new Student("Gordon", 12, 24));

            Console.WriteLine("Class information:");
            Console.WriteLine($"Class {newClass.ClassName} from {newClass.SemesterStart}");
            Console.WriteLine("Students:");
            foreach(Student s in newClass.ClassList) {
                Console.WriteLine($"{s.Name} born {s.BirthMonth}-{s.BirthDay} (birthday in {s.BirthSeason()})");
            }
            Console.WriteLine("Class output completed.");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
