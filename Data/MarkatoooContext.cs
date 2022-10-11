using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace BloodBank.Data
{
    public partial class BloodBankContext : DbContext
    {
        public BloodBankContext()
        {
        }

        public BloodBankContext(DbContextOptions<BloodBankContext> options)
            : base(options)
        {
        }
       

        //public virtual DbSet<PaymentGetway> PaymentGetways { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
