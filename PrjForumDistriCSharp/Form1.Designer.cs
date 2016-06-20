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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsulta));
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblcheck = new System.Windows.Forms.Label();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.datagridconsulta = new System.Windows.Forms.DataGridView();
            this.dtpDistribuicao = new System.Windows.Forms.DateTimePicker();
            this.rdbcivel = new System.Windows.Forms.RadioButton();
            this.rdbcriminal = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdbnome = new System.Windows.Forms.RadioButton();
            this.rdbdatadistri = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.datagridconsulta)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.BackgroundImage")));
            this.btnPesquisar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.Location = new System.Drawing.Point(485, 43);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(97, 38);
            this.btnPesquisar.TabIndex = 0;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtnome
            // 
            this.txtnome.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnome.Location = new System.Drawing.Point(115, 56);
            this.txtnome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(364, 22);
            this.txtnome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pesquise entre:";
            // 
            // lblcheck
            // 
            this.lblcheck.AutoSize = true;
            this.lblcheck.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcheck.Location = new System.Drawing.Point(8, 59);
            this.lblcheck.Name = "lblcheck";
            this.lblcheck.Size = new System.Drawing.Size(101, 16);
            this.lblcheck.TabIndex = 6;
            this.lblcheck.Text = "Digite o nome:";
            // 
            // btnlimpar
            // 
            this.btnlimpar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpar.Location = new System.Drawing.Point(604, 43);
            this.btnlimpar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(94, 38);
            this.btnlimpar.TabIndex = 7;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnsair
            // 
            this.btnsair.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsair.Location = new System.Drawing.Point(964, 292);
            this.btnsair.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(87, 28);
            this.btnsair.TabIndex = 8;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // datagridconsulta
            // 
            this.datagridconsulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.datagridconsulta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.datagridconsulta.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.datagridconsulta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridconsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridconsulta.Location = new System.Drawing.Point(12, 99);
            this.datagridconsulta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.datagridconsulta.Name = "datagridconsulta";
            this.datagridconsulta.RowHeadersVisible = false;
            this.datagridconsulta.Size = new System.Drawing.Size(1039, 185);
            this.datagridconsulta.TabIndex = 9;
            // 
            // dtpDistribuicao
            // 
            this.dtpDistribuicao.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDistribuicao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDistribuicao.Location = new System.Drawing.Point(200, 54);
            this.dtpDistribuicao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpDistribuicao.Name = "dtpDistribuicao";
            this.dtpDistribuicao.Size = new System.Drawing.Size(110, 22);
            this.dtpDistribuicao.TabIndex = 10;
            // 
            // rdbcivel
            // 
            this.rdbcivel.AutoSize = true;
            this.rdbcivel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbcivel.Location = new System.Drawing.Point(3, 7);
            this.rdbcivel.Name = "rdbcivel";
            this.rdbcivel.Size = new System.Drawing.Size(58, 20);
            this.rdbcivel.TabIndex = 11;
            this.rdbcivel.TabStop = true;
            this.rdbcivel.Text = "Cível";
            this.rdbcivel.UseVisualStyleBackColor = true;
            // 
            // rdbcriminal
            // 
            this.rdbcriminal.AutoSize = true;
            this.rdbcriminal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbcriminal.Location = new System.Drawing.Point(83, 7);
            this.rdbcriminal.Name = "rdbcriminal";
            this.rdbcriminal.Size = new System.Drawing.Size(80, 20);
            this.rdbcriminal.TabIndex = 12;
            this.rdbcriminal.TabStop = true;
            this.rdbcriminal.Text = "Criminal";
            this.rdbcriminal.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdbcriminal);
            this.panel1.Controls.Add(this.rdbcivel);
            this.panel1.Location = new System.Drawing.Point(117, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(159, 37);
            this.panel1.TabIndex = 14;
            // 
            // rdbnome
            // 
            this.rdbnome.AutoSize = true;
            this.rdbnome.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbnome.Location = new System.Drawing.Point(296, 7);
            this.rdbnome.Name = "rdbnome";
            this.rdbnome.Size = new System.Drawing.Size(63, 20);
            this.rdbnome.TabIndex = 15;
            this.rdbnome.TabStop = true;
            this.rdbnome.Text = "Nome";
            this.rdbnome.UseVisualStyleBackColor = true;
            this.rdbnome.CheckedChanged += new System.EventHandler(this.rdbnome_CheckedChanged);
            // 
            // rdbdatadistri
            // 
            this.rdbdatadistri.AutoSize = true;
            this.rdbdatadistri.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbdatadistri.Location = new System.Drawing.Point(362, 7);
            this.rdbdatadistri.Name = "rdbdatadistri";
            this.rdbdatadistri.Size = new System.Drawing.Size(154, 20);
            this.rdbdatadistri.TabIndex = 16;
            this.rdbdatadistri.TabStop = true;
            this.rdbdatadistri.Text = "Data de Distribuição";
            this.rdbdatadistri.UseVisualStyleBackColor = true;
            this.rdbdatadistri.CheckedChanged += new System.EventHandler(this.rdbdatadistri_CheckedChanged);
            // 
            // FrmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1077, 331);
            this.Controls.Add(this.rdbdatadistri);
            this.Controls.Add(this.rdbnome);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpDistribuicao);
            this.Controls.Add(this.datagridconsulta);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.lblcheck);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.btnPesquisar);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FrmConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KaySoft - Consultas do Distribuidor - Guarujá";
            this.Load += new System.EventHandler(this.FrmConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridconsulta)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblcheck;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.DataGridView datagridconsulta;
        private System.Windows.Forms.DateTimePicker dtpDistribuicao;
        private System.Windows.Forms.RadioButton rdbcivel;
        private System.Windows.Forms.RadioButton rdbcriminal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdbnome;
        private System.Windows.Forms.RadioButton rdbdatadistri;
    }
}

