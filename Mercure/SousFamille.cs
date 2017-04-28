using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

/*
 * @author : HOUDA BOUTBIB et MOHAMMED ELMOUTARAJI
 * */

namespace Mercure
{
    public class SousFamille
    {
        public int Ref_Sous_Famille { get; set; }
        public int Ref_Famille { get; set; }
        public string Nom { get; set; }

        /*
       * @param refsousfamille reffamille nom
       * constructeur
       */
        public SousFamille(int refSF, int refF, String n)
        {
            Ref_Sous_Famille = refSF;
            Ref_Famille = refF;
            Nom = n;
        }


        /*
       * @param databasefile sousfamille
       * inserer une sous famille dans la table
       */
        public static void InsertSousFamille(String databaseFile, SousFamille sousF)
        {
            SQLiteHelper helper = new SQLiteHelper(databaseFile);
            Dictionary<String, Object> data = new Dictionary<String, Object>();
            data.Add("RefSousFamille", sousF.Ref_Sous_Famille);
            data.Add("RefFamille", sousF.Ref_Famille);
            data.Add("Nom", sousF.Nom);
            helper.Insert(Configuration.SOUS_FAMILLE_TABLE_NAME, data);
        }

        /*
       * @param databasefile ref
       * chercher une sous famille
       * @return sousfamille
       */
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

        /*
       * @param databasefile nom
       * chercher par nom une sous famille
       * @return sousfamille
       */
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

        /*
       * @param databasefile sousfamille
       * mettre a jours une sous famille
       */
        public static void UpdateSousFamille(String databaseFile, SousFamille sousFamille)
        {
            SQLiteHelper helper = new SQLiteHelper(databaseFile);
            Dictionary<String, Object> data = new Dictionary<String, Object>();
            data.Add("Nom", sousFamille.Nom);
            data.Add("RefFamille", sousFamille.Ref_Famille);
            helper.Update(Configuration.SOUS_FAMILLE_TABLE_NAME, data, String.Format("RefSousFamille = {0}", sousFamille.Ref_Sous_Famille));
        }
        /*
       * @param databasefile ref
       * supprimer une sous famille de la table
       */
        public static void RemoveSousFamille(String databaseFile, int Ref)
        {
            SQLiteHelper helper = new SQLiteHelper(databaseFile);
            helper.Delete(Configuration.SOUS_FAMILLE_TABLE_NAME, String.Format("RefSousFamille = {0}", Ref));
        }

        /*
       * @param databasefile 
       * recuperer les informations d'une sous famille
       * @return listde sous famille
       */
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

        /*
       * @param databasefile 
       * @return size
       * recuperer la taille 
       */
        public static int GetSize(String databaseFile)
        {
            SQLiteHelper helper = new SQLiteHelper(databaseFile);
            String query = String.Format("SELECT Count(*) AS count FROM {0}", Configuration.SOUS_FAMILLE_TABLE_NAME);
            DataTable table = helper.GetDataTable(query);
            DataRow r = table.Rows[0];
            return Int32.Parse(r["count"].ToString());
        }
    }
}
