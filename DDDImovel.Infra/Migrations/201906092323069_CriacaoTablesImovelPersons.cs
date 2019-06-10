namespace DDDImovel.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CriacaoTablesImovelPersons : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Imovel",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Title = c.String(),
                        Description = c.String(),
                        Address_Cep = c.String(),
                        Address_Endereco = c.String(),
                        Address_Numero = c.String(),
                        Address_Complemento = c.String(),
                        Address_Bairro = c.String(),
                        Address_Cidade = c.String(),
                        Address_Estado = c.String(),
                        Address_Latitude = c.String(),
                        Address_Longitude = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Person",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name_FirstName = c.String(nullable: false, maxLength: 40),
                        Name_LastName = c.String(maxLength: 40),
                        Email_MailAddress = c.String(maxLength: 60),
                        Telefone = c.String(maxLength: 14),
                        Cpf = c.String(nullable: false, maxLength: 11, fixedLength: true),
                        TipoPessoa = c.String(maxLength: 10),
                        Creci = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Person");
            DropTable("dbo.Imovel");
        }
    }
}
