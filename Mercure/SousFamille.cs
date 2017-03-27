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
        public SousFamille(int refSF, int refF, String n)
        {
            RefSousFamille = refSF;
            RefFamille = refF;
            Nom = n;
        }

        public int RefSousFamille { get; set; }
        public int RefFamille { get; set; }
        public string Nom { get; set; }

        public static void InsertSousFamille(String databaseFile, SousFamille sousF)
        {
            SQLiteHelper helper = new SQLiteHelper(databaseFile);
            Dictionary<String, Object> data = new Dictionary<String, Object>();
            data.Add("RefSousFamille", sousF.RefSousFamille);
            data.Add("RefFamille", sousF.RefFamille);
            data.Add("Nom", sousF.Nom);
            helper.Insert("SousFamilles", data);
        }

        public static SousFamille FindSousFamille(String databaseFile, int Ref)
        {
            SQLiteHelper helper = new SQLiteHelper(databaseFile);
            String query = String.Format("SELECT * FROM SousFamilles WHERE RefSousFamille = {0}", Ref);
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
            String query = String.Format("SELECT * FROM SousFamilles WHERE Nom = '{0}'", N);
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

        public static void RemoveSousFamille(String databaseFile, int Ref)
        {
            SQLiteHelper helper = new SQLiteHelper(databaseFile);
            helper.Delete("familles", String.Format("RefFamille = {0}", Ref));
        }

        public static List<SousFamille> GetAll(String databaseFile)
        {
            return null;
        }

        public static int GetSize(String databaseFile)
        {
            SQLiteHelper helper = new SQLiteHelper(databaseFile);
            String query = String.Format("SELECT * FROM SousFamilles");
            DataTable table = helper.GetDataTable(query);
            return table.Rows.Count;
        }
    }
}
