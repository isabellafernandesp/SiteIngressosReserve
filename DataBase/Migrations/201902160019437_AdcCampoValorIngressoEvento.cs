namespace DataBase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdcCampoValorIngressoEvento : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Evento", "ValorIngresso", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Evento", "ValorIngresso");
        }
    }
}
