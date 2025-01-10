namespace Gerenciador_de_Estoque
{
    partial class FrmCadastrar
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
            this.panelCadastrar = new System.Windows.Forms.Panel();
            this.groupBoxCadastrat = new System.Windows.Forms.GroupBox();
            this.maskedTXTCPF = new System.Windows.Forms.MaskedTextBox();
            this.maskedTXTtelefone = new System.Windows.Forms.MaskedTextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtEndereço = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelCadastrar.SuspendLayout();
            this.groupBoxCadastrat.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCadastrar
            // 
            this.panelCadastrar.BackColor = System.Drawing.Color.LightSlateGray;
            this.panelCadastrar.Controls.Add(this.groupBoxCadastrat);
            this.panelCadastrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCadastrar.Location = new System.Drawing.Point(0, 0);
            this.panelCadastrar.Name = "panelCadastrar";
            this.panelCadastrar.Size = new System.Drawing.Size(669, 524);
            this.panelCadastrar.TabIndex = 2;
            this.panelCadastrar.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCadastrar_Paint);
            // 
            // groupBoxCadastrat
            // 
            this.groupBoxCadastrat.Controls.Add(this.maskedTXTCPF);
            this.groupBoxCadastrat.Controls.Add(this.maskedTXTtelefone);
            this.groupBoxCadastrat.Controls.Add(this.btnSalvar);
            this.groupBoxCadastrat.Controls.Add(this.label5);
            this.groupBoxCadastrat.Controls.Add(this.label4);
            this.groupBoxCadastrat.Controls.Add(this.label3);
            this.groupBoxCadastrat.Controls.Add(this.label2);
            this.groupBoxCadastrat.Controls.Add(this.label1);
            this.groupBoxCadastrat.Controls.Add(this.TxtEndereço);
            this.groupBoxCadastrat.Controls.Add(this.txtNome);
            this.groupBoxCadastrat.Controls.Add(this.txtCodigo);
            this.groupBoxCadastrat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCadastrat.Location = new System.Drawing.Point(12, 3);
            this.groupBoxCadastrat.Name = "groupBoxCadastrat";
            this.groupBoxCadastrat.Size = new System.Drawing.Size(645, 478);
            this.groupBoxCadastrat.TabIndex = 0;
            this.groupBoxCadastrat.TabStop = false;
            this.groupBoxCadastrat.Text = "CADASTRAR";
            // 
            // maskedTXTCPF
            // 
            this.maskedTXTCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTXTCPF.Location = new System.Drawing.Point(31, 177);
            this.maskedTXTCPF.Mask = "000.000.000-00";
            this.maskedTXTCPF.Name = "maskedTXTCPF";
            this.maskedTXTCPF.Size = new System.Drawing.Size(140, 26);
            this.maskedTXTCPF.TabIndex = 12;
            this.maskedTXTCPF.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTXTCPF_MaskInputRejected);
            // 
            // maskedTXTtelefone
            // 
            this.maskedTXTtelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTXTtelefone.Location = new System.Drawing.Point(293, 177);
            this.maskedTXTtelefone.Mask = "(00)00000-0000";
            this.maskedTXTtelefone.Name = "maskedTXTtelefone";
            this.maskedTXTtelefone.Size = new System.Drawing.Size(211, 26);
            this.maskedTXTtelefone.TabIndex = 11;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(31, 427);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(69, 36);
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label5.Location = new System.Drawing.Point(27, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Endereço";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label4.Location = new System.Drawing.Point(290, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Telefoe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label3.Location = new System.Drawing.Point(290, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label2.Location = new System.Drawing.Point(27, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "CPF";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label1.Location = new System.Drawing.Point(27, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Código";
            // 
            // TxtEndereço
            // 
            this.TxtEndereço.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEndereço.Location = new System.Drawing.Point(31, 274);
            this.TxtEndereço.Multiline = true;
            this.TxtEndereço.Name = "TxtEndereço";
            this.TxtEndereço.Size = new System.Drawing.Size(519, 58);
            this.TxtEndereço.TabIndex = 4;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(294, 65);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(210, 26);
            this.txtNome.TabIndex = 2;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(31, 63);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(140, 26);
            this.txtCodigo.TabIndex = 0;
            // 
            // FrmCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 524);
            this.Controls.Add(this.panelCadastrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCadastrar";
            this.Text = "FrmCadastrar";
            this.Load += new System.EventHandler(this.FrmCadastrar_Load);
            this.panelCadastrar.ResumeLayout(false);
            this.groupBoxCadastrat.ResumeLayout(false);
            this.groupBoxCadastrat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCadastrar;
        private System.Windows.Forms.GroupBox groupBoxCadastrat;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtEndereço;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.MaskedTextBox maskedTXTCPF;
        private System.Windows.Forms.MaskedTextBox maskedTXTtelefone;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}