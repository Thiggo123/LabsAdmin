namespace Labs.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class A : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Computers", "VelocidadeCPU", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Computers", "VelocidadeCPU", c => c.Double(nullable: false));
        }
    }
}
