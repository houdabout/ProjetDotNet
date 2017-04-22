using System;
using System.Collections.Generic;
using System.Data;

namespace Mercure
{
    public class Marque
    {
        public Marque(int refM, string n)
        {
            RefMarque = refM;
            Nom = n;
        }

        public int RefMarque { get; set; }
        public string Nom { get; set; }

        public static void InsertMarque(String databaseFile, Marque marque)
        {
            SQLiteHelper helper = new SQLiteHelper(databaseFile);
            Dictionary<String, Object> data = new Dictionary<String, Object>();
            data.Add("RefMarque", marque.RefMarque);
            data.Add("Nom", marque.Nom);
            helper.Insert(Configuration.MARQUE_TABLE_NAME, data);
        }

        public static Marque FindMarque(String databaseFile, int Ref)
        {
            SQLiteHelper helper = new SQLiteHelper(databaseFile);
            String query = String.Format("SELECT * FROM {0} WHERE RefMarque = {1}", Configuration.MARQUE_TABLE_NAME, Ref);
            try
            {
                DataTable marquesTable = helper.GetDataTable(query);
                if (marquesTable.Rows.Count == 0)
                {
                    return null;
                }
                DataRow row = marquesTable.Rows[0];
                int RefMarque = Int32.Parse(row["RefMarque"].ToString());
                String Nom = row["Nom"].ToString();
                return new Marque(RefMarque, Nom);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public static void UpdateMarque(String databaseFile, Marque marque)
        {
            SQLiteHelper helper = new SQLiteHelper(databaseFile);
            Dictionary<String, Object> data = new Dictionary<String, Object>();
            data.Add("Nom", marque.Nom);
            helper.Update(Configuration.MARQUE_TABLE_NAME, data, String.Format("RefMarque = {0}", marque.RefMarque));
        }

        public static Boolean IsMarqueExist(String databaseFile, int Ref)
        {
            return FindMarque(databaseFile, Ref) != null;
        }

        public static Marque FindMarqueByNom(String databaseFile, string N)
        {
            SQLiteHelper helper = new SQLiteHelper(databaseFile);
            String query = String.Format("SELECT * FROM {0} WHERE Nom = '{1}'", Configuration.MARQUE_TABLE_NAME, N);
            DataTable marquesTable = helper.GetDataTable(query);
            if (marquesTable.Rows.Count == 0)
            {
                return null;
            }
            DataRow row = marquesTable.Rows[0];
            int RefMarque = Int32.Parse(row["RefMarque"].ToString());
            String Nom = row["Nom"].ToString();
            return new Marque(RefMarque, Nom);
        }

        public static void RemoveMarque(String databaseFile, int Ref)
        {
            SQLiteHelper helper = new SQLiteHelper(databaseFile);
            helper.Delete(Configuration.MARQUE_TABLE_NAME, String.Format("RefMarque = {0}", Ref));
        }

        public static List<Marque> GetAll(String databaseFile)
        {
            SQLiteHelper helper = new SQLiteHelper(databaseFile);
            DataTable marquesTable = helper.GetDataTable(String.Format("SELECT * FROM {0}", Configuration.MARQUE_TABLE_NAME));
            List<Marque> marques = new List<Marque>();
            foreach (DataRow r in marquesTable.Rows)
            {
                Marque marque = new Marque(Int32.Parse(r["RefMarque"].ToString()), r["Nom"].ToString());
                marques.Add(marque);
            }
            return marques;
        }

        public static bool ClearMarqueTable(String databaseFile)
        {
            SQLiteHelper helper = new SQLiteHelper(databaseFile);
            return helper.ClearTable(Configuration.MARQUE_TABLE_NAME);
        }

        public static int GetSize(String databaseFile)
        {
            SQLiteHelper helper = new SQLiteHelper(databaseFile);
            String query = String.Format("SELECT Count(*) AS count FROM {0}", Configuration.MARQUE_TABLE_NAME);
            DataTable table = helper.GetDataTable(query);
            DataRow r = table.Rows[0];
            return Int32.Parse(r["count"].ToString());
        }
    }
}
