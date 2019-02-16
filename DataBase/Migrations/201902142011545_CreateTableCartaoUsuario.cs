namespace DataBase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTableCartaoUsuario : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CartaoUsuario",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdUsuario = c.Int(nullable: false),
                        NumeroCartao = c.String(nullable: false),
                        NomeImpressoCartao = c.String(nullable: false),
                        ValidadeCartao = c.String(nullable: false),
                        CVVCartao = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CartaoUsuario");
        }
    }
}
