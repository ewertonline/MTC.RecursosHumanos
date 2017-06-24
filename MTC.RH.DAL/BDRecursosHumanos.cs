namespace MTC.RH.DAL
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class BDRecursosHumanos : DbContext
    {
        // Your context has been configured to use a 'BDRecursosHumanos' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'MTC.RH.DAL.BDRecursosHumanos' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'BDRecursosHumanos' 
        // connection string in the application configuration file.
        public BDRecursosHumanos()
            : base("name=BDRecursosHumanos")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Entidades.Funcionario> Funcionarios { get; set; }
        public virtual DbSet<Entidades.Beneficio> Beneficios { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}