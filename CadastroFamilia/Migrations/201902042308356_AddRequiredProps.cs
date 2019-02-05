namespace CadastroFamilia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRequiredProps : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Esposas", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Esposas", "Nome", c => c.String(nullable: false));
            AlterColumn("dbo.Maridos", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Maridos", "Nome", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Maridos", "Nome", c => c.String());
            AlterColumn("dbo.Maridos", "Email", c => c.String());
            AlterColumn("dbo.Esposas", "Nome", c => c.String());
            AlterColumn("dbo.Esposas", "Email", c => c.String());
        }
    }
}
