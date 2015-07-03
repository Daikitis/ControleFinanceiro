namespace Forms
{
    partial class BalancoAnual
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Rendas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Despesas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Abr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jul = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Set = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Out = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dez = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Rendas,
            this.Despesas,
            this.Fev,
            this.Mar,
            this.Abr,
            this.Mai,
            this.Jun,
            this.Jul,
            this.Ago,
            this.Set,
            this.Out,
            this.Nov,
            this.Dez,
            this.Total});
            this.dataGridView1.Location = new System.Drawing.Point(12, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(894, 350);
            this.dataGridView1.TabIndex = 2;
            // 
            // Rendas
            // 
            this.Rendas.HeaderText = "Tipo Movimento";
            this.Rendas.Name = "Rendas";
            this.Rendas.Width = 150;
            // 
            // Despesas
            // 
            this.Despesas.HeaderText = "Jan";
            this.Despesas.Name = "Despesas";
            this.Despesas.Width = 50;
            // 
            // Fev
            // 
            this.Fev.HeaderText = "Fev";
            this.Fev.Name = "Fev";
            this.Fev.Width = 50;
            // 
            // Mar
            // 
            this.Mar.HeaderText = "Mar";
            this.Mar.Name = "Mar";
            this.Mar.Width = 50;
            // 
            // Abr
            // 
            this.Abr.HeaderText = "Abr";
            this.Abr.Name = "Abr";
            this.Abr.Width = 50;
            // 
            // Mai
            // 
            this.Mai.HeaderText = "Mai";
            this.Mai.Name = "Mai";
            this.Mai.Width = 50;
            // 
            // Jun
            // 
            this.Jun.HeaderText = "Jun";
            this.Jun.Name = "Jun";
            this.Jun.Width = 50;
            // 
            // Jul
            // 
            this.Jul.HeaderText = "Jul";
            this.Jul.Name = "Jul";
            this.Jul.Width = 50;
            // 
            // Ago
            // 
            this.Ago.HeaderText = "Ago";
            this.Ago.Name = "Ago";
            this.Ago.Width = 50;
            // 
            // Set
            // 
            this.Set.HeaderText = "Set";
            this.Set.Name = "Set";
            this.Set.Width = 50;
            // 
            // Out
            // 
            this.Out.HeaderText = "Out";
            this.Out.Name = "Out";
            this.Out.Width = 50;
            // 
            // Nov
            // 
            this.Nov.HeaderText = "Nov";
            this.Nov.Name = "Nov";
            this.Nov.Width = 50;
            // 
            // Dez
            // 
            this.Dez.HeaderText = "Dez";
            this.Dez.Name = "Dez";
            this.Dez.Width = 50;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // BalancoAnual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 362);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BalancoAnual";
            this.Text = "Balanço Anual";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource senacPos2015DataSetBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rendas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Despesas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fev;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Abr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jun;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jul;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ago;
        private System.Windows.Forms.DataGridViewTextBoxColumn Set;
        private System.Windows.Forms.DataGridViewTextBoxColumn Out;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nov;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dez;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}