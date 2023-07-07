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
        public static List<PhoneModel> LoadPhones()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<PhoneModel>("SELECT imei, phoneModel, notlar FROM allData", new DynamicParameters());
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

        private static string LoadConnectionString(string id="Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
