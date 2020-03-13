namespace MyMusicApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingAttendance1 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Attendances", new[] { "GIgId" });
            CreateIndex("dbo.Attendances", "GigId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Attendances", new[] { "GigId" });
            CreateIndex("dbo.Attendances", "GIgId");
        }
    }
}
