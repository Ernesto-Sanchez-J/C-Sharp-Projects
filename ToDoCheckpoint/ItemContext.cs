﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.IO;

namespace ToDoCheckpoint
{
    class ItemContext : DbContext
    {
        public DbSet<ItemRepository> entries { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            DirectoryInfo ExecutionDirectory = new DirectoryInfo(AppContext.BaseDirectory);
            DirectoryInfo ProjectBase = ExecutionDirectory.Parent.Parent.Parent;
            String DatabaseFile = Path.Combine(ProjectBase.FullName, "entries.db");
            optionsBuilder.UseSqlite("Data Source=" + DatabaseFile);
        }
    }
}