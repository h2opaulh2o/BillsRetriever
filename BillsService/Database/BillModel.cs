namespace Database
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BillModel : DbContext
    {
        public BillModel()
            : base("name=BillModel")
        {
        }

        public virtual DbSet<Bill> Bills { get; set; }
        public virtual DbSet<BillProvider> BillProviders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BillProvider>()
                .HasMany(e => e.Bills)
                .WithRequired(e => e.BillProvider)
                .HasForeignKey(e => e.ProviderId)
                .WillCascadeOnDelete(false);
        }
    }
}
