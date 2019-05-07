namespace DDDImovel.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Imovels",
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
                "dbo.People",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name_FirstName = c.String(),
                        Name_LastName = c.String(),
                        Email_MailAddress = c.String(),
                        Telefone = c.String(),
                        Cpf = c.String(),
                        TipoPessoa = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Vendas",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        DataVenda = c.DateTime(nullable: false),
                        Cliente_Id = c.Guid(),
                        Imovel_Id = c.Guid(),
                        Vendedor_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.People", t => t.Cliente_Id)
                .ForeignKey("dbo.Imovels", t => t.Imovel_Id)
                .ForeignKey("dbo.People", t => t.Vendedor_Id)
                .Index(t => t.Cliente_Id)
                .Index(t => t.Imovel_Id)
                .Index(t => t.Vendedor_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Vendas", "Vendedor_Id", "dbo.People");
            DropForeignKey("dbo.Vendas", "Imovel_Id", "dbo.Imovels");
            DropForeignKey("dbo.Vendas", "Cliente_Id", "dbo.People");
            DropIndex("dbo.Vendas", new[] { "Vendedor_Id" });
            DropIndex("dbo.Vendas", new[] { "Imovel_Id" });
            DropIndex("dbo.Vendas", new[] { "Cliente_Id" });
            DropTable("dbo.Vendas");
            DropTable("dbo.People");
            DropTable("dbo.Imovels");
        }
    }
}
