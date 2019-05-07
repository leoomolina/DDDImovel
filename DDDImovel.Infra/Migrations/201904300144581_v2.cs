namespace DDDImovel.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v2 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.People", newName: "Person");
            AlterColumn("dbo.Person", "Name_FirstName", c => c.String(nullable: false, maxLength: 40));
            AlterColumn("dbo.Person", "Name_LastName", c => c.String(maxLength: 40));
            AlterColumn("dbo.Person", "Email_MailAddress", c => c.String(maxLength: 60));
            AlterColumn("dbo.Person", "Telefone", c => c.String(maxLength: 14));
            AlterColumn("dbo.Person", "Cpf", c => c.String(nullable: false, maxLength: 11, fixedLength: true));
            AlterColumn("dbo.Person", "TipoPessoa", c => c.String(maxLength: 10));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Person", "TipoPessoa", c => c.String());
            AlterColumn("dbo.Person", "Cpf", c => c.String());
            AlterColumn("dbo.Person", "Telefone", c => c.String());
            AlterColumn("dbo.Person", "Email_MailAddress", c => c.String());
            AlterColumn("dbo.Person", "Name_LastName", c => c.String());
            AlterColumn("dbo.Person", "Name_FirstName", c => c.String());
            RenameTable(name: "dbo.Person", newName: "People");
        }
    }
}
