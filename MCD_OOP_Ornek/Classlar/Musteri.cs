using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_OOP_Ornek.Classlar
{
    class Musteri
    {
        #region Properties
        public int MusteriId { get; set; }
        public string MusteriAdi { get; set; }
        public string MusteriSoyadi { get; set; }
        public DateTime  DogumTarihi { get; set; }
        public Cinsiyetler Cinsiyeti { get; set; }
        public UrunSepeti MusterininUrunSepeti { get; set; }

        #endregion

        #region Metotlar

        public bool MusterininDogumGunuMu()
        {
            bool kontrol = false;

            kontrol = (DogumTarihi.Day == DateTime.Now.Day && DogumTarihi.Month == DateTime.Now.Month) ? true : false;
            return kontrol;
        }

        public void MusteriBilgileriYazdır()
        {
            Console.WriteLine($"Müşteri No : {MusteriId } - Müşteri Adı: {MusteriAdi} - Müsteri Soyadı: {MusteriSoyadi }");
        }

        public void MusterininSepetiniYazdir()
        {

        }
        #endregion 

    }
}
