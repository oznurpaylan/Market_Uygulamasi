namespace zincir_market_1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Personel",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        isimSoyisim = c.String(),
                        TC = c.Int(nullable: false),
                        Sifre = c.String(),
                        izinHakki = c.Int(nullable: false),
                        Adres = c.String(),
                        Pozisyon = c.String(),
                        Maas = c.Int(nullable: false),
                        CalismaBaslangicTarihi = c.DateTime(nullable: false),
                        PersonelSube_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Sube", t => t.PersonelSube_ID)
                .Index(t => t.PersonelSube_ID);
            
            CreateTable(
                "dbo.Sube",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Adres = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Urun",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UrunAdı = c.String(),
                        Kategori = c.String(),
                        SonIndirimTarihi = c.DateTime(nullable: false),
                        UrunTedarik_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Tedarikci", t => t.UrunTedarik_ID)
                .Index(t => t.UrunTedarik_ID);
            
            CreateTable(
                "dbo.Stok",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Adet = c.Int(nullable: false),
                        GuncellemeTarihi = c.DateTime(nullable: false),
                        StokSube_ID = c.Int(),
                        StokUrun_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Sube", t => t.StokSube_ID)
                .ForeignKey("dbo.Urun", t => t.StokUrun_ID)
                .Index(t => t.StokSube_ID)
                .Index(t => t.StokUrun_ID);
            
            CreateTable(
                "dbo.Tedarikci",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Adres = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.UrunSube",
                c => new
                    {
                        Urun_ID = c.Int(nullable: false),
                        Sube_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Urun_ID, t.Sube_ID })
                .ForeignKey("dbo.Urun", t => t.Urun_ID, cascadeDelete: true)
                .ForeignKey("dbo.Sube", t => t.Sube_ID, cascadeDelete: true)
                .Index(t => t.Urun_ID)
                .Index(t => t.Sube_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Urun", "UrunTedarik_ID", "dbo.Tedarikci");
            DropForeignKey("dbo.UrunSube", "Sube_ID", "dbo.Sube");
            DropForeignKey("dbo.UrunSube", "Urun_ID", "dbo.Urun");
            DropForeignKey("dbo.Stok", "StokUrun_ID", "dbo.Urun");
            DropForeignKey("dbo.Stok", "StokSube_ID", "dbo.Sube");
            DropForeignKey("dbo.Personel", "PersonelSube_ID", "dbo.Sube");
            DropIndex("dbo.UrunSube", new[] { "Sube_ID" });
            DropIndex("dbo.UrunSube", new[] { "Urun_ID" });
            DropIndex("dbo.Stok", new[] { "StokUrun_ID" });
            DropIndex("dbo.Stok", new[] { "StokSube_ID" });
            DropIndex("dbo.Urun", new[] { "UrunTedarik_ID" });
            DropIndex("dbo.Personel", new[] { "PersonelSube_ID" });
            DropTable("dbo.UrunSube");
            DropTable("dbo.Tedarikci");
            DropTable("dbo.Stok");
            DropTable("dbo.Urun");
            DropTable("dbo.Sube");
            DropTable("dbo.Personel");
        }
    }
}
