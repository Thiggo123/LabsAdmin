namespace Labs.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class B : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Computers", "VelocidadeCPU", c => c.String(maxLength: 8000, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Computers", "VelocidadeCPU", c => c.Single(nullable: false));
        }
    }
}
