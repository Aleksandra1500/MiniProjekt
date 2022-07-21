using Dapper;
using MiniProjekt.DAL;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace MiniProjekt
{
    public static class DataService
    {
        #region DAPPER
        public static List<Email> GetAllEmails()
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cnS"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                {
                    db.Open();
                }

                return db.Query<Email>("select * from adr_Email").ToList();
            }
        }

        public static void DeleteRow()
        {
            string deleteSql = "delete from adr_Email";
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cnS"].ConnectionString))
            {
                
                var affectedRow = connection.Execute(deleteSql);
            }
        }
        #endregion
    }
}