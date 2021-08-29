using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TesislerDairesi.Models;

namespace TesislerDairesi.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<TesislerDairesi.Models.Joke> Joke { get; set; }
        public DbSet<TesislerDairesi.Models.ProductModel> ProductModel { get; set; }
        public DbSet<TesislerDairesi.Models.PersonelModel> PersonelModel { get; set; }
        public DbSet<TesislerDairesi.Models.AirsModel> AirsModel { get; set; }
        public DbSet<TesislerDairesi.Models.CustomerModel> CustomerModel { get; set; }
    }
}
