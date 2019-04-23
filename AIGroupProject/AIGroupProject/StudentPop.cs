using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AIGroupProject
{
    class StudentPop
    {
        //our number of students in the population
        private int numStudents;

        //List of classes that the population attends
        private List<Courses> courses;


        public StudentPop(int numberOfStudents)
        {
            numStudents = numberOfStudents;
        }

        public void AddClass(Courses course)
        {
            courses.Add(course);
        }

        public int getNumStudents()
        {
            return numStudents;
        }

        public List<Courses> getCourses()
        {
            return courses;
        }   
    }
}
