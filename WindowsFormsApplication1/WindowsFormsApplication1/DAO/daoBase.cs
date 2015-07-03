using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAO
{
    class daoBase
    {

        protected string connString = ConfigurationManager.ConnectionStrings["SenacPos2015ConnectionString"].ToString();
        protected SqlConnection conexao { get; set; }
        protected SqlCommand comando { get; set; }

        public daoBase()
        {
            conexao = new SqlConnection(connString);
            comando = new SqlCommand();
        }

    }
}
