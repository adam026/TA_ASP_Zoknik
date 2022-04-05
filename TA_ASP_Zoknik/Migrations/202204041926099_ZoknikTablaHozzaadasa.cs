namespace TA_ASP_Zoknik.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ZoknikTablaHozzaadasa : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Zoknik",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Tipus = c.String(),
                        Keszlet = c.Int(nullable: false),
                        Like = c.Int(nullable: false),
                        Dislike = c.Int(nullable: false),
                        Kep = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Zoknik");
        }
    }
}
