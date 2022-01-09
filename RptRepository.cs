using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIAutofac
{
    public class RptRepository : IRptRepository
    {
        public RptRepository()
        {

        }

        public DataSet Writedata(string con, string sp)
        {
            DataSet dataSet = new();
            try
            {
                dataSet = GetData(con, sp);
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return dataSet;
        }

        private DataSet GetData(string _con, string _p)
        {
            SqlCommand cmd = new();
            try
            {
                SqlConnection sqlConnection = new();
                cmd = new SqlCommand(_p, sqlConnection)
                {
                    CommandTimeout = 600
                };

                var ds = new DataSet();
                cmd.Connection.Open();
                SqlDataAdapter sqlDataAdapter = new();
                sqlDataAdapter.Fill(ds);

                return ds;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (cmd != null)
                    cmd.Connection.Close();
            }
        }
    }
}
