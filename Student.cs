﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
     class Student
    {
       
        public int Id { get; set; }
        public string Name { get; set; }
        public string Faculty { get; set; }
        public int Age {  get; set; }
        public string Technology {  get; set; } 

        public Student(int id ,string name ,string faculty, int age,string tech) 
        { 
            Id = id;
            Name = name;
            Faculty = faculty;
            Age = age;
            Technology = tech;
        }

        



    }
}
