using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAO;

namespace Classes
{
    class Rendas
    {
        public int IdRenda { get; set; }
        public string NmRenda { get; set; }
        public double ValorRenda { get; set; }
        public string DiaEntrada { get; set; }
        public string RendaFixa { get; set; }
        public string Obs { get; set; }
        
        public daoRenda daoRenda { get; set; }


        public Rendas()
        {
            this.daoRenda = new daoRenda();
        }

        public int InserirRenda(Rendas rendas)
        {
            return this.daoRenda.InserirRenda(rendas);
        }

        public int ExcluirRenda(Rendas rendas)
        {
            return this.daoRenda.ExcluirRenda(rendas);
        }

        public DataTable ListarRenda()
        {
            return this.daoRenda.ListarRenda();
        }
    }
}
