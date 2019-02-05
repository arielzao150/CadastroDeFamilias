namespace CadastroFamilia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenamingSomeTables : DbMigration
    {
        public override void Up()
        {
            RenameTable("Maridos", "Maridoes");
            RenameTable("Filhos", "Filhoes");
        }
        
        public override void Down()
        {
        }
    }
}
