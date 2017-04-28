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
    public class Article
    {
        public string Ref_Article { get; set; }
        public string Description { get; set; }
        public float PrixHT { get; set; }
        public int Quantite { get; set; }
        public int Ref_Sous_Famille { get; set; }
        public int Ref_Marque { get; set; }
        /*
         * @param refARTICLE  description prix quantite refsousfamille refmarque
         * constructeur
         */
        public Article(string RefA, string Desc, float Prix, int Quantite, int RefSF, int RefM)
        {
            this.Ref_Article = RefA;
            this.Description = Desc;
            this.PrixHT = Prix;
            this.Quantite = Quantite;
            this.Ref_Sous_Famille = RefSF;
            this.Ref_Marque = RefM;
        }

        /*
        * @param databasefile articl
        * inserer un article dans la base
        */
        public static void InsertArticle(String databaseFile, Article article)
        {
            SQLiteHelper helper = new SQLiteHelper(databaseFile);
            Dictionary<String, Object> data = new Dictionary<String, Object>();
            data.Add("RefArticle", article.Ref_Article);
            data.Add("Description", article.Description);
            data.Add("RefSousFamille", article.Ref_Sous_Famille);
            data.Add("RefMarque", article.Ref_Marque);
            data.Add("PrixHT", article.PrixHT);
            data.Add("Quantite", article.Quantite);
            helper.Insert(Configuration.ARTICLE_TABLE_NAME, data);
        }

        /*
        * @param databasefile ref
        * chercher un article dans la base
         * @return article
        */
        public static Article FindArticle(String databaseFile, string Ref)
        {
            SQLiteHelper helper = new SQLiteHelper(databaseFile);
            String query = String.Format("SELECT * FROM {0} WHERE RefArticle = '{1}'", Configuration.ARTICLE_TABLE_NAME, Ref);
            try
            {
                DataTable table = helper.GetDataTable(query);
                if (table.Rows.Count == 0)
                {
                    return null;
                }
                DataRow row = table.Rows[0];
                String RefArticle = row["RefArticle"].ToString();
                String Description = row["Description"].ToString();
                float PrixHT = float.Parse(row["PrixHT"].ToString());
                int Quantite = int.Parse(row["Quantite"].ToString());
                int RefSousFamille = Int32.Parse(row["RefSousFamille"].ToString());
                int RefMarque = Int32.Parse(row["RefMarque"].ToString());
                return new Article(RefArticle, Description, PrixHT, Quantite, RefSousFamille, RefMarque);
            }
            catch (Exception e)
            {
                Console.WriteLine("Find Article error : " + e.Message);
                return null;
            }
        }

        /*
       * @param databasefile ref
       * supprimer un article de la base
       */
        public static void RemoveArticle(String databaseFile, string Ref)
        {
            SQLiteHelper helper = new SQLiteHelper(databaseFile);
            helper.Delete(Configuration.ARTICLE_TABLE_NAME, String.Format("RefArticle = '{0}'", Ref));
        }

        public static void UpdateArticle(String databaseFile, Article article)
        {
            SQLiteHelper helper = new SQLiteHelper(databaseFile);
            Dictionary<String, Object> data = new Dictionary<String, Object>();
            data.Add("Description", article.Description);
            data.Add("RefSousFamille", article.Ref_Sous_Famille);
            data.Add("RefMarque", article.Ref_Marque);
            data.Add("PrixHT", article.PrixHT);
            data.Add("Quantite", article.Quantite);
            helper.Update(Configuration.ARTICLE_TABLE_NAME, data, String.Format("RefArticle = '{0}'", article.Ref_Article));
        }

        /*
         * @param databasefile 
         * recuperer tous les informations sur l'article
         * @return list d'article
        */
        public static List<Article> GetAll(String databaseFile)
        {
            SQLiteHelper helper = new SQLiteHelper(databaseFile);
            List<Article> articles = new List<Article>();
            try
            {
                DataTable table = helper.GetDataTable(String.Format("SELECT * FROM {0}", Configuration.ARTICLE_TABLE_NAME));
                foreach (DataRow r in table.Rows)
                {
                    Article article = new Article(
                        r["RefArticle"].ToString(),
                        r["Description"].ToString(), 
                        float.Parse(r["PrixHT"].ToString()),
                        int.Parse(r["Quantite"].ToString()),
                        Int32.Parse(r["RefSousFamille"].ToString()),
                        Int32.Parse(r["RefMarque"].ToString()));
                    articles.Add(article);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("GetAll error : " + e.Message);
            }
            return articles;
        }

        /*
         * @param databasefile 
        * supprimer un article de la table
         * @return bool
         */
        public static bool ClearArticleTable(String databaseFile)
        {
            SQLiteHelper helper = new SQLiteHelper(databaseFile);
            return helper.ClearTable(Configuration.ARTICLE_TABLE_NAME);
        }

        /*
       * @param databasefile ref
       * récuperer la taille de table
        * @return size
       */
        public static int GetSize(String databaseFile)
        {
            SQLiteHelper helper = new SQLiteHelper(databaseFile);
            String query = String.Format("SELECT Count(*) AS count FROM {0}", Configuration.ARTICLE_TABLE_NAME);
            DataTable table = helper.GetDataTable(query);
            DataRow r = table.Rows[0];
            return Int32.Parse(r["count"].ToString());
        }
    }
}
