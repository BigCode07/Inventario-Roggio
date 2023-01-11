﻿namespace ChameleonProject
{
    partial class Query
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
            this.dgvAD = new System.Windows.Forms.DataGridView();
            this.CajaAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Retirado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaCargad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCaja = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAD)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAD
            // 
            this.dgvAD.AllowUserToAddRows = false;
            this.dgvAD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAD.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvAD.BackgroundColor = System.Drawing.Color.Ivory;
            this.dgvAD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CajaAD,
            this.Retirado,
            this.FechaCargad});
            this.dgvAD.Location = new System.Drawing.Point(12, 131);
            this.dgvAD.Name = "dgvAD";
            this.dgvAD.Size = new System.Drawing.Size(1097, 376);
            this.dgvAD.TabIndex = 380;
            this.dgvAD.TabStop = false;
            // 
            // CajaAD
            // 
            this.CajaAD.HeaderText = "Caja";
            this.CajaAD.Name = "CajaAD";
            // 
            // Retirado
            // 
            this.Retirado.HeaderText = "Para Interfile";
            this.Retirado.Name = "Retirado";
            // 
            // FechaCargad
            // 
            this.FechaCargad.HeaderText = "FechaCarga";
            this.FechaCargad.Name = "FechaCargad";
            // 
            // txtCaja
            // 
            this.txtCaja.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCaja.Location = new System.Drawing.Point(459, 54);
            this.txtCaja.Name = "txtCaja";
            this.txtCaja.Size = new System.Drawing.Size(210, 26);
            this.txtCaja.TabIndex = 0;
            this.txtCaja.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCaja_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(393, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Caja:";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.Location = new System.Drawing.Point(676, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 26);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cargar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Query
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(224)))), ((int)(((byte)(186)))));
            this.ClientSize = new System.Drawing.Size(1121, 537);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtCaja);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvAD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Query";
            this.Text = "Query";
            this.Load += new System.EventHandler(this.StartProgram);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvAD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCaja;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CajaAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Retirado;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaCargad;
        private System.Windows.Forms.Button button1;
    }
}