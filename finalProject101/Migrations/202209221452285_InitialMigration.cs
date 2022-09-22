namespace finalProject101.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                {
                    Uid =c.Int(nullable: false, identity: true),
                    Ufname = c.String(nullable: false),
                    Ulname = c.String(nullable: false),
                    Uemail = c.String(nullable: false),
                    Uusername = c.String(nullable: false),
                    Upassword = c.String(nullable: false),
                    flag=c.Int(nullable:false),
                })
                .PrimaryKey(t => t.Uid);
            CreateTable(
    "dbo.Vendors",
    c => new
    {
        Uid = c.Int(nullable: false),
        Vid = c.Int(nullable: false, identity: true),
        Vaddress = c.String(nullable: false),
        Vshopname = c.String(nullable: false),
        Vbanknumber = c.String(nullable: false),

    })
    .PrimaryKey(t => t.Vid)
    .ForeignKey("dbo.Users", t => t.Uid, cascadeDelete: true)
    .Index(t => t.Uid);
       
                    CreateTable(
    "dbo.Products",
    c => new
    {
        Vid = c.Int(nullable: false),
        Pid = c.Int(nullable: false, identity: true),
        Pname = c.String(nullable: false),
        Pyear=c.Int(nullable: false),
        Pmodel= c.String(nullable: false),
        Pdescription = c.String(nullable: false),
        Pprice=c.Double(nullable: false),
        Pimage= c.String(nullable: false),
        PnoOfItem = c.Int(nullable: false),
        Prating = c.Int(nullable: false),

        Vaddress = c.String(nullable: false),
        Vshopname = c.String(nullable: false),
        Vbanknumber = c.String(nullable: false),

    })
    .PrimaryKey(t => t.Vid)
    .ForeignKey("dbo.Vendors", t => t.Vid, cascadeDelete: true)
    .Index(t => t.Vid);
        
        
        }
        


        public override void Down()
        {
            DropForeignKey("dbo.Vendors", "Uid", "dbo.Users");
            DropIndex("dbo.Vendors", new[] { "Uid" });
            DropTable("dbo.Vendors");
            DropTable("dbo.Users");

            DropForeignKey("dbo.Products", "Vid", "dbo.Vendor");
            DropIndex("dbo.Products", new[] { "Vid" });
            DropTable("dbo.Products");
            DropTable("dbo.Vendors");

        }
    }
}
