using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AIGroupProject
{
    public class Course
    {
        int courseID;
        string theCourse;
        int maxStudents = 10;

        public Course(string name, int ID)
        {
            theCourse = name;
            courseID = ID;
        }
    }
}
