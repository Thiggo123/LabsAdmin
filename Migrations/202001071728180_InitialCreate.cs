namespace Labs.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Computers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Marca = c.String(maxLength: 8000, unicode: false),
                        Modelo = c.String(maxLength: 8000, unicode: false),
                        PlacaMae = c.String(maxLength: 8000, unicode: false),
                        Memoria = c.String(maxLength: 8000, unicode: false),
                        HD = c.String(maxLength: 8000, unicode: false),
                        MarcaHD = c.String(maxLength: 8000, unicode: false),
                        VelocidadeCPU = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Computers");
        }
    }
}
