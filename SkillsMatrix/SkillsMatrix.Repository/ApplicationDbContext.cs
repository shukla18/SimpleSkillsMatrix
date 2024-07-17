﻿using Microsoft.EntityFrameworkCore;
using SkillsMatrix.Models;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    //public DbSet<User> Users { get; set; }
    public DbSet<Category> Categories { get; set; }
    //public DbSet<Skill> Skills { get; set; }
}
