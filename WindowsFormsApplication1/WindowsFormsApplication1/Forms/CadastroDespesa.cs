using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Classes;
using DAO;

namespace Forms
{
    public partial class CadastroDespesa : Form
    {
        public CadastroDespesa()
        {
            InitializeComponent();
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Despesas Despesas = new Despesas();

            Despesas.IdDespesa = 3;
            Despesas.NmDespesa = txtNmDespesa.Text;
            Despesas.ValorDespesa = decimal.Parse(txtValorDespesa.Text, System.Globalization.NumberStyles.Currency);
            Despesas.ValorMulta = decimal.Parse(!string.IsNullOrEmpty(txtValorMulta.Text) ? txtValorMulta.Text : "0", System.Globalization.NumberStyles.Currency);
            Despesas.DataVencimento = dtDataVencimento.Value.ToString("dd/MM/yyyy");
            string[] datas = dtDataVencimento.Value.ToString().Split('/');
            string[] str_ano = datas[2].Split(' ');
            Despesas.DespesaFixa = cbDespesaFixa.Checked ? 1:0;
            Despesas.Obs = txtObs.Text;
            Despesas.Mes = int.Parse(datas[1]);
            Despesas.Ano = int.Parse(str_ano[0]);

            try
            {
                string message = string.Empty;
                string caption = string.Empty;

                if (Despesas.InserirDespesa(Despesas) > 0)
                {
                    message = "Dados cadastrados com sucesso!!";
                    caption = "Ok";
                    LimparDados();
                }
                else
                {
                    message = "Ocorreu um erro ao tentar salvar os dados.";
                    caption = "Erro ao cadastrar Dados!!";
                }

                
                DialogResult result;
                result = MessageBox.Show(message, caption);
            }
            catch (Exception ex)
            {
                string message = ex.ToString();
                string caption = "Erro ao cadastrar Dados!! (Excessão)";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
            }

        }

        public void LimparDados()
        {
            txtNmDespesa.Text = string.Empty;
            txtValorDespesa.Text = string.Empty;
            txtValorMulta.Text = string.Empty;
            dtDataVencimento.Value = DateTime.Today;
            cbDespesaFixa.Checked = false;
            txtObs.Text = string.Empty;
        }

        private void CadastroDespesa_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'senacPos2015DataSet.Despesas'. Você pode movê-la ou removê-la conforme necessário.
            

        }
    }
}
