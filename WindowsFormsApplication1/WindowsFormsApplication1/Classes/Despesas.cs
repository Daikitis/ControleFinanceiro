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
    class Despesas
    {
        public int IdDespesa { get; set; }
        public string NmDespesa { get; set; }
        public decimal ValorDespesa { get; set; }
        public decimal ValorMulta { get; set; }
        public string DataVencimento { get; set; }
        public int DespesaFixa{ get; set; }
        public string Obs { get; set; }
        public int Mes { get; set; }
        public int Ano { get; set; }

        public daoDespesa daoDespesa { get; set; }


        public Despesas()
        {
            this.daoDespesa = new daoDespesa();
        }

        public int InserirDespesa(Despesas despesas)
        {
            return this.daoDespesa.InserirDespesa(despesas);
        }

        public int ExcluirRenda(Despesas despesas)
        {
            return this.daoDespesa.ExcluirDespesa(despesas);
        }

        public DataTable ListarRenda()
        {
            return this.daoDespesa.ListarDespesa();
        }
    }
}
