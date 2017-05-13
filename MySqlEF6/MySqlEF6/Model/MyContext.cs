using MySql.Data.Entity;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MySqlEF6.Model
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class MyContext : DbContext
    {
        public MyContext() : base("Server=192.168.1.14;port=3306;Database=EFComics;uid=barakis;Pwd=Matthew47!")
        {
            Database.SetInitializer(new MyDbInitializer());   
        }

        public MyContext(DbConnection existingConnection, bool contextOwnConnection)
            : base(existingConnection, contextOwnConnection)
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();
            modelBuilder.Entity<Titles>()
                .HasRequired<Publisher>(p => p.Publisher).WithMany(t => t.Titles);

        }

        public DbSet<Publisher> Pub { get; set; }
        public DbSet<Titles> Titles { get; set; }
    }
}
