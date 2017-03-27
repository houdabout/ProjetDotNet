using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Mercure
{
    public class Article
    {
        public string RefArticle { get; set; }
        public string Description { get; set; }
        public int RefSousFamille { get; set; }
        public int RefMarque { get; set; }
        public float PrixHT { get; set; }
        public int Quantite { get; set; }

        public Article(string RefA, string Desc, float Prix, int Quantite, int RefSF, int RefM)
        {
            this.RefArticle = RefA;
            this.Description = Desc;
            this.PrixHT = Prix;
            this.Quantite = Quantite;
            this.RefSousFamille = RefSF;
            this.RefMarque = RefM;
        }

        public static void AddArticle(String databaseFile, Article article)
        {

        }

        public static Article FindArticle(String databaseFile, string Ref)
        {
            return null;
        }

        public static void RemoveArticle(String databaseFile, string Ref)
        {

        }

        public static List<Article> GetAll(String databaseFile)
        {
            return null;
        }
    }
}
