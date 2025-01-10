namespace Gerenciador_de_Estoque
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnListaDC = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.panelClientes = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnListaDC);
            this.panel1.Controls.Add(this.btnCadastrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(115, 524);
            this.panel1.TabIndex = 0;
            // 
            // btnListaDC
            // 
            this.btnListaDC.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnListaDC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnListaDC.Location = new System.Drawing.Point(12, 189);
            this.btnListaDC.Name = "btnListaDC";
            this.btnListaDC.Size = new System.Drawing.Size(85, 60);
            this.btnListaDC.TabIndex = 1;
            this.btnListaDC.Text = "Lista de Clientes";
            this.btnListaDC.UseVisualStyleBackColor = false;
            this.btnListaDC.Click += new System.EventHandler(this.btnListaDC_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrar.Location = new System.Drawing.Point(12, 89);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(85, 60);
            this.btnCadastrar.TabIndex = 0;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // panelClientes
            // 
            this.panelClientes.BackColor = System.Drawing.Color.LightSlateGray;
            this.panelClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelClientes.Location = new System.Drawing.Point(115, 0);
            this.panelClientes.Name = "panelClientes";
            this.panelClientes.Size = new System.Drawing.Size(669, 524);
            this.panelClientes.TabIndex = 1;
            this.panelClientes.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCadastrar_Paint);
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(784, 524);
            this.Controls.Add(this.panelClientes);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmClientes";
            this.Text = "FrmClientes";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnListaDC;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Panel panelClientes;
    }
}