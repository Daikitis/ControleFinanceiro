using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes;

namespace DAO
{
    class daoRenda : daoBase
    {
        private string Insert = @"INSERT INTO RENDAS VALUES (@NMRENDA, @VALORRENDA, @DIAENTRADA, @OBS);
                                  SELECT SCOPE_IDENTITY();";

        private string Update = @"UPDATE RENDAS SET NmRenda = @NMRENDA
                                                  ,ValorRenda = @VALORRENDA
                                                  ,DiaEntrada = @DIAENTRADA
                                                  ,Obs = @OBS
                                  WHERE IdRenda = @IDRENDA";
        
        private string Delete = @"DELETE FROM RENDAS WHERE IdRenda = @IDRENDA";
        
        private string Select = @"SELECT IDRENDA
                                        ,NMRENDA
                                        ,VALORRENDA
                                        ,DIAENTRADA
                                        ,OBS
                                  FROM RENDAS";

        private string SelectSpecific = @"SELECT IDRENDA
                                                ,NMRENDA
                                                ,VALORRENDA
                                                ,DIAENTRADA
                                                ,OBS 
                                         FROM RENDAS WHERE NMRENDA =  LIKE '%'+ @NMRENDA +'%'";

        public daoRenda()
        {
            base.conexao = new SqlConnection(base.connString);
            base.comando = new SqlCommand();
            base.comando.Connection = base.conexao;
        }

        public int InserirRenda(Rendas rendas)
        {
            var rendaId = 0;

            try
            {
                var paramIdRenda = new SqlParameter("@IDRenda", rendas.IdRenda);
                var paramNmRenda = new SqlParameter("@NMRENDA", rendas.NmRenda);
                var paramValorRenda = new SqlParameter("@VALORRENDA", rendas.ValorRenda);
                var paramDiaEntrada = new SqlParameter("@DIAENTRADA", rendas.DiaEntrada);
                var paramRendaFixa = new SqlParameter("@RENDAFIXA", rendas.RendaFixa);
                var paramObs = new SqlParameter("@OBS", rendas.Obs);

                base.comando.CommandText = Insert;
                base.comando.Parameters.Add(paramIdRenda);
                base.comando.Parameters.Add(paramNmRenda);
                base.comando.Parameters.Add(paramValorRenda);
                base.comando.Parameters.Add(paramDiaEntrada);
                base.comando.Parameters.Add(paramRendaFixa);
                base.comando.Parameters.Add(paramObs);

                base.conexao.Open();
                rendaId = Convert.ToInt32(base.comando.ExecuteScalar());
            }
            finally
            {
                base.conexao.Close();
                base.comando.Parameters.Clear();
            }

            return rendaId;
        }

        public int ExcluirRenda(Rendas rendas)
        {
            var rendaId = 0;

            try
            {
                var paramIdRenda = new SqlParameter("@IDRenda", rendas.IdRenda);
                var paramNmRenda = new SqlParameter("@NMRENDA", rendas.NmRenda);
                var paramValorRenda = new SqlParameter("@VALORRENDA", rendas.ValorRenda);
                var paramDiaEntrada = new SqlParameter("@DIAENTRADA", rendas.DiaEntrada);
                var paramRendaFixa = new SqlParameter("@RENDAFIXA", rendas.RendaFixa);
                var paramObs = new SqlParameter("@OBS", rendas.Obs);

                base.comando.CommandText = Delete;
                base.comando.Parameters.Add(paramIdRenda);
                base.comando.Parameters.Add(paramNmRenda);
                base.comando.Parameters.Add(paramValorRenda);
                base.comando.Parameters.Add(paramDiaEntrada);
                base.comando.Parameters.Add(paramRendaFixa);
                base.comando.Parameters.Add(paramObs);

                base.conexao.Open();
                rendaId = Convert.ToInt32(base.comando.ExecuteScalar());
            }
            finally
            {
                base.conexao.Close();
                base.comando.Parameters.Clear();
            }

            return rendaId;
        }

        public DataTable ListarRenda()
        {
            try
            {
                var tabelaRendas = new DataTable();

                base.comando.CommandText = Select;
                var dataReader = base.comando.ExecuteReader();

                tabelaRendas.Load(dataReader);

                return tabelaRendas;
            }
            finally
            {
                base.conexao.Close();
                base.comando.Parameters.Clear();
            }
        }
        
    }
}
