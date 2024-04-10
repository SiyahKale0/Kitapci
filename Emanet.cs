using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Kitapci
{
    public class Emanet 
    {
        private int _aliciTC;
        private int _kitapIsbn;
        private DateTime _alinmaTarihi;
        private DateTime _iadeTarihi;
        public static List<DataGridView> tablolar = new List<DataGridView>();
        public int AliciTC { get { return _aliciTC; } set { _aliciTC = value; } }
        public int KitapIsbn { get { return _kitapIsbn; } set { _kitapIsbn = value; } }
        public DateTime AlinmaTarihi { get { return _alinmaTarihi; } set { _alinmaTarihi = value; } }
        public DateTime IadeTarihi { get { return _iadeTarihi; } set { _iadeTarihi = value; } }

        private static SQLiteConnection _sqliteConn;
        private static SQLiteCommand _sqliteCmd;

        public static void ConnectToDatabase()
        {
            string dbPath = "veritabani.db"; // Database file path
            bool isNewDatabase = !File.Exists(dbPath); // Check if a new database is created

            // Create connection
            _sqliteConn = new SQLiteConnection("Data Source=" + dbPath + ";Version=3;");
            _sqliteConn.Open();

            // Create command object
            _sqliteCmd = _sqliteConn.CreateCommand();

            // Create table if a new database is created
            if (isNewDatabase)
            {
                _sqliteCmd.CommandText = @"CREATE TABLE Emanet (
                                            AliciTC INTEGER,
                                            KitapIsbn INTEGER,
                                            AlinmaTarihi TEXT,
                                            IadeTarihi TEXT)";
                _sqliteCmd.ExecuteNonQuery();
            }
        }

        public static void CloseDatabase()
        {
            _sqliteConn.Close();
        }

        public static void AddTable(DataGridView dataGridView)
        {
            tablolar.Add(dataGridView);
        }
        public static void GetData()
        {
           foreach(var dgv in tablolar)
            {
                DataTable dataTable = new DataTable();
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT * FROM Emanet", _sqliteConn))
                {
                    adapter.Fill(dataTable);
                }
                dgv.DataSource = dataTable;
            }
            
        }

        public static void AddEmanet(Emanet emanet)
        {
            _sqliteCmd.CommandText = "INSERT INTO Emanet (AliciTC, KitapIsbn, AlinmaTarihi, IadeTarihi) VALUES (@AliciTC, @KitapIsbn, @AlinmaTarihi, @IadeTarihi)";
            _sqliteCmd.Parameters.AddWithValue("@AliciTC", emanet.AliciTC);
            _sqliteCmd.Parameters.AddWithValue("@KitapIsbn", emanet.KitapIsbn);
            _sqliteCmd.Parameters.AddWithValue("@AlinmaTarihi", emanet.AlinmaTarihi.ToString("yyyy-MM-dd HH:mm:ss"));
            _sqliteCmd.Parameters.AddWithValue("@IadeTarihi", emanet.IadeTarihi.ToString("yyyy-MM-dd HH:mm:ss"));
            _sqliteCmd.ExecuteNonQuery();
        }

        public static void RemoveEmanet(string aliciTC, string kitapIsbn)
        {
            _sqliteCmd.CommandText = "DELETE FROM Emanet WHERE AliciTC = @AliciTC AND KitapIsbn = @KitapIsbn";
            _sqliteCmd.Parameters.AddWithValue("@AliciTC", aliciTC);
            _sqliteCmd.Parameters.AddWithValue("@KitapIsbn", kitapIsbn);
            _sqliteCmd.ExecuteNonQuery();
        }

        public static DateTime? GetEmanetDate(int aliciTC, int kitapIsbn)
        {
            _sqliteCmd.CommandText = "SELECT AlinmaTarihi FROM Emanet WHERE AliciTC = @AliciTC AND KitapIsbn = @KitapIsbn";
            _sqliteCmd.Parameters.AddWithValue("@AliciTC", aliciTC);
            _sqliteCmd.Parameters.AddWithValue("@KitapIsbn", kitapIsbn);
            object result = _sqliteCmd.ExecuteScalar();
            if (result != null)
            {
                return Convert.ToDateTime(result);
            }
            return null;
        }

    }
}

