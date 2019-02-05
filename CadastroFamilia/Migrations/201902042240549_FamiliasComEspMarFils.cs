namespace CadastroFamilia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FamiliasComEspMarFils : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Familias", "Esposa_Id", c => c.Int());
            AddColumn("dbo.Familias", "Marido_Id", c => c.Int());
            CreateIndex("dbo.Familias", "Esposa_Id");
            CreateIndex("dbo.Familias", "Marido_Id");
            CreateIndex("dbo.Filhos", "FamiliaId");
            AddForeignKey("dbo.Familias", "Esposa_Id", "dbo.Esposas", "Id");
            AddForeignKey("dbo.Filhos", "FamiliaId", "dbo.Familias", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Familias", "Marido_Id", "dbo.Maridos", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Familias", "Marido_Id", "dbo.Maridos");
            DropForeignKey("dbo.Filhos", "FamiliaId", "dbo.Familias");
            DropForeignKey("dbo.Familias", "Esposa_Id", "dbo.Esposas");
            DropIndex("dbo.Filhos", new[] { "FamiliaId" });
            DropIndex("dbo.Familias", new[] { "Marido_Id" });
            DropIndex("dbo.Familias", new[] { "Esposa_Id" });
            DropColumn("dbo.Familias", "Marido_Id");
            DropColumn("dbo.Familias", "Esposa_Id");
        }
    }
}
