namespace NoduriNomenclatoare.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedNoteCountry : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NomCities",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        CityType = c.Int(nullable: false),
                        District = c.String(),
                        Code = c.String(),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            AddColumn("dbo.NomCountries", "Note", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.NomCountries", "Note");
            DropTable("dbo.NomCities");
        }
    }
}
