namespace DDDImovel.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Comprador",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name_FirstName = c.String(nullable: false, maxLength: 40),
                        Name_LastName = c.String(maxLength: 40),
                        Cpf = c.String(nullable: false, maxLength: 11, fixedLength: true),
                        Email_MailAddress = c.String(maxLength: 60),
                        Telefone = c.String(maxLength: 14),
                        TipoPessoa = c.String(maxLength: 10),
                    })
                .PrimaryKey(t => t.Id);
            
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
                "dbo.Vendas",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        DataVenda = c.DateTime(nullable: false),
                        Valor = c.Int(nullable: false),
                        Comprador_Id = c.Guid(nullable: false),
                        Imovel_Id = c.Guid(nullable: false),
                        Vendedor_Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Comprador", t => t.Comprador_Id, cascadeDelete: false)
                .ForeignKey("dbo.Imovel", t => t.Imovel_Id, cascadeDelete: false)
                .ForeignKey("dbo.Vendedor", t => t.Vendedor_Id, cascadeDelete: false)
                .Index(t => t.Comprador_Id)
                .Index(t => t.Imovel_Id)
                .Index(t => t.Vendedor_Id);
            
            CreateTable(
                "dbo.Vendedor",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name_FirstName = c.String(nullable: false, maxLength: 40),
                        Name_LastName = c.String(maxLength: 40),
                        Cpf = c.String(nullable: false, maxLength: 11, fixedLength: true),
                        Email_MailAddress = c.String(maxLength: 60),
                        Telefone = c.String(maxLength: 14),
                        TipoPessoa = c.String(maxLength: 10),
                        Creci = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Vendas", "Vendedor_Id", "dbo.Vendedor");
            DropForeignKey("dbo.Vendas", "Imovel_Id", "dbo.Imovel");
            DropForeignKey("dbo.Vendas", "Comprador_Id", "dbo.Comprador");
            DropIndex("dbo.Vendas", new[] { "Vendedor_Id" });
            DropIndex("dbo.Vendas", new[] { "Imovel_Id" });
            DropIndex("dbo.Vendas", new[] { "Comprador_Id" });
            DropTable("dbo.Vendedor");
            DropTable("dbo.Vendas");
            DropTable("dbo.Imovel");
            DropTable("dbo.Comprador");
        }
    }
}
