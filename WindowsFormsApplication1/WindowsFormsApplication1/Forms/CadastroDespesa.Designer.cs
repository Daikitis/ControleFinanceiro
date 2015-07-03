namespace Forms
{
    partial class CadastroDespesa
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtValorDespesa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbDespesaFixa = new System.Windows.Forms.CheckBox();
            this.dtDataVencimento = new System.Windows.Forms.DateTimePicker();
            this.txtNmDespesa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtValorMulta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Data Vencto.: ";
            // 
            // txtValorDespesa
            // 
            this.txtValorDespesa.Location = new System.Drawing.Point(94, 52);
            this.txtValorDespesa.Name = "txtValorDespesa";
            this.txtValorDespesa.Size = new System.Drawing.Size(172, 20);
            this.txtValorDespesa.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Valor: ";
            // 
            // cbDespesaFixa
            // 
            this.cbDespesaFixa.AutoSize = true;
            this.cbDespesaFixa.Location = new System.Drawing.Point(29, 160);
            this.cbDespesaFixa.Name = "cbDespesaFixa";
            this.cbDespesaFixa.Size = new System.Drawing.Size(90, 17);
            this.cbDespesaFixa.TabIndex = 4;
            this.cbDespesaFixa.Text = "Despesa Fixa";
            this.cbDespesaFixa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbDespesaFixa.UseVisualStyleBackColor = true;
            // 
            // dtDataVencimento
            // 
            this.dtDataVencimento.Location = new System.Drawing.Point(98, 205);
            this.dtDataVencimento.Name = "dtDataVencimento";
            this.dtDataVencimento.Size = new System.Drawing.Size(241, 20);
            this.dtDataVencimento.TabIndex = 5;
            // 
            // txtNmDespesa
            // 
            this.txtNmDespesa.Location = new System.Drawing.Point(73, 13);
            this.txtNmDespesa.Name = "txtNmDespesa";
            this.txtNmDespesa.Size = new System.Drawing.Size(519, 20);
            this.txtNmDespesa.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Despesa: ";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(517, 351);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtValorMulta
            // 
            this.txtValorMulta.Location = new System.Drawing.Point(94, 90);
            this.txtValorMulta.Name = "txtValorMulta";
            this.txtValorMulta.Size = new System.Drawing.Size(172, 20);
            this.txtValorMulta.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Valor Multa: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Observações: ";
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(25, 254);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(567, 91);
            this.txtObs.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Tipo Despesa: ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Alimentação",
            "Moradia",
            "Educação",
            "Animal de Estimação",
            "Saúde",
            "Transporte",
            "Pessoais",
            "Lazer",
            "Serviços Financeiros"});
            this.comboBox1.Location = new System.Drawing.Point(94, 127);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(245, 21);
            this.comboBox1.TabIndex = 26;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(365, 52);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 27;
            // 
            // CadastroDespesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 382);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtObs);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtValorMulta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtValorDespesa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbDespesaFixa);
            this.Controls.Add(this.dtDataVencimento);
            this.Controls.Add(this.txtNmDespesa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalvar);
            this.Name = "CadastroDespesa";
            this.Text = "Cadastro de Despesas";
            this.Load += new System.EventHandler(this.CadastroDespesa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValorDespesa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbDespesaFixa;
        private System.Windows.Forms.DateTimePicker dtDataVencimento;
        private System.Windows.Forms.TextBox txtNmDespesa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtValorMulta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}