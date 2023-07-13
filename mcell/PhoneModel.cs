﻿using System;
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
        public Int64 kalanKullanimHakki { get; set; }
        public Int64 kullanilanHak { get; set; }
        public string notlar { get; set; }

        public PhoneModel(Int64 id,Int64 imei, string phoneModel,string notlar) {
            this.id = id;
            this.imei = imei;
            this.phoneModel = phoneModel;
            this.notlar = notlar;
        }

        public PhoneModel(Int64 id, Int64 kalanKullanimHakki, Int64 kullanilanHak)
        {
            this.id = id;
            this.kalanKullanimHakki = kalanKullanimHakki;
            this.kullanilanHak = kullanilanHak;
        }


        public PhoneModel(Int64 id, Int64 imei, string phoneModel, DateTime baslangicTarihi, DateTime sonKullanimTarihi, Int64 kalanGunSayisi, Int64 kalanKullanimHakki, Int64 kullanilanHak, string notlar)
        {
            this.id = id;
            this.imei = imei;
            this.phoneModel = phoneModel;
            this.baslangicTarihi = baslangicTarihi;
            this.sonKullanimTarihi = sonKullanimTarihi;
            this.kalanGunSayisi = kalanGunSayisi;
            this.kalanKullanimHakki = kalanKullanimHakki;
            this.kullanilanHak = kullanilanHak;
            this.notlar = notlar;
        }

        public override string ToString()
        {
            return $"{id} {imei} {phoneModel} {baslangicTarihi} {sonKullanimTarihi}{kalanGunSayisi} {kalanKullanimHakki} {kullanilanHak} {notlar}";
        }

    }
}
