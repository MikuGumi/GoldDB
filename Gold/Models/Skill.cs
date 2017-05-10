namespace Gold.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Skill : DbContext
    {
        public Skill()
            : base("name=Skill")
        {
            //Database.SetInitializer<Skill>(null);
        }

        public virtual DbSet<AccountBook> AccountBook { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
