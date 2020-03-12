namespace MyMusicApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    
    public partial class populatedata : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres(ID,Name) VALUES(1,'Jazz')");
            Sql("INSERT INTO Genres(ID,Name) VALUES(2,'Rock')");
            Sql("INSERT INTO Genres(ID,Name) VALUES(3,'Contry')");
            Sql("INSERT INTO Genres(ID,Name) VALUES(4,'Blues')");
        }
        
        public override void Down()
        {
            Sql("DELETE from Genres WHERE Id IN (1,2,3,4)");
        }
    }
}
