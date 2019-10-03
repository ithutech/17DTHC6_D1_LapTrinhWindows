namespace LapTrinhTrenGiaoDien.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ThayDoiKieuCuaTenHangGhe : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.HangGhes", "TenHangGhe", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.HangGhes", "TenHangGhe", c => c.Int(nullable: false));
        }
    }
}
