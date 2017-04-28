using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;


/*
 * @author : HOUDA BOUTBIB et MOHAMMED ELMOUTARAJI
 * */

namespace Mercure
{
    public class SQLiteHelper
    {
        String databaseFile;

        public SQLiteHelper(String file)
        {
            databaseFile = String.Format("Data Source={0};Version=3;", file);
        }

        public int ExecuteNonQuery(string sql)
        {
            SQLiteConnection conn = new SQLiteConnection(databaseFile);
            conn.Open();
            SQLiteCommand command = new SQLiteCommand(conn);
            command.CommandText = sql;
            int rowsUpdated = command.ExecuteNonQuery();
            conn.Close();
            return rowsUpdated;
        }

        public DataTable GetDataTable(string sql)
        {
            DataTable dt = new DataTable();
            try
            {
                SQLiteConnection cnn = new SQLiteConnection(databaseFile);
                cnn.Open();
                SQLiteCommand mycommand = new SQLiteCommand(sql, cnn);
                SQLiteDataReader reader = mycommand.ExecuteReader();
                dt.Load(reader);
                reader.Close();
                cnn.Close();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return dt;
        }

        public bool Delete(String tableName, String where)
        {
            Boolean returnCode = true;
            try
            {
                this.ExecuteNonQuery(String.Format("delete from {0} where {1};", tableName, where));
            }
            catch (Exception fail)
            {
                Console.WriteLine("Delete error : " + fail.Message);
                returnCode = false;
            }
            return returnCode;
        }

        public bool Insert(String tableName, Dictionary<String, Object> data)
        {
            String columns = "";
            String values = "";
            Boolean returnCode = true;
            foreach (KeyValuePair<String, Object> val in data)
            {
                columns += String.Format(" {0},", val.Key.ToString());
                if(val.Value is String)
                {
                    values += String.Format(" '{0}',", val.Value);
                }
                else
                {
                    values += String.Format(" {0},", val.Value);
                }
            }
            columns = columns.Substring(0, columns.Length - 1);
            values = values.Substring(0, values.Length - 1);
            try
            {
                this.ExecuteNonQuery(String.Format("insert into {0}({1}) values({2});", tableName, columns, values));
            }
            catch (Exception fail)
            {
                Console.WriteLine("Insert error : " + fail.Message);
                returnCode = false;
            }
            return returnCode;
        }

        public bool Update(String tableName, Dictionary<String, Object> data, String where)
        {
            String set = "";
            Boolean returnCode = true;
            foreach (KeyValuePair<String, Object> val in data)
            {
                if(val.Value is String)
                {
                    set += String.Format(" {0}='{1}',", val.Key.ToString(), val.Value);
                }
                else
                {
                    set += String.Format(" {0}={1},", val.Key.ToString(), val.Value);
                }
            }
            set = set.Substring(0, set.Length - 1);
            try
            {
                this.ExecuteNonQuery(String.Format("update {0} set {1} where {2};", tableName, set, where));
            }
            catch (Exception fail)
            {
                Console.WriteLine("Update error : " + fail.Message);
                returnCode = false;
            }
            return returnCode;
        }

        public bool ClearTable(String table)
        {
            try
            {
                this.ExecuteNonQuery(String.Format("DELETE FROM {0}", table));
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool ClearDB()
        {
            DataTable tables;
            try
            {
                tables = this.GetDataTable("select NAME from SQLITE_MASTER where type='table' order by NAME;");
                foreach (DataRow table in tables.Rows)
                {
                    this.ClearTable(table["NAME"].ToString());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("ClearDB error : " + e.Message);
                return false;
            }
            return true;
        }
    }
}