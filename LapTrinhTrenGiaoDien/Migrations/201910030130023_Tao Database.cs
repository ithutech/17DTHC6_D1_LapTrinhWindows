namespace LapTrinhTrenGiaoDien.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TaoDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ChiTietHoaDons",
                c => new
                    {
                        ChiTietHoaDonID = c.Int(nullable: false, identity: true),
                        HoaDonID = c.Int(nullable: false),
                        GheID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ChiTietHoaDonID)
                .ForeignKey("dbo.Ghes", t => t.GheID, cascadeDelete: true)
                .ForeignKey("dbo.HoaDons", t => t.HoaDonID, cascadeDelete: true)
                .Index(t => t.HoaDonID)
                .Index(t => t.GheID);
            
            CreateTable(
                "dbo.Ghes",
                c => new
                    {
                        GheID = c.Int(nullable: false, identity: true),
                        HangGheID = c.Int(nullable: false),
                        SoGhe = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.GheID)
                .ForeignKey("dbo.HangGhes", t => t.HangGheID, cascadeDelete: true)
                .Index(t => t.HangGheID);
            
            CreateTable(
                "dbo.HangGhes",
                c => new
                    {
                        HangGheID = c.Int(nullable: false, identity: true),
                        TenHangGhe = c.Int(nullable: false),
                        GiaVe = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.HangGheID);
            
            CreateTable(
                "dbo.HoaDons",
                c => new
                    {
                        HoaDonID = c.Int(nullable: false, identity: true),
                        KhachHangID = c.Int(nullable: false),
                        ThoiGianDatVe = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.HoaDonID)
                .ForeignKey("dbo.KhachHangs", t => t.KhachHangID, cascadeDelete: true)
                .Index(t => t.KhachHangID);
            
            CreateTable(
                "dbo.KhachHangs",
                c => new
                    {
                        KhachHangID = c.Int(nullable: false, identity: true),
                        TenKhachHang = c.String(),
                    })
                .PrimaryKey(t => t.KhachHangID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.HoaDons", "KhachHangID", "dbo.KhachHangs");
            DropForeignKey("dbo.ChiTietHoaDons", "HoaDonID", "dbo.HoaDons");
            DropForeignKey("dbo.Ghes", "HangGheID", "dbo.HangGhes");
            DropForeignKey("dbo.ChiTietHoaDons", "GheID", "dbo.Ghes");
            DropIndex("dbo.HoaDons", new[] { "KhachHangID" });
            DropIndex("dbo.Ghes", new[] { "HangGheID" });
            DropIndex("dbo.ChiTietHoaDons", new[] { "GheID" });
            DropIndex("dbo.ChiTietHoaDons", new[] { "HoaDonID" });
            DropTable("dbo.KhachHangs");
            DropTable("dbo.HoaDons");
            DropTable("dbo.HangGhes");
            DropTable("dbo.Ghes");
            DropTable("dbo.ChiTietHoaDons");
        }
    }
}
