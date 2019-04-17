namespace HastaneOtomasyon.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class hhh : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Randevulars", name: "Doktorlar_DoktorlarId", newName: "DoktorlarId");
            RenameColumn(table: "dbo.Randevulars", name: "Hastaneler_HastanelerID", newName: "HastanelerID");
            RenameColumn(table: "dbo.Randevulars", name: "Klinikler_KliniklerID", newName: "KliniklerID");
            RenameIndex(table: "dbo.Randevulars", name: "IX_Doktorlar_DoktorlarId", newName: "IX_DoktorlarId");
            RenameIndex(table: "dbo.Randevulars", name: "IX_Hastaneler_HastanelerID", newName: "IX_HastanelerID");
            RenameIndex(table: "dbo.Randevulars", name: "IX_Klinikler_KliniklerID", newName: "IX_KliniklerID");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Randevulars", name: "IX_KliniklerID", newName: "IX_Klinikler_KliniklerID");
            RenameIndex(table: "dbo.Randevulars", name: "IX_HastanelerID", newName: "IX_Hastaneler_HastanelerID");
            RenameIndex(table: "dbo.Randevulars", name: "IX_DoktorlarId", newName: "IX_Doktorlar_DoktorlarId");
            RenameColumn(table: "dbo.Randevulars", name: "KliniklerID", newName: "Klinikler_KliniklerID");
            RenameColumn(table: "dbo.Randevulars", name: "HastanelerID", newName: "Hastaneler_HastanelerID");
            RenameColumn(table: "dbo.Randevulars", name: "DoktorlarId", newName: "Doktorlar_DoktorlarId");
        }
    }
}
