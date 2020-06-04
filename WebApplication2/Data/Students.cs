using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.Models;

namespace WebApplication2.Data
{
    public class Students
    {
        public IList<Student> StudentsList { get; private set; }

        public Students()
        {
            StudentsList = new List<Student>()
            {
                new Student() {Id = 1, Name = "Student 1", Mark = 4},
                new Student() {Id = 2, Name = "Student 2", Mark = 4},
                new Student() {Id = 3, Name = "Student 3", Mark = 2},
                new Student() {Id = 4, Name = "Student 4", Mark = 3},
                new Student() {Id = 5, Name = "Student 5", Mark = 5}
            };
        }
    }
}