namespace Gerenciador_de_Estoque
{
    partial class FrmEstoque
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEstoqueGeral = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.panelEstoque = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OrangeRed;
            this.panel1.Controls.Add(this.btnEstoqueGeral);
            this.panel1.Controls.Add(this.btnInserir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(115, 485);
            this.panel1.TabIndex = 0;
            // 
            // btnEstoqueGeral
            // 
            this.btnEstoqueGeral.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEstoqueGeral.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEstoqueGeral.Location = new System.Drawing.Point(12, 183);
            this.btnEstoqueGeral.Name = "btnEstoqueGeral";
            this.btnEstoqueGeral.Size = new System.Drawing.Size(85, 60);
            this.btnEstoqueGeral.TabIndex = 1;
            this.btnEstoqueGeral.Text = "Estoque Geral";
            this.btnEstoqueGeral.UseVisualStyleBackColor = false;
            this.btnEstoqueGeral.Click += new System.EventHandler(this.btnEstoqueGeral_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnInserir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInserir.Location = new System.Drawing.Point(12, 89);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(85, 60);
            this.btnInserir.TabIndex = 0;
            this.btnInserir.Text = "Inserir Produto";
            this.btnInserir.UseVisualStyleBackColor = false;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // panelEstoque
            // 
            this.panelEstoque.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEstoque.Location = new System.Drawing.Point(115, 0);
            this.panelEstoque.Name = "panelEstoque";
            this.panelEstoque.Size = new System.Drawing.Size(653, 485);
            this.panelEstoque.TabIndex = 1;
            // 
            // FrmEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(768, 485);
            this.Controls.Add(this.panelEstoque);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEstoque";
            this.Text = "FrmEstoque";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnEstoqueGeral;
        private System.Windows.Forms.Panel panelEstoque;
    }
}