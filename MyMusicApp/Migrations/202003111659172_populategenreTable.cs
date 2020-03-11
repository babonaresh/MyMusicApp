namespace MyMusicApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populategenreTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (ID,name) VALUES(1,'Jazz')");
            Sql("INSERT INTO Genres (ID,name) VALUES(2,'blues')");
            Sql("INSERT INTO Genres (ID,name) VALUES(3,'Rock')");
            Sql("INSERT INTO Genres (ID,name) VALUES(4,'Country')");

        }
        
        public override void Down()
        {
            Sql("DELETE FROm Genres Where ID In(1,2,3,4)");
        }
    }
}
