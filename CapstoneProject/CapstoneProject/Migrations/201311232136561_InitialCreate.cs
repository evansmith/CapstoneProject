namespace CapstoneProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sounds",
                c => new
                    {
                        SoundID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Location = c.String(),
                        Time = c.String(),
                        Genre = c.String(),
                    })
                .PrimaryKey(t => t.SoundID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Sounds");
        }
    }
}
