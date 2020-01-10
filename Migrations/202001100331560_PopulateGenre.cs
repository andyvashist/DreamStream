namespace DreamStream.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenre : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Genres ON");
            Sql("INSERT INTO Genres(Id, Type) VALUES(1,'Comedy')");
            Sql("INSERT INTO Genres(Id, Type) VALUES(2,'Action')");
            Sql("INSERT INTO Genres(Id, Type) VALUES(3,'Romance')");
            Sql("INSERT INTO Genres(Id, Type) VALUES(4,'Thriller')");
        }
        
        public override void Down()
        {
        }
    }
}
