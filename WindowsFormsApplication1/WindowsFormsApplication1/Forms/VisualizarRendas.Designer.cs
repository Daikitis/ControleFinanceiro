﻿using System;
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
    partial class VisualizarRendas : Form
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
            this.senacPos2015DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.senacPos2015DataSet = new WindowsFormsApplication1.SenacPos2015DataSet();
            this.rendasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rendasTableAdapter = new WindowsFormsApplication1.SenacPos2015DataSetTableAdapters.RendasTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.SenacPos2015DataSetTableAdapters.TableAdapterManager();
            this.senacPos2015DataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Excluir = new System.Windows.Forms.DataGridViewImageColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Renda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fixa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rendasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.senacPos2015DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.senacPos2015DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rendasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.senacPos2015DataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rendasBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Excluir,
            this.Editar,
            this.Renda,
            this.Valor,
            this.DataEntrada,
            this.Fixa});
            this.dataGridView1.DataSource = this.senacPos2015DataSetBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(710, 352);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // senacPos2015DataSetBindingSource
            // 
            this.senacPos2015DataSetBindingSource.DataSource = this.senacPos2015DataSet;
            this.senacPos2015DataSetBindingSource.Position = 0;
            // 
            // senacPos2015DataSet
            // 
            this.senacPos2015DataSet.DataSetName = "SenacPos2015DataSet";
            this.senacPos2015DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rendasBindingSource
            // 
            this.rendasBindingSource.DataMember = "Rendas";
            this.rendasBindingSource.DataSource = this.senacPos2015DataSet;
            // 
            // rendasTableAdapter
            // 
            this.rendasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DespesasTableAdapter = null;
            this.tableAdapterManager.RendasTableAdapter = this.rendasTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication1.SenacPos2015DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // senacPos2015DataSetBindingSource1
            // 
            this.senacPos2015DataSetBindingSource1.DataSource = this.senacPos2015DataSet;
            this.senacPos2015DataSetBindingSource1.Position = 0;
            // 
            // Excluir
            // 
            this.Excluir.DataPropertyName = "IdRenda";
            this.Excluir.HeaderText = "Excluir";
            this.Excluir.Image = global::WindowsFormsApplication1.Properties.Resources.Vista__152_;
            this.Excluir.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Excluir.Name = "Excluir";
            this.Excluir.ReadOnly = true;
            this.Excluir.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Excluir.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Image = global::WindowsFormsApplication1.Properties.Resources.Vista__151_;
            this.Editar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Editar.Name = "Editar";
            this.Editar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Editar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Renda
            // 
            this.Renda.DataPropertyName = "NmRenda";
            this.Renda.HeaderText = "Renda";
            this.Renda.Name = "Renda";
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            // 
            // DataEntrada
            // 
            this.DataEntrada.HeaderText = "Data de Entrada";
            this.DataEntrada.Name = "DataEntrada";
            // 
            // Fixa
            // 
            this.Fixa.HeaderText = "Fixa";
            this.Fixa.Name = "Fixa";
            // 
            // rendasBindingSource1
            // 
            this.rendasBindingSource1.DataMember = "Rendas";
            this.rendasBindingSource1.DataSource = this.senacPos2015DataSetBindingSource1;
            // 
            // VisualizarRendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 352);
            this.Controls.Add(this.dataGridView1);
            this.Name = "VisualizarRendas";
            this.Text = "Visualizar Rendas";
            this.Load += new System.EventHandler(this.VisualizarRendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.senacPos2015DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.senacPos2015DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rendasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.senacPos2015DataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rendasBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private WindowsFormsApplication1.SenacPos2015DataSet senacPos2015DataSet;
        private BindingSource rendasBindingSource;
        private WindowsFormsApplication1.SenacPos2015DataSetTableAdapters.RendasTableAdapter rendasTableAdapter;
        private WindowsFormsApplication1.SenacPos2015DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private BindingSource senacPos2015DataSetBindingSource;
        private BindingSource senacPos2015DataSetBindingSource1;
        private DataGridViewImageColumn Excluir;
        private DataGridViewImageColumn Editar;
        private DataGridViewTextBoxColumn Renda;
        private DataGridViewTextBoxColumn Valor;
        private DataGridViewTextBoxColumn DataEntrada;
        private DataGridViewTextBoxColumn Fixa;
        private BindingSource rendasBindingSource1;
    }
}