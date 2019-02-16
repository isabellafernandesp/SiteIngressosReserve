namespace DataBase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CriarTabelaCompraIngressos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CompraIngressos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdUsuario = c.Int(nullable: false),
                        IdEvento = c.Int(nullable: false),
                        IdCartaoUsuario = c.Int(nullable: false),
                        QtdIngressos = c.Int(nullable: false),
                        QtdParcelas = c.Int(nullable: false),
                        ValorTotal = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CompraIngressos");
        }
    }
}
