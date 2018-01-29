using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom {
    public class Classroom {
        private string _className;
        private List<Student> _students;
        private DateTime _semesterStart;

        public Classroom(string className, DateTime semesterStart) {
            _className = className;
            _semesterStart = semesterStart;
            _students = new List<Student>();
        }

        public string ClassName {
            get { return _className; }
            set { _className = value; }
        }
        public List<Student> ClassList {
            get { return _students; }
            set { _students = value; }
        }
        public DateTime SemesterStart {
            get { return _semesterStart; }
            set { _semesterStart = value; }
        }

        //implements LINQ
        public void CountBirthdaysInSeasons() {
            int winterBirthdays = 0;
            int springBirthdays = 0;
            int summerBirthdays = 0;
            int autumnBirthdays = 0;
            //two ways of counting
            //this way is long and slow, but easy to read (goes through list 4 times):
            /*
            Console.Write("Students with a birthday in winter: ");
            foreach(Student s in _students) {
                if(s.BirthMonth == 12 || s.BirthMonth == 1 || s.BirthMonth == 2) {
                    winterBirthdays++;
                }
            }
            Console.WriteLine(winterBirthdays);
            Console.Write("Students with a birthday in spring: ");
            foreach (Student s in _students) {
                if (s.BirthMonth == 3 || s.BirthMonth == 4 || s.BirthMonth == 5) {
                    springBirthdays++;
                }
            }
            Console.WriteLine(springBirthdays);
            Console.Write("Students with a birthday in summer: ");
            foreach (Student s in _students) {
                if (s.BirthMonth == 6 || s.BirthMonth == 7 || s.BirthMonth == 8) {
                    summerBirthdays++;
                }
            }
            Console.WriteLine(summerBirthdays);
            Console.Write("Students with a birthday in autumn: ");
            foreach (Student s in _students) {
                if (s.BirthMonth == 9 || s.BirthMonth == 10 || s.BirthMonth == 11) {
                    autumnBirthdays++;
                }
            }
            Console.WriteLine(autumnBirthdays);
            */

            //this way is shorter and the fastest of the three methods, but doesn't read as well (only goes through list once):
            foreach(Student s in _students) {
                if(s.BirthMonth / 3 == 0 || s.BirthMonth / 3 == 4) {
                    winterBirthdays++;
                } else if(s.BirthMonth / 3 == 1) {
                    springBirthdays++;
                } else if(s.BirthMonth / 3 == 2) {
                    summerBirthdays++;
                } else {
                    autumnBirthdays++;
                }
            }
            Console.WriteLine("Students with a birthday in winter: " + winterBirthdays);
            Console.WriteLine("Students with a birthday in spring: " + springBirthdays);
            Console.WriteLine("Students with a birthday in summer: " + summerBirthdays);
            Console.WriteLine("Students with a birthday in autumn: " + autumnBirthdays);

            /*
            //this way implements Student.BirthSeason() and does some weird counting with LINQ, wouldn't recommend. also really slow comparatively
            List<string> studentReportedSeasons = new List<string>();
            foreach(Student s in _students) {
                studentReportedSeasons.Add(s.BirthSeason());
            }
            var sorted = studentReportedSeasons.GroupBy(s => s); //weird dictionary contained in single-variable collection (as opposed to a grouped collection)
            foreach(var group in sorted) {
                Console.WriteLine($"{group.Key}: {group.Count()}");
            }
            */
        }
    }
}
