using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zincir_market_1.Sınıflar
{
    public class Stok
    {
        public int ID { get; set; }
        public int Adet { get; set; }
        public DateTime GuncellemeTarihi { get; set; }
        public virtual Sube StokSube { get; set; }
        public virtual Urun StokUrun { get; set; }
    }
}
