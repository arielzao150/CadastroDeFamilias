namespace CadastroFamilia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LimitNomes : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Esposas", "Nome", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Maridoes", "Nome", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Maridoes", "Nome", c => c.String(nullable: false));
            AlterColumn("dbo.Esposas", "Nome", c => c.String(nullable: false));
        }
    }
}
