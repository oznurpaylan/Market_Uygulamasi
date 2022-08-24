using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zincir_market_1.Sınıflar
{
    public class Urun
    {
        public int ID { get; set; }
        public string UrunAdı { get; set; }
        public string Kategori { get; set; }
        public DateTime SonIndirimTarihi { get; set; }
        public virtual Tedarikci UrunTedarik { get; set; }
        public virtual ICollection<Stok> UrunStok { get; set; }
        public virtual ICollection<Sube> UrunSube { get; set; }
    }

}
