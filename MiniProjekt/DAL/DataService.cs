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
        #endregion
    }
}