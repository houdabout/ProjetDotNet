using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Mercure
{
    public class SousFamille
    {
        public int RefSousFamille { get; set; }
        public int RefFamille { get; set; }
        public string Nom { get; set; }

        public SousFamille(int refSF, int refF, String n)
        {
            RefSousFamille = refSF;
            RefFamille = refF;
            Nom = n;
        }

        public static void InsertSousFamille(String databaseFile, SousFamille sousF)
        {
            SQLiteHelper helper = new SQLiteHelper(databaseFile);
            Dictionary<String, Object> data = new Dictionary<String, Object>();
            data.Add("RefSousFamille", sousF.RefSousFamille);
            data.Add("RefFamille", sousF.RefFamille);
            data.Add("Nom", sousF.Nom);
            helper.Insert(Configuration.SOUS_FAMILLE_TABLE_NAME, data);
        }

        public static SousFamille FindSousFamille(String databaseFile, int Ref)
        {
            SQLiteHelper helper = new SQLiteHelper(databaseFile);
            String query = String.Format("SELECT * FROM {0} WHERE RefSousFamille = {1}", Configuration.SOUS_FAMILLE_TABLE_NAME, Ref);
            try
            {
                DataTable table = helper.GetDataTable(query);
                if (table.Rows.Count == 0)
                {
                    return null;
                }
                DataRow row = table.Rows[0];
                int RefSousF = Int32.Parse(row["RefSousFamille"].ToString());
                int RefF = Int32.Parse(row["RefFamille"].ToString());
                String Nom = row["Nom"].ToString();
                return new SousFamille(RefSousF, RefF, Nom);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public static SousFamille FindSousFamilleByNom(String databaseFile, string N)
        {
            SQLiteHelper helper = new SQLiteHelper(databaseFile);
            String query = String.Format("SELECT * FROM {0} WHERE Nom = '{1}'", Configuration.SOUS_FAMILLE_TABLE_NAME, N);
            DataTable table = helper.GetDataTable(query);
            if (table.Rows.Count == 0)
            {
                return null;
            }
            DataRow row = table.Rows[0];
            int RefSousF = Int32.Parse(row["RefSousFamille"].ToString());
            int RefF = Int32.Parse(row["RefFamille"].ToString());
            String Nom = row["Nom"].ToString();
            return new SousFamille(RefSousF, RefF, Nom);
        }

        public static void UpdateSousFamille(String databaseFile, SousFamille sousFamille)
        {
            SQLiteHelper helper = new SQLiteHelper(databaseFile);
            Dictionary<String, Object> data = new Dictionary<String, Object>();
            data.Add("Nom", sousFamille.Nom);
            data.Add("RefFamille", sousFamille.RefFamille);
            helper.Update(Configuration.SOUS_FAMILLE_TABLE_NAME, data, String.Format("RefSousFamille = {0}", sousFamille.RefSousFamille));
        }

        public static void RemoveSousFamille(String databaseFile, int Ref)
        {
            SQLiteHelper helper = new SQLiteHelper(databaseFile);
            helper.Delete(Configuration.SOUS_FAMILLE_TABLE_NAME, String.Format("RefSousFamille = {0}", Ref));
        }

        public static List<SousFamille> GetAll(String databaseFile)
        {
            SQLiteHelper helper = new SQLiteHelper(databaseFile);
            DataTable marquesTable = helper.GetDataTable(String.Format("SELECT * FROM {0}", Configuration.SOUS_FAMILLE_TABLE_NAME));
            List<SousFamille> sousFamilles = new List<SousFamille>();
            foreach (DataRow r in marquesTable.Rows)
            {
                SousFamille sf = new SousFamille(
                    Int32.Parse(r["RefSousFamille"].ToString()),
                    Int32.Parse(r["RefFamille"].ToString()),
                    r["Nom"].ToString());
                sousFamilles.Add(sf);
            }
            return sousFamilles;
        }

        public static int GetSize(String databaseFile)
        {
            SQLiteHelper helper = new SQLiteHelper(databaseFile);
            String query = String.Format("SELECT * FROM {0}", Configuration.SOUS_FAMILLE_TABLE_NAME);
            DataTable table = helper.GetDataTable(query);
            return table.Rows.Count;
        }
    }
}
