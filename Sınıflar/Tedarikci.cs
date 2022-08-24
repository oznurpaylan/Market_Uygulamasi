using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zincir_market_1.Sınıflar
{
    public class Tedarikci
    {
        public int ID { get; set; } 
        public string Adres { get; set; }
        public virtual ICollection<Urun> TedarikUrun { get; set; }

    }
}
