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
        Professor profTeaching;
        public int duration;
        

        public Course(string name, int ID, Professor prof)
        {
            theCourse = name;
            courseID = ID;
            duration = 1;
            profTeaching = prof;
        }

        public bool ProfessorOverlaps(Course c)
        {
            return profTeaching == c.profTeaching;
        }
    }
}
