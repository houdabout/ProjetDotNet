using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;

namespace Mercure
{
    public class Famille
    {
        public int RefFamille { get; set; }
        public string Nom { get; set; }

        public Famille(int refF, String Nom)
        {
            this.RefFamille = refF;
            this.Nom = Nom;
        }

        public static void InsertFamille(String databaseFile, Famille famille)
        {
            SQLiteHelper helper = new SQLiteHelper(databaseFile);
            Dictionary<String, Object> data = new Dictionary<String, Object>();
            data.Add("RefFamille", famille.RefFamille);
            data.Add("Nom", famille.Nom);
            helper.Insert(Configuration.FAMILLE_TABLE_NAME, data);
        }

        public static Famille FindFamille(String databaseFile, int Ref)
        {

            SQLiteHelper helper = new SQLiteHelper(databaseFile);
            String query = String.Format("SELECT * FROM {0} WHERE RefFamille = {1}", Configuration.FAMILLE_TABLE_NAME, Ref);
            try
            {
                DataTable table = helper.GetDataTable(query);
                if (table.Rows.Count == 0)
                {
                    return null;
                }
                DataRow row = table.Rows[0];
                int RefF = Int32.Parse(row["RefFamille"].ToString());
                String Nom = row["Nom"].ToString();
                return new Famille(RefF, Nom);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public static Famille FindFamilleByNom(String databaseFile, string NomF)
        {

            SQLiteHelper helper = new SQLiteHelper(databaseFile);
            String query = String.Format("SELECT * FROM {0} WHERE Nom = '{1}'", Configuration.FAMILLE_TABLE_NAME, NomF);
            DataTable table = helper.GetDataTable(query);
            if (table.Rows.Count == 0)
            {
                return null;
            }
            DataRow row = table.Rows[0];
            int RefF = Int32.Parse(row["RefFamille"].ToString());
            String Nom = row["Nom"].ToString();
            return new Famille(RefF, Nom);

        }

        public static void UpdateFamille(String databaseFile, Famille famille)
        {
            SQLiteHelper helper = new SQLiteHelper(databaseFile);
            Dictionary<String, Object> data = new Dictionary<String, Object>();
            data.Add("Nom", famille.Nom);
            helper.Update(Configuration.FAMILLE_TABLE_NAME, data, String.Format("RefFamille = {0}", famille.RefFamille));
        }

        public static void RemoveFamille(String databaseFile, int Ref)
        {
            SQLiteHelper helper = new SQLiteHelper(databaseFile);
            helper.Delete(Configuration.FAMILLE_TABLE_NAME, String.Format("RefFamille = {0}", Ref));
        }

        public static List<Famille> GetAll(String databaseFile)
        {
            SQLiteHelper helper = new SQLiteHelper(databaseFile);
            DataTable marquesTable = helper.GetDataTable(String.Format("SELECT * FROM {0}", Configuration.FAMILLE_TABLE_NAME));
            List<Famille> familles = new List<Famille>();
            foreach (DataRow r in marquesTable.Rows)
            {
                Famille famille = new Famille(Int32.Parse(r["RefFamille"].ToString()), r["Nom"].ToString());
                familles.Add(famille);
            }
            return familles;

        }

        public static int GetSize(String databaseFile)
        {
            SQLiteHelper helper = new SQLiteHelper(databaseFile);
            String query = String.Format("SELECT Count(*) AS count FROM {0}", Configuration.FAMILLE_TABLE_NAME);
            DataTable table = helper.GetDataTable(query);
            DataRow r = table.Rows[0];
            return Int32.Parse(r["count"].ToString());
        }
    }
}
