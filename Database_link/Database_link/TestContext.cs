using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_link
{
    public class TestContext : DbContext
    {
        private static TestContext tc = null;
        // public DbSet<Error> Errors { get; set; }
      //  public DbSet<Task> List_Obj_Task { get; set; }
       // public DbSet<Audit> Audits { get; set; }
       private TestContext() { }
      public static TestContext GetInstance()
        {

            if (tc == null)
                tc = new TestContext();

            return tc;
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<System.Data.Entity.ModelConfiguration.Conventions.PluralizingTableNameConvention>();

            modelBuilder.Entity<ServiceTypes>()
             .HasMany<ServiceParameters>(s => s.List_Obj_ServiceParameters)
             .WithMany(c => c.List_Obj_ServiceType)
             .Map(cs =>
             {
                 cs.MapLeftKey("idservice");
                 cs.MapRightKey("idparam");
                 cs.ToTable("tbServiceTypesParams");
             });

            modelBuilder.Entity<Task>()
                .HasMany<Value>(s => s.List_Obj_Values)
                .WithMany(c => c.List_Obj_Tasks)
                .Map(cs =>
                {
                    cs.MapLeftKey("idtask");
                    cs.MapRightKey("idvalue");
                    cs.ToTable("tbConfigs");
                });
        }
    }
}
