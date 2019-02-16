namespace DataBase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateIngressosDB : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Usuario", "Endereco", c => c.String(nullable: false, maxLength: 150));
            AlterColumn("dbo.Usuario", "Nome", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Usuario", "CPF", c => c.String(nullable: false, maxLength: 11));
            AlterColumn("dbo.Usuario", "BairroEndereco", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Usuario", "CidadeEndereco", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Usuario", "CEPEndereco", c => c.String(nullable: false, maxLength: 9));
            AlterColumn("dbo.Usuario", "Email", c => c.String(nullable: false, maxLength: 100));
            DropColumn("dbo.Usuario", "LogradouroEndereco");
            DropColumn("dbo.Usuario", "NumeroEndereco");
            DropColumn("dbo.Usuario", "ComplementoEndereco");
            DropColumn("dbo.Usuario", "tipoUsuario");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Usuario", "tipoUsuario", c => c.Int(nullable: false));
            AddColumn("dbo.Usuario", "ComplementoEndereco", c => c.String());
            AddColumn("dbo.Usuario", "NumeroEndereco", c => c.Int(nullable: false));
            AddColumn("dbo.Usuario", "LogradouroEndereco", c => c.String(nullable: false));
            AlterColumn("dbo.Usuario", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Usuario", "CEPEndereco", c => c.String(nullable: false));
            AlterColumn("dbo.Usuario", "CidadeEndereco", c => c.String(nullable: false));
            AlterColumn("dbo.Usuario", "BairroEndereco", c => c.String(nullable: false));
            AlterColumn("dbo.Usuario", "CPF", c => c.String(nullable: false));
            AlterColumn("dbo.Usuario", "Nome", c => c.String(nullable: false));
            DropColumn("dbo.Usuario", "Endereco");
        }
    }
}
