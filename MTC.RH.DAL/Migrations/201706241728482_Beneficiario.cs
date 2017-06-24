namespace MTC.RH.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Beneficiario : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Beneficios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.FuncionarioBeneficios",
                c => new
                    {
                        Funcionario_Id = c.Int(nullable: false),
                        Beneficio_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Funcionario_Id, t.Beneficio_Id })
                .ForeignKey("dbo.Funcionarios", t => t.Funcionario_Id, cascadeDelete: true)
                .ForeignKey("dbo.Beneficios", t => t.Beneficio_Id, cascadeDelete: true)
                .Index(t => t.Funcionario_Id)
                .Index(t => t.Beneficio_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FuncionarioBeneficios", "Beneficio_Id", "dbo.Beneficios");
            DropForeignKey("dbo.FuncionarioBeneficios", "Funcionario_Id", "dbo.Funcionarios");
            DropIndex("dbo.FuncionarioBeneficios", new[] { "Beneficio_Id" });
            DropIndex("dbo.FuncionarioBeneficios", new[] { "Funcionario_Id" });
            DropTable("dbo.FuncionarioBeneficios");
            DropTable("dbo.Beneficios");
        }
    }
}
