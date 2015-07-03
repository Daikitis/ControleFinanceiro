using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class VisualizarDespesas : Form
    {
        public VisualizarDespesas()
        {
            InitializeComponent();
        }

        private void VisualizarRendas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'senacPos2015DataSet.Despesas'. Você pode movê-la ou removê-la conforme necessário.
            this.despesasTableAdapter.Fill(this.senacPos2015DataSet.Despesas);
            // TODO: esta linha de código carrega dados na tabela 'senacPos2015DataSet.Rendas'. Você pode movê-la ou removê-la conforme necessário.
            this.rendasTableAdapter.Fill(this.senacPos2015DataSet.Rendas);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
