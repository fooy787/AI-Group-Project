using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AIGroupProject
{
    class Professor
    {
        private int ID;
        private string Name;
        private List<Courses> Classes;

        public Professor(string name, int id)
        {
            Name = name;
            ID = id;
            Classes = new List<Courses>();
        }

        public void AddCourse(Courses course)
        {
            Classes.Add(course);
        }

        public List<Courses> GetCourses()
        {
            return Classes;
        }
        
    }
}
