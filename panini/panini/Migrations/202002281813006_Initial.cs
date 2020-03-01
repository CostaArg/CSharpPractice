namespace panini.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sandwiches",
                c => new
                    {
                        IdNumber = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        Cost = c.Double(nullable: false),
                        Cuisine = c.String(maxLength: 50),
                        Ingredients = c.Int(nullable: false),
                        PhotoUrl = c.String(),
                        IsToasted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.IdNumber);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Sandwiches");
        }
    }
}
