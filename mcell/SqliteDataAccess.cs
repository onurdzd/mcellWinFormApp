﻿using Dapper;
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
        public static List<PhoneModel> LoadPhones()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<PhoneModel>("SELECT id,imei, phoneModel, notlar FROM allData", new DynamicParameters());
        return output.ToList();
            };
        }

        public static void SavePhone(PhoneModel phone)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into allData (imei,phoneModel) values (@imei,@phoneModel)", phone);
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

        private static string LoadConnectionString(string id="Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        public static List<PhoneModel> LoadGridPhones()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<PhoneModel>("SELECT * FROM allData", new DynamicParameters());
                return output.ToList();
            };
        }
        public static void SavePhoneGrid(PhoneModel phone)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into allData (id,imei,phoneModel,baslangicTarihi,sonKullanımTarihi,kalanGunSayisi,kalanKullanimHakki,kullanilanHak,notlar) values (@id,@imei,@phoneModel,@baslangicTarihi,@sonKullanımTarihi,@kalanGunSayisi,@kalanKullanimHakki,@kullanilanHak,@notlar)", phone);
            }
        }
    }
}
