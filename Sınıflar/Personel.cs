using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zincir_market_1.Sınıflar
{
    public class Personel
    {
        public int ID { get; set; }
        public string isimSoyisim { get; set; }
        public int TC { get; set; }
        public string Sifre { get; set; }
        public int izinHakki { get; set; }
        public string Adres { get; set; }
        public string Pozisyon { get; set; }
        public int Maas { get; set; }
        public DateTime CalismaBaslangicTarihi { get; set; }
        public virtual Sube PersonelSube { get; set; }
    }
}
