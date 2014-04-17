namespace NoduriNomenclatoare.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeCountryName : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.NomCountries", name: "Name", newName: "CountryName");
        }
        
        public override void Down()
        {
            RenameColumn(table: "dbo.NomCountries", name: "CountryName", newName: "Name");
        }
    }
}
