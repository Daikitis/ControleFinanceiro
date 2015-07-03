using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Classes;
using System.Windows.Forms;
namespace DAO
{
    class daoDespesa : daoBase
    {
        private string Insert = @"
                                  INSERT INTO [Despesas] ( [NmDespesa], [DespesaFixa], [ValorDespesa], [DataVencimento], [ValorMulta], [Obs], [Mes], [Ano]) 
                                  VALUES (N'@NMDESPESA', @DESPESAFIXA, CAST(@VALORDESPESA AS Decimal(18, 0)), @DATAVENCIMENTO, CAST(@VALORMULTA AS Decimal(18, 0)), N'@OBS', @MES, @ANO);
                                  ";

        private string Update = @"UPDATE DESPESAS SET NmDespesa = @NMDESPESA
                                                      ,ValorDespesa = @VALORDESPESA
                                                      ,ValorMulta = @VALORMULTA
                                                      ,DataVencimento = @DATAVENCIMENTO
                                                      ,DespesaFixa = @DESPESAFIXA
                                                      ,Obs = @OBS
                                  WHERE IdDespesa = @IDDESPESA";

        private string Delete = @"DELETE FROM DESPESAS WHERE IdDespesa = @IDDESPESA";

        private string Select = @"SELECT IDDESPESA
                                        ,NMDESPESA
                                        ,VALORDESPESA
                                        ,VALORMULTA
                                        ,DATAVENCIMENTO
                                        ,DESPESAFIXA
                                        ,OBS 
                                  FROM DESPESAS";

        private string SelectSpecific = @"SELECT IDDESPESA
                                                ,NMDESPESA
                                                ,VALORDESPESA
                                                ,VALORMULTA
                                                ,DATAVENCIMENTO
                                                ,DESPESAFIXA
                                                ,OBS 
                                         FROM DESPESAS WHERE NMDESPESA =  LIKE '%'+ @NMDESPESA +'%'";

        public daoDespesa()
        {
            base.conexao = new SqlConnection(base.connString);
            base.comando = new SqlCommand();
            base.comando.Connection = base.conexao;
        }

        public int InserirDespesa(Despesas despesas)
        {
            int objeto = 0;

            try
            {
                var paramIdDespesa = new SqlParameter("@IDDESPESA", despesas.IdDespesa);
                var paramNmDespesa = new SqlParameter("@NMDESPESA", despesas.NmDespesa);
                var paramValorDespesa = new SqlParameter("@VALORDESPESA", despesas.ValorDespesa);
                var paramValorMulta = new SqlParameter("@VALORMULTA", despesas.ValorMulta);
                var paramDataVencimento = new SqlParameter("@DATAVENCIMENTO", despesas.DataVencimento);
                var paramDespesaFixa = new SqlParameter("@DESPESAFIXA", despesas.DespesaFixa);
                var paramObs = new SqlParameter("@OBS", despesas.Obs);
                var paramMes = new SqlParameter("@MES", despesas.Mes);
                var paramAno = new SqlParameter("@ANO", despesas.Ano);

                base.comando.CommandText = Insert;

                base.comando.Parameters.Add(paramIdDespesa);
                base.comando.Parameters.Add(paramNmDespesa);
                base.comando.Parameters.Add(paramValorDespesa);
                base.comando.Parameters.Add(paramValorMulta);
                base.comando.Parameters.Add(paramDataVencimento);
                base.comando.Parameters.Add(paramDespesaFixa);
                base.comando.Parameters.Add(paramObs);
                base.comando.Parameters.Add(paramMes);
                base.comando.Parameters.Add(paramAno);

                base.conexao.Open();
                try
                {
                    objeto = base.comando.ExecuteScalar() != null ? 1 : 0;
                }
                catch (Exception ex)
                {
                    string message = ex.ToString();
                    string caption = "Erro ao cadastrar Dados!! (Excessão)";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;
                    result = MessageBox.Show(message, caption, buttons);
                }
                //base.comando.ExecuteScalar();
            }
            finally
            {
                base.conexao.Close();
                base.comando.Parameters.Clear();
            }

            return objeto;
        }

        public int ExcluirDespesa(Despesas despesas)
        {
            var IdDespesa = 0;

            try
            {
                var paramIdDespesa = new SqlParameter("@IDDESPESA", despesas.IdDespesa);
                var paramNmDespesa = new SqlParameter("@NMDESPESA", despesas.NmDespesa);
                var paramValorDespesa = new SqlParameter("@VALORDESPESA", despesas.ValorDespesa);
                var paramValorMulta = new SqlParameter("@VALORMULTA", despesas.ValorMulta);
                var paramDataVencimento = new SqlParameter("@DATAVENCIMENTO", despesas.DataVencimento);
                var paramDespesaFixa = new SqlParameter("@DESPESAFIXA", despesas.DespesaFixa);
                var paramObs = new SqlParameter("@OBS", despesas.Obs);

                base.comando.CommandText = Delete;
                base.comando.Parameters.Add(paramIdDespesa);
                base.comando.Parameters.Add(paramNmDespesa);
                base.comando.Parameters.Add(paramValorDespesa);
                base.comando.Parameters.Add(paramValorMulta);
                base.comando.Parameters.Add(paramDataVencimento);
                base.comando.Parameters.Add(paramDespesaFixa);
                base.comando.Parameters.Add(paramObs);

                base.conexao.Open();
                IdDespesa = Convert.ToInt32(base.comando.ExecuteScalar());
            }
            finally
            {
                base.conexao.Close();
                base.comando.Parameters.Clear();
            }

            return IdDespesa;
        }

        public DataTable ListarDespesa()
        {
            try
            {
                var tabelaDespesas = new DataTable();

                base.comando.CommandText = Select;
                var dataReader = base.comando.ExecuteReader();

                tabelaDespesas.Load(dataReader);

                return tabelaDespesas;
            }
            finally
            {
                base.conexao.Close();
                base.comando.Parameters.Clear();
            }
        }
    }
}
