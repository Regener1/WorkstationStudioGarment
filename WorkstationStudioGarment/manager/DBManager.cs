using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Data;

namespace WorkstationStudioGarment.manager
{
    class DBManager
    {
        private string path;

        /// <summary>
        /// Path to database
        /// </summary>
        public string Path
        {
            get { return path; }
            set { path = value; }
        }

        /// <summary>
        /// Creating new database if not exist
        /// </summary>
        /// <param name="path">Path to database</param>
        public void ConnectDataBase(string path)
        {
            this.path = path;

            try
            {
                if (!File.Exists(path))
                    SQLiteConnection.CreateFile(path);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Executes a query
        /// </summary>
        /// <param name="query">Query</param>
        public void ExecuteNonQuery(string query)
        {
            if (path.Equals(""))
                throw new Exception("Empty path to database.");

            if (!File.Exists(path))
                throw new FileNotFoundException("File not found. Path: " + path);

            try
            {
                SQLiteConnection sql = new SQLiteConnection(@"Data Source=" + path + ";Version=3");
                SQLiteCommand command = new SQLiteCommand(query, sql); //запрос
                sql.Open();//открыли подключение к бд
                command.ExecuteNonQuery();//выполнили команду
                sql.Close();//закрыли
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Obtains information from the database
        /// </summary>
        /// <param name="query">Query</param>
        /// <returns>New object DataTable</returns>
        public DataTable ExecuteReader(string query)
        {
            DataTable data;

            if (path.Equals(""))
                throw new Exception("Empty path to database.");

            if (!File.Exists(path))
                throw new FileNotFoundException("File not found. Path: " + path);

            try
            {
                SQLiteConnection sql = new SQLiteConnection(@"Data Source=" + path + ";Version=3");
                SQLiteCommand command = new SQLiteCommand(query, sql);
                sql.Open();
                SQLiteDataReader sdr = command.ExecuteReader();
                data = new DataTable();
                data.Load(sdr);
                sdr.Close();
                sql.Close();
            }
            catch (Exception e)
            {
                throw e;
            }

            return data;
        }
    }
}
