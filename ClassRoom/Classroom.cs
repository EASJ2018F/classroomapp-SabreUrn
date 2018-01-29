using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom {
    public class Classroom {
        private string _className;
        private List<Student> _classList;
        private DateTime _semesterStart;

        public Classroom(string className, DateTime semesterStart) {
            _className = className;
            _semesterStart = semesterStart;
            _classList = new List<Student>();
        }

        public string ClassName {
            get { return _className; }
            set { _className = value; }
        }
        public List<Student> ClassList {
            get { return _classList; }
            set { _classList = value; }
        }
        public DateTime SemesterStart {
            get { return _semesterStart; }
            set { _semesterStart = value; }
        }
    }
}
