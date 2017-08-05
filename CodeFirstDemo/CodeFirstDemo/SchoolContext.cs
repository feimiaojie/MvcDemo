﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDemo
{
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base()
        {
            // this.Database.Initialize(true);
        }
        public DbSet<Student> Students { get; set; }

        public DbSet<Standard> Standards { get; set; }
    }
}
