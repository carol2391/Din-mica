﻿namespace SistemaFederal
{
    partial class FrmClientes
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
            this.lstCliente = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnModificarModificarCliente = new System.Windows.Forms.Button();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstCliente
            // 
            this.lstCliente.FormattingEnabled = true;
            this.lstCliente.Location = new System.Drawing.Point(25, 48);
            this.lstCliente.Name = "lstCliente";
            this.lstCliente.Size = new System.Drawing.Size(522, 186);
            this.lstCliente.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(284, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 48);
            this.button1.TabIndex = 21;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnModificarModificarCliente
            // 
            this.btnModificarModificarCliente.Location = new System.Drawing.Point(151, 237);
            this.btnModificarModificarCliente.Name = "btnModificarModificarCliente";
            this.btnModificarModificarCliente.Size = new System.Drawing.Size(127, 48);
            this.btnModificarModificarCliente.TabIndex = 20;
            this.btnModificarModificarCliente.Text = "Modificar Cliente";
            this.btnModificarModificarCliente.UseVisualStyleBackColor = true;
            this.btnModificarModificarCliente.Click += new System.EventHandler(this.btnModificarModificarCliente_Click);
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.Location = new System.Drawing.Point(25, 237);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(120, 48);
            this.btnAgregarCliente.TabIndex = 19;
            this.btnAgregarCliente.Text = "Agregar Cliente";
            this.btnAgregarCliente.UseVisualStyleBackColor = true;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(161, 9);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(121, 20);
            this.txtNombreCliente.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Buscar Cliente por Nombre";
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 299);
            this.Controls.Add(this.lstCliente);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnModificarModificarCliente);
            this.Controls.Add(this.btnAgregarCliente);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.label1);
            this.Name = "FrmClientes";
            this.Text = "Manejo de Clientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCliente;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnModificarModificarCliente;
        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label label1;
    }
}