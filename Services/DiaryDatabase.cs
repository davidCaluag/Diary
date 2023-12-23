using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Diary.Models;

namespace Diary.Services
{
    public class DiaryDatabase : DbContext
    {
    
        public DbSet<DiaryModel> Diaries {get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("FileName=DiaryDatabase.db");
            //base.OnConfiguring(optionsBuilder);
        }
    }
}