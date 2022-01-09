using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DIAutofac
{
    public class RptService : IRptService
    {
        private readonly IRptRepository _rep;

        public RptService()
        {

        }

        public DataSet Write(string _con, string _sp)
        {
            DataSet ds = _rep.Writedata(_con, _sp);
            return ds;
        }
    }
}
