namespace InnovasysVatCheck.Data
{
    using System.Data.Entity;

    public partial class InnovasysVatContext : DbContext
    {
        public InnovasysVatContext()
            : base("name=InnovasysVatContext")
        {
        }

        public virtual DbSet<Vat> Vats { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vat>()
                .Property(e => e.VatNumber)
                .IsFixedLength();
        }
    }
}
