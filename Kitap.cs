using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace Kitapci
{
    public class Kitap
    {
        private int _isbn;
        private string _baslik;
        private string _yazar;
        private int _adet;
        private string _yayinevi;
        private int _sayfaSayisi;
        private int _basimYili;
        public static List<DataGridView> tablolar = new List<DataGridView>();
        public int ISBN { get { return _isbn; } set { _isbn = value; } }
        public string Baslik { get { return _baslik; } set { _baslik = value; } }
        public string Yazar { get { return _yazar; } set { _yazar = value; } }
        public int Adet { get { return _adet; } set { _adet = value; } }
        public string Yayinevi { get { return _yayinevi; } set { _yayinevi = value; } }
        public int SayfaSayisi { get { return _sayfaSayisi; } set { _sayfaSayisi = value; } }
        public int BasimYili { get { return _basimYili; } set { _basimYili = value; } }

        private static SQLiteConnection _sqliteConn;
        private static SQLiteCommand _sqliteCmd;

        public static void ConnectToDatabase()
        {
            string dbPath = "kitaplar.db";
            bool isNewDatabase = !File.Exists(dbPath);

            _sqliteConn = new SQLiteConnection("Data Source=" + dbPath + ";Version=3;");
            _sqliteConn.Open();

            _sqliteCmd = _sqliteConn.CreateCommand();

            if (isNewDatabase)
            {
                _sqliteCmd.CommandText = @"CREATE TABLE Kitaplar (
                                            ISBN INTEGER PRIMARY KEY,
                                            Baslik TEXT,
                                            Yazar TEXT,
                                            Adet INTEGER,
                                            Yayinevi TEXT,
                                            SayfaSayisi INTEGER,
                                            BasimYili INTEGER)";
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
            foreach (var dgv in tablolar)
            {
                DataTable dataTable = new DataTable();
                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT * FROM Kitaplar", _sqliteConn))
                {
                    adapter.Fill(dataTable);
                }
                dgv.DataSource = dataTable;
            }
        }


        public static void AddKitap(Kitap kitap)
        {
            _sqliteCmd.CommandText = "INSERT INTO Kitaplar (ISBN, Baslik, Yazar, Adet, Yayinevi, SayfaSayisi, BasimYili) VALUES (@ISBN, @Baslik, @Yazar, @Adet, @Yayinevi, @SayfaSayisi, @BasimYili)";
            _sqliteCmd.Parameters.AddWithValue("@ISBN", kitap.ISBN);
            _sqliteCmd.Parameters.AddWithValue("@Baslik", kitap.Baslik);
            _sqliteCmd.Parameters.AddWithValue("@Yazar", kitap.Yazar);
            _sqliteCmd.Parameters.AddWithValue("@Adet", kitap.Adet);
            _sqliteCmd.Parameters.AddWithValue("@Yayinevi", kitap.Yayinevi);
            _sqliteCmd.Parameters.AddWithValue("@SayfaSayisi", kitap.SayfaSayisi);
            _sqliteCmd.Parameters.AddWithValue("@BasimYili", kitap.BasimYili);
            _sqliteCmd.ExecuteNonQuery();
        }

        public static void RemoveKitap(int isbn)
        {
            _sqliteCmd.CommandText = "DELETE FROM Kitaplar WHERE ISBN = @ISBN";
            _sqliteCmd.Parameters.AddWithValue("@ISBN", isbn);
            _sqliteCmd.ExecuteNonQuery();
        }

        public static Kitap GetKitap(int isbn)
        {
            _sqliteCmd.CommandText = "SELECT * FROM Kitaplar WHERE ISBN = @ISBN";
            _sqliteCmd.Parameters.AddWithValue("@ISBN", isbn);

            using (SQLiteDataReader reader = _sqliteCmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    Kitap kitap = new Kitap();
                    kitap.ISBN = Convert.ToInt32(reader["ISBN"]);
                    kitap.Baslik = reader["Baslik"].ToString();
                    kitap.Yazar = reader["Yazar"].ToString();
                    kitap.Adet = Convert.ToInt32(reader["Adet"]);
                    kitap.Yayinevi = reader["Yayinevi"].ToString();
                    kitap.SayfaSayisi = Convert.ToInt32(reader["SayfaSayisi"]);
                    kitap.BasimYili = Convert.ToInt32(reader["BasimYili"]);
                    return kitap;
                }
            }

            return null;
        }

    }
}
