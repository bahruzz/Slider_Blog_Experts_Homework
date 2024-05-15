﻿using Asp.NetIntro_MVC.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Asp.NetIntro_MVC.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options) : base(options) { }

        public DbSet<Slider> Sliders { get; set; }

        public DbSet<SliderInfo> Sliderinfos { get; set; }

        public DbSet<Blog> Blogs { get; set; }

        public DbSet<Expert> Experts { get; set; }





        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Slider>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<Blog>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<Expert>().HasQueryFilter(m => !m.SoftDeleted);

            modelBuilder.Entity<Blog>().HasData(
         new Blog
         {
             Id = 1,
             Title = "Title1",
             Description="Reshadin blogu",
             Image = "blog-feature-img-1.jpg",
             CreatedDate = DateTime.Now
         },
           new Blog
           {
               Id = 2,
               Title = "Title2",
               Description = "Ilqarin blogu",
               Image = "blog-feature-img-3.jpg",
               CreatedDate = DateTime.Now
           },
             new Blog
             {
                 Id = 3,
                 Title = "Title3",
                 Description = "Hacixanin blogu",
                 Image = "blog-feature-img-4.jpg",
                 CreatedDate = DateTime.Now
             }
         );


        }


    }
}
