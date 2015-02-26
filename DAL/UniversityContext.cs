﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBModel;

namespace DAL
{
    public class UniversityContext : DbContext
    {
        public DbSet<Group> Groups { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<GroupToSubject> GroupsToSubjects { get; set; }

        public UniversityContext()
            : base("EFUniversity")
        {
        }
    }
}
