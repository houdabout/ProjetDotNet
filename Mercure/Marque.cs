using System;
using System.Collections.Generic;
using System.Data;

/*
 * @author : HOUDA BOUTBIB et MOHAMMED ELMOUTARAJI
 * */
namespace Mercure
{
    public class Marque
    {


        /*
        * @param refmarque string
        * constructeur
        */ 
        public Marque(int refM, string n)
        {
            Ref_Marque = refM;
            Nom = n;
        }

        public int Ref_Marque { get; set; }
        public string Nom { get; set; }

        /*
       * @param databasefile marque
       * inserer une marque dans la base
       */ 
        public static void InsertMarque(String databaseFile, Marque marque)
        {
            SQLiteHelper helper = new SQLiteHelper(databaseFile);
            Dictionary<String, Object> data = new Dictionary<String, Object>();
            data.Add("RefMarque", marque.Ref_Marque);
            data.Add("Nom", marque.Nom);
            helper.Insert(Configuration.MARQUE_TABLE_NAME, data);
        }

        /*
      * @param databasefile ref
      * chercher une marque dans la base
      *@return marque
      */ 
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

        /*
     * @param databasefile marque
     * mettre a jours une marque
     */ 
        public static void UpdateMarque(String databaseFile, Marque marque)
        {
            SQLiteHelper helper = new SQLiteHelper(databaseFile);
            Dictionary<String, Object> data = new Dictionary<String, Object>();
            data.Add("Nom", marque.Nom);
            helper.Update(Configuration.MARQUE_TABLE_NAME, data, String.Format("RefMarque = {0}", marque.Ref_Marque));
        }

        /*
    * @param databasefile ref
    * voir si une marque est dans la base
    */ 
        public static Boolean IsMarqueExist(String databaseFile, int Ref)
        {
            return FindMarque(databaseFile, Ref) != null;
        }

        /*
    * @param databasefile nom
    * chercher une marque par nom
    * @return marque
    */ 
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

        /*
    * @param databasefile ref
    * supprimer une marque de la base
    */ 
        public static void RemoveMarque(String databaseFile, int Ref)
        {
            SQLiteHelper helper = new SQLiteHelper(databaseFile);
            helper.Delete(Configuration.MARQUE_TABLE_NAME, String.Format("RefMarque = {0}", Ref));
        }

        /*
    * @param databasefile 
    * recuperer les informations d'une marque
    * @list de marque
    */ 
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

        /*
    * @param databasefile
    * supprimer la table marque
    * @return bool
    */ 
        public static bool ClearMarqueTable(String databaseFile)
        {
            SQLiteHelper helper = new SQLiteHelper(databaseFile);
            return helper.ClearTable(Configuration.MARQUE_TABLE_NAME);
        }

    /*
    * @param databasefile 
    * recupererla taille
    * @return size
    */ 

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
