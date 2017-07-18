namespace EfTUtorial.Database
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Notes",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Message = c.String(nullable: false, maxLength: 2000),
                        Timestamp = c.DateTime(nullable: false),
                        Author = c.String(nullable: false, maxLength: 2000),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Adendums",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        AdendumContent = c.String(nullable: false, maxLength: 2000),
                        NoteId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Notes", t => t.NoteId, cascadeDelete: true)
                .Index(t => t.NoteId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Adendums", "NoteId", "dbo.Notes");
            DropIndex("dbo.Adendums", new[] { "NoteId" });
            DropTable("dbo.Adendums");
            DropTable("dbo.Notes");
        }
    }
}
