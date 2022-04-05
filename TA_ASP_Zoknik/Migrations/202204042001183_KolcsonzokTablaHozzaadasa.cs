namespace TA_ASP_Zoknik.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class KolcsonzokTablaHozzaadasa : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kolcsonzok",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nev = c.String(),
                        Email = c.String(),
                        NoKolcsonzes = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Kolcsonzok");
        }
    }
}
