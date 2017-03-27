using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

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

        public static void AddFamille(String databaseFile, Famille article)
        {
            SQLiteHelper helper = new SQLiteHelper(databaseFile);
            Dictionary<String, Object> data = new Dictionary<String, Object>();
            data.Add("RefFamille", article.RefFamille);
            data.Add("Nom", article.Nom);
            helper.Insert("Familles", data);
        }

        public static Famille FindFamille(String databaseFile, int Ref)
        {

            SQLiteHelper helper = new SQLiteHelper(databaseFile);
            String query = String.Format("SELECT * FROM Familles WHERE RefFamille = {0}", Ref);
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
                return new Famille( RefF, Nom);
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
            String query = String.Format("SELECT * FROM Familles WHERE Nom = '{0}'", NomF);
            DataTable table = helper.GetDataTable(query);
            if (table.Rows.Count == 0)
            {
                return null;
            }
            DataRow row = table.Rows[0];
            int RefF = Int32.Parse(row["RefFamille"].ToString());
            
            String Nom = row["Nom"].ToString();
            return new Famille( RefF, Nom);

        }

        public static void RemoveFamille(String databaseFile, int Ref)
        {

        }

        public static List<Famille> GetAll(String databaseFile)
        {
            SQLiteHelper helper = new SQLiteHelper(databaseFile);
            DataTable marquesTable = helper.GetDataTable("SELECT * FROM Familles");
            List<Famille> famille = new List<Famille>();
            foreach (DataRow r in marquesTable.Rows)
            {
                Famille familles = new Famille(Int32.Parse(r["RefFamille"].ToString()), r["Nom"].ToString());
                famille.AddFamille(familles);
            }
            return famille;
     
        }

        public static int GetSize(String databaseFile)
        {
            SQLiteHelper helper = new SQLiteHelper(databaseFile);
            String query = String.Format("SELECT * FROM Familles");
            DataTable marquesTable = helper.GetDataTable(query);
            return marquesTable.Rows.Count;
        }
    }
}
