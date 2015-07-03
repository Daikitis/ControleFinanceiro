namespace Forms
{
    partial class BalancoMensal
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
            this.Total});
            this.dataGridView1.Location = new System.Drawing.Point(4, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(898, 338);
            this.dataGridView1.TabIndex = 2;
            // 
            // Rendas
            // 
            this.Rendas.HeaderText = "Rendas";
            this.Rendas.Name = "Rendas";
            this.Rendas.Width = 350;
            // 
            // Despesas
            // 
            this.Despesas.HeaderText = "Despesas";
            this.Despesas.Name = "Despesas";
            this.Despesas.Width = 350;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.Width = 150;
            // 
            // BalancoAnual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 362);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BalancoAnual";
            this.Text = "Balanço Mensal";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rendas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Despesas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}