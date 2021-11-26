using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_OOP_Ornek.Classlar
{
    class UrunSepeti
    {

        public int SepetId { get; set; }
        public int MusteriId { get; set; }
        public List<Urun> UrunlerListesi { get; set; } = new List<Urun>();
        public void DogumGunuHediyesiEkle()
        {
            Urun hediye = new Urun()
            {
                UrunAdi = "Gofret",
                UrunId = 300,
                UrunKategorisi = UrunKategorileri.Gıda

            };

            UrunlerListesi.Add(hediye);

        }
    }
}
