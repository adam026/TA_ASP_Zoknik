namespace TA_ASP_Zoknik.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedKolcsonzok : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Kolcsonzok (Nev, Email, NoKolcsonzes) VALUES ('Beviz Elek','elekvok@citromail.hu',7)");
            Sql("INSERT INTO Kolcsonzok (Nev, Email, NoKolcsonzes) VALUES ('Para Zita','peezee@freemail.hu',104)");
            Sql("INSERT INTO Kolcsonzok (Nev, Email, NoKolcsonzes) VALUES ('Ultra Viola','ultrav@gerillamail.com',9)");
        }

        public override void Down()
        {
        }
    }
}
