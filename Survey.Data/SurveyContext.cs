﻿using Microsoft.EntityFrameworkCore;
using Survey.Domain.Entities;

namespace Survey.Data
{
    public class SurveyContext : DbContext
    {
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<QuestionEntity> Questions { get; set; }
        public DbSet<UserProgressEntity> UserProgress { get; set; }

        public SurveyContext() { }
        public SurveyContext(DbContextOptions<SurveyContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL("");
            }
        }
    }
}
