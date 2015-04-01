using System.Data.Entity;

namespace EntityCodeFirstInheritance
{
    public class EDataContext : DbContext
    {
        public EDataContext() : base("MyConnetionString")
        {
        }

        // Code for Table Per Type
        //public IDbSet<Customer> Customers { get; set; }
        //public IDbSet<Employee> Employees { get; set; }

        ////Code for Table Per Hierarchay
        //public IDbSet<Customer> Customers { get; set; }
        //public IDbSet<Employee> Employees { get; set; }
        //public IDbSet<Person> Persons { get; set; }

        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().ToTable("Employee");
            base.OnModelCreating(modelBuilder);
        }
    }
}