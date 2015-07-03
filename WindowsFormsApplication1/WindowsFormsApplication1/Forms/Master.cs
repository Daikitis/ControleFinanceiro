using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Forms;

namespace WindowsFormsApplication1
{
    public partial class Master : Form
    {
        public Master()
        {
            InitializeComponent();
        }

        private void mostrarRendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            VisualizarRendas VisualizarRendas = new VisualizarRendas();
            VisualizarRendas.MdiParent = this;
            VisualizarRendas.Show();
        }

        private void cadastroDeRendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            CadastroRenda CadastroRenda = new CadastroRenda();
            CadastroRenda.MdiParent = this;
            CadastroRenda.Show();
        }

        private void cadastroDeDespesasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            CadastroDespesa CadastroDespesa = new CadastroDespesa();
            CadastroDespesa.MdiParent = this;
            CadastroDespesa.Show();
        }

        private void exibirDespesasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            VisualizarDespesas VisualizarDespesas = new VisualizarDespesas();
            VisualizarDespesas.MdiParent = this;
            VisualizarDespesas.Show();
        }

        private void balançoMensalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            BalancoMensal BalancoMensal = new BalancoMensal();
            BalancoMensal.MdiParent = this;
            BalancoMensal.Show();
        }

        private void balançoAnualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            BalancoAnual BalancoAnual = new BalancoAnual();
            BalancoAnual.MdiParent = this;
            BalancoAnual.Show();
        }

        private void balançoSemestralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            BalancoSemestral BalancoSemestral = new BalancoSemestral();
            BalancoSemestral.MdiParent = this;
            BalancoSemestral.Show();
        }
    }
}
