namespace DDDImovel.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CriacaoTablesVendas : DbMigration
    {
        public override void Up()
        {
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
                .ForeignKey("dbo.Person", t => t.Comprador_Id, cascadeDelete: false)
                .ForeignKey("dbo.Imovel", t => t.Imovel_Id, cascadeDelete: false)
                .ForeignKey("dbo.Person", t => t.Vendedor_Id, cascadeDelete: false)
                .Index(t => t.Comprador_Id)
                .Index(t => t.Imovel_Id)
                .Index(t => t.Vendedor_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Vendas", "Vendedor_Id", "dbo.Person");
            DropForeignKey("dbo.Vendas", "Imovel_Id", "dbo.Imovel");
            DropForeignKey("dbo.Vendas", "Comprador_Id", "dbo.Person");
            DropIndex("dbo.Vendas", new[] { "Vendedor_Id" });
            DropIndex("dbo.Vendas", new[] { "Imovel_Id" });
            DropIndex("dbo.Vendas", new[] { "Comprador_Id" });
            DropTable("dbo.Vendas");
        }
    }
}
