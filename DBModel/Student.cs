﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBModel
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int GroupId { get; set; }

        [ForeignKey("GroupId")]
        protected virtual Group Group { get; set; }

        public Student() { }

        public Student(string name, string surname, int age, int groupId)
        {
            FirstName = name;
            LastName = surname;
            Age = age;
            GroupId = groupId;
        }
    }
}
