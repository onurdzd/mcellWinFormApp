using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mcell
{
    public class PhoneModel
    {
        public Int64 id { get; set; }
        public Int64 imei { get; set; }
        public string phoneModel { get; set; }
        public DateTime baslangicTarihi { get; set; }
        public DateTime sonKullanimTarihi { get; set; }
        public Int64 kalanGunSayisi { get; set; }
        public Int64 kullanimHakki { get; set; }
        public Int64 kullanilanHak { get; set; }
        public Int64 kalanKullanimHakki { get; set; }
        public string notlar { get; set; }

        public PhoneModel(Int64 id, Int64 imei, string phoneModel, DateTime baslangicTarihi, DateTime sonKullanimTarihi, Int64 kalanGunSayisi, Int64 kullanimHakki, Int64 kullanilanHak, Int64 kalanKullanimHakki, string notlar)
        {
            this.id = id;
            this.imei = imei;
            this.phoneModel = phoneModel;
            this.baslangicTarihi = baslangicTarihi;
            this.sonKullanimTarihi = sonKullanimTarihi;
            this.kalanGunSayisi = kalanGunSayisi;
            this.kullanimHakki=kullanimHakki;
            this.kullanilanHak = kullanilanHak;
            this.kalanKullanimHakki = kalanKullanimHakki;
            this.notlar = notlar;
        }

        public override string ToString()
        {
            return $"{id} {imei} {phoneModel} {baslangicTarihi} {sonKullanimTarihi}{kalanGunSayisi}  {kullanimHakki}  {kullanilanHak} {kalanKullanimHakki} {notlar}";
        }

    }
}
