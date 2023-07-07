using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public Int64 kalanKullanimHakki { get; set; }
        public Int64 kullanilanHak { get; set; }
        public string notlar { get; set; }

        public PhoneModel( Int64 imei, string phoneModel,string notlar) {
            this.imei = imei;
            this.phoneModel = phoneModel;
            this.notlar = notlar;
        }

        public string FullDetails { get { return $"{id}-Imei:{imei} Model:{phoneModel} Başlangıç Tarihi:{baslangicTarihi} Son Kullanım Tarihi:{sonKullanimTarihi}  Kalan Kullanım Hakkı:{kalanKullanimHakki} Kullanılan Hak:{kullanilanHak}  Not:{notlar}"; } }

        public override string ToString()
        {
            return $"{id} {imei} {phoneModel} {baslangicTarihi} {sonKullanimTarihi}{kalanGunSayisi} {kalanKullanimHakki} {kullanilanHak} {notlar}";
        }

    }
}
