using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mcell
{
    public class SqliteDataAccess
    {
        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
        public static void SavePhone(PhoneModel phone)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into allData (imei,phoneModel,baslangicTarihi,sonKullanimTarihi,kalanGunSayisi,kalanKullanimHakki,kullanilanHak,notlar) values (@imei,@phoneModel,@baslangicTarihi,@sonKullanimTarihi,@kalanGunSayisi,@kalanKullanimHakki,@kullanilanHak,@notlar)", phone);
            }
        }

        public static void DeletePhone(PhoneModel phone)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("DELETE FROM allData WHERE id = @id", phone);
            }
        }
        public static void ResetDb()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("DELETE FROM allData");
                cnn.Execute("delete from sqlite_sequence where name='allData';");
            }
        }

        public static List<PhoneModel> LoadGridPhones()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<PhoneModel>("SELECT * FROM allData", new DynamicParameters());
                return output.ToList();
            };
        }


        //UpdatePhone DÜZELTİCELECEK
        public static void UpdatePhone(PhoneModel phone)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {

                string query = @"UPDATE allData 
                         SET imei = @imei,
                             phoneModel = @phoneModel,
                             baslangicTarihi = @baslangicTarihi,
                             sonKullanimTarihi = @sonKullanimTarihi,
                             kalanGunSayisi = @kalanGunSayisi,
                             kalanKullanimHakki = @kalanKullanimHakki,
                             kullanilanHak = @kullanilanHak,
                             notlar = @notlar
                         WHERE id = @id";

                cnn.Execute(query, phone);
            }
        }
    }
}
