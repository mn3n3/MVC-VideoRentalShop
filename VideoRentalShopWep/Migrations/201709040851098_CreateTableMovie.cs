namespace VideoRentalShopWep.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTableMovie : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CategoryID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryID, cascadeDelete: true)
                .Index(t => t.CategoryID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "CategoryID", "dbo.Categories");
            DropIndex("dbo.Movies", new[] { "CategoryID" });
            DropTable("dbo.Movies");
        }
    }
}
