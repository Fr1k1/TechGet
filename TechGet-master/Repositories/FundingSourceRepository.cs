using DBLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechGet.Models;

namespace TechGet.Repositories
{
    public class FundingSourceRepository
    {
        public static FundingSource GetFundingSource(int id)
        {
            FundingSource fundingSource = null;

            string sql = $"SELECT * FROM Izvori_financiranja WHERE Id='{id}'";

            DB.SetConfiguration("mfriscic20_DB", "mfriscic20", "'3;Y!xv0?'");
            DB.OpenConnection();
            var reader= DB.GetDataReader(sql);
            if(reader.HasRows)
            {
                reader.Read();
                fundingSource = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return fundingSource;
        }

        public static List<FundingSource> GetFundingSources()
        {
            var fundingSources=new List<FundingSource>();
            string sql = "SELECT * FROM Izvori_financiranja ";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                FundingSource fundingSource = CreateObject(reader);
                fundingSources.Add(fundingSource);
            }

            reader.Close();
            DB.CloseConnection();

            return fundingSources;
        }

        private static FundingSource CreateObject(SqlDataReader reader)
        {
            int id = int.Parse(reader["Id"].ToString());
            float iznos = float.Parse(reader["Iznos"].ToString());
            string naziv = reader["Naziv"].ToString();
           

            var fundingSource = new FundingSource
            {
                Id = id,
                Iznos = iznos,
                Naziv = naziv,
             
            };

            return fundingSource;

        }
    }
}
