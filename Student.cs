﻿// See https://aka.ms/new-console-template for more information
using System;

namespace USFLibraryManagementSystem
{
    public class Student : Person
    {
        public string Major { get; set; }
        public int GraduationYear { get; set; }

        public Student(string name, string email, string id, string major, int graduationYear)
            : base(name, email, id)
        {
            Major = major;
            GraduationYear = graduationYear;
        }
    }
}

