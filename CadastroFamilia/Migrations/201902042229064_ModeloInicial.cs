namespace CadastroFamilia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModeloInicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Esposas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FamiliaId = c.Int(nullable: false),
                        Email = c.String(),
                        Nome = c.String(),
                        Nascimento = c.DateTime(nullable: false),
                        Altura = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Familias",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Filhos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FamiliaId = c.Int(nullable: false),
                        Nascimento = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Maridos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FamiliaId = c.Int(nullable: false),
                        Email = c.String(),
                        Nome = c.String(),
                        Nascimento = c.DateTime(nullable: false),
                        Altura = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Maridos");
            DropTable("dbo.Filhos");
            DropTable("dbo.Familias");
            DropTable("dbo.Esposas");
        }
    }
}
