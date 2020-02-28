namespace microsoftTutorial.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tapantaola : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 60),
                        ReleaseDate = c.DateTime(nullable: false),
                        Genre = c.String(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Rating = c.String(nullable: false, maxLength: 5),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Movies");
        }
    }
}
