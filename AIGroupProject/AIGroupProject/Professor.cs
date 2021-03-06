﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AIGroupProject
{
    public class Professor
    {
        private int ID;
        private string Name;
        private List<Course> Classes;


        public Professor(string name, int id)
        {
            Name = name;
            ID = id;
            Classes = new List<Course>();
        }

        public void AddCourse(Course course)
        {
            Classes.Add(course);
        }

        public List<Course> GetCourses()
        {
            return Classes;
        }

        public string getName()
        {
            return Name;
        }

        public int getID()
        {
            return ID;
        }
    }
}
