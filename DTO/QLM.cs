using System;
using System.Data.Entity;
using System.Linq;

namespace _102190053_LETHIBINH.DTO
{
    public class QLM : DbContext
    {
        // Your context has been configured to use a 'QLM' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // '_102190053_LETHIBINH.QLM' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'QLM' 
        // connection string in the application configuration file.
        public QLM()
            : base("name=QLM")
        {
            Database.SetInitializer(new CreateDB());
        }
        public DbSet<MonAn> MonAns { get; set; }

        public DbSet<NguyenLieu> NguyenLieus { get; set; }
        public DbSet<MonAn_NguyenLieu> MonAn_NguyenLieus { get; set; }
        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}