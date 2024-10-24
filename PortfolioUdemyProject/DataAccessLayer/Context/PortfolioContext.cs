﻿using Microsoft.EntityFrameworkCore;
using PortfolioUdemyProject.DataAccessLayer.Entities;

namespace PortfolioUdemyProject.DataAccessLayer.Context
{
    public class PortfolioContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=MELIH;initial Catalog=MyPortfolioDb;integrated Security=true;TrustServerCertificate=True");
        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Contact> ContactS { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<ToDoList> ToDoLists { get; set; }
    }
}
