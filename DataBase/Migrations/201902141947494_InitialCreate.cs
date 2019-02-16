namespace DataBase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Evento",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TituloEvento = c.String(nullable: false),
                        DescricaoEvento = c.String(nullable: false),
                        DataHoraEvento = c.DateTime(nullable: false),
                        TotalIngressos = c.Int(nullable: false),
                        TotalVendidos = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        CPF = c.String(nullable: false),
                        DataNascimento = c.DateTime(nullable: false),
                        Sexo = c.String(nullable: false, maxLength: 1, fixedLength: true, unicode: false),
                        LogradouroEndereco = c.String(nullable: false),
                        NumeroEndereco = c.Int(nullable: false),
                        ComplementoEndereco = c.String(),
                        BairroEndereco = c.String(nullable: false),
                        CidadeEndereco = c.String(nullable: false),
                        CEPEndereco = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Senha = c.String(nullable: false),
                        tipoUsuario = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Usuario");
            DropTable("dbo.Evento");
        }
    }
}
