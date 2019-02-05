namespace CadastroFamilia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RmvFamiliaId : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Filhos", "FamiliaId", "dbo.Familias");
            DropIndex("dbo.Filhos", new[] { "FamiliaId" });
            RenameColumn(table: "dbo.Filhos", name: "FamiliaId", newName: "Familia_Id");
            AlterColumn("dbo.Filhos", "Familia_Id", c => c.Int());
            CreateIndex("dbo.Filhos", "Familia_Id");
            AddForeignKey("dbo.Filhos", "Familia_Id", "dbo.Familias", "Id");
            DropColumn("dbo.Esposas", "FamiliaId");
            DropColumn("dbo.Maridos", "FamiliaId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Maridos", "FamiliaId", c => c.Int(nullable: false));
            AddColumn("dbo.Esposas", "FamiliaId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Filhos", "Familia_Id", "dbo.Familias");
            DropIndex("dbo.Filhos", new[] { "Familia_Id" });
            AlterColumn("dbo.Filhos", "Familia_Id", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.Filhos", name: "Familia_Id", newName: "FamiliaId");
            CreateIndex("dbo.Filhos", "FamiliaId");
            AddForeignKey("dbo.Filhos", "FamiliaId", "dbo.Familias", "Id", cascadeDelete: true);
        }
    }
}
