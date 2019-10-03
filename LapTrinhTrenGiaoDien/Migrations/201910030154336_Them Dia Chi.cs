namespace LapTrinhTrenGiaoDien.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ThemDiaChi : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.KhachHangs", "DiaChi", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.KhachHangs", "DiaChi");
        }
    }
}
