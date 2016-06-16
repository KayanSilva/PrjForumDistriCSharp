namespace PrjForumDistriCSharp
{
    partial class FrmConsulta
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
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.rdbCivel = new System.Windows.Forms.RadioButton();
            this.rdbCriminal = new System.Windows.Forms.RadioButton();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(15, 93);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 0;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // rdbCivel
            // 
            this.rdbCivel.AutoSize = true;
            this.rdbCivel.Location = new System.Drawing.Point(120, 30);
            this.rdbCivel.Name = "rdbCivel";
            this.rdbCivel.Size = new System.Drawing.Size(48, 17);
            this.rdbCivel.TabIndex = 1;
            this.rdbCivel.TabStop = true;
            this.rdbCivel.Text = "Civel";
            this.rdbCivel.UseVisualStyleBackColor = true;
            // 
            // rdbCriminal
            // 
            this.rdbCriminal.AutoSize = true;
            this.rdbCriminal.Location = new System.Drawing.Point(199, 30);
            this.rdbCriminal.Name = "rdbCriminal";
            this.rdbCriminal.Size = new System.Drawing.Size(61, 17);
            this.rdbCriminal.TabIndex = 2;
            this.rdbCriminal.TabStop = true;
            this.rdbCriminal.Text = "Criminal";
            this.rdbCriminal.UseVisualStyleBackColor = true;
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(93, 56);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(313, 20);
            this.txtnome.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pesquisa entre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Digite o nome:";
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(15, 340);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpar.TabIndex = 7;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnsair
            // 
            this.btnsair.Location = new System.Drawing.Point(356, 340);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(75, 23);
            this.btnsair.TabIndex = 8;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "tes",
            "fheh",
            "eddn",
            "end /n hfhd"});
            this.listBox1.Location = new System.Drawing.Point(15, 134);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(374, 173);
            this.listBox1.TabIndex = 9;
            // 
            // FrmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 383);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.rdbCriminal);
            this.Controls.Add(this.rdbCivel);
            this.Controls.Add(this.btnPesquisar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmConsulta";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KaySoft - Consultas do Distribuidor - Guarujá";
            this.Load += new System.EventHandler(this.FrmConsulta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.RadioButton rdbCivel;
        private System.Windows.Forms.RadioButton rdbCriminal;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.ListBox listBox1;
    }
}

