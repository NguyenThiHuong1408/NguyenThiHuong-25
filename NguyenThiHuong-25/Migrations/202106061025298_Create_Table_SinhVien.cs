namespace NguyenThiHuong_25.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_SinhVien : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.SinhViens", "MaLop");
            AddForeignKey("dbo.SinhViens", "MaLop", "dbo.LopHocs", "MaLop", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SinhViens", "MaLop", "dbo.LopHocs");
            DropIndex("dbo.SinhViens", new[] { "MaLop" });
        }
    }
}
