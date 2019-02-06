namespace CadastroFamilia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrationTeste : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Filhoes", "Nome", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Filhoes", "Nome");
        }
    }
}
