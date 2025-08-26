namespace GerenciadorDeOVINI
{
    partial class Gerenciador
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
            this.grbinformacoes = new System.Windows.Forms.GroupBox();
            this.lblPlaneta = new System.Windows.Forms.Label();
            this.btnDesligar = new System.Windows.Forms.Button();
            this.btnLigar = new System.Windows.Forms.Button();
            this.lblAbduzidos = new System.Windows.Forms.Label();
            this.lblTripulantes = new System.Windows.Forms.Label();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.grbTripulantes = new System.Windows.Forms.GroupBox();
            this.btnRemoverTripulantes = new System.Windows.Forms.Button();
            this.btnAdicionarTripulantes = new System.Windows.Forms.Button();
            this.grbAbduzidos = new System.Windows.Forms.GroupBox();
            this.btnRemoverAbduzidos = new System.Windows.Forms.Button();
            this.btnAdicionarAbduzidos = new System.Windows.Forms.Button();
            this.grbPlaneta = new System.Windows.Forms.GroupBox();
            this.btnRetornarDePlaneta = new System.Windows.Forms.Button();
            this.btnMudarDePlaneta = new System.Windows.Forms.Button();
            this.cmbPlanetas = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pibTerra = new System.Windows.Forms.PictureBox();
            this.grbinformacoes.SuspendLayout();
            this.grbTripulantes.SuspendLayout();
            this.grbAbduzidos.SuspendLayout();
            this.grbPlaneta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibTerra)).BeginInit();
            this.SuspendLayout();
            // 
            // grbinformacoes
            // 
            this.grbinformacoes.Controls.Add(this.lblPlaneta);
            this.grbinformacoes.Controls.Add(this.btnDesligar);
            this.grbinformacoes.Controls.Add(this.btnLigar);
            this.grbinformacoes.Controls.Add(this.lblAbduzidos);
            this.grbinformacoes.Controls.Add(this.lblTripulantes);
            this.grbinformacoes.Controls.Add(this.lblSituacao);
            this.grbinformacoes.Location = new System.Drawing.Point(-1, 5);
            this.grbinformacoes.Name = "grbinformacoes";
            this.grbinformacoes.Size = new System.Drawing.Size(367, 280);
            this.grbinformacoes.TabIndex = 0;
            this.grbinformacoes.TabStop = false;
            this.grbinformacoes.Text = "Informações";
            // 
            // lblPlaneta
            // 
            this.lblPlaneta.AutoSize = true;
            this.lblPlaneta.Location = new System.Drawing.Point(19, 141);
            this.lblPlaneta.Name = "lblPlaneta";
            this.lblPlaneta.Size = new System.Drawing.Size(73, 13);
            this.lblPlaneta.TabIndex = 5;
            this.lblPlaneta.Text = "Planeta Atual:";
            // 
            // btnDesligar
            // 
            this.btnDesligar.Location = new System.Drawing.Point(6, 218);
            this.btnDesligar.Name = "btnDesligar";
            this.btnDesligar.Size = new System.Drawing.Size(274, 32);
            this.btnDesligar.TabIndex = 4;
            this.btnDesligar.Text = "Desligar";
            this.btnDesligar.UseVisualStyleBackColor = true;
            this.btnDesligar.Click += new System.EventHandler(this.btnDesligar_Click);
            // 
            // btnLigar
            // 
            this.btnLigar.Enabled = false;
            this.btnLigar.Location = new System.Drawing.Point(6, 165);
            this.btnLigar.Name = "btnLigar";
            this.btnLigar.Size = new System.Drawing.Size(274, 33);
            this.btnLigar.TabIndex = 3;
            this.btnLigar.Text = "Ligar";
            this.btnLigar.UseVisualStyleBackColor = true;
            this.btnLigar.Click += new System.EventHandler(this.btnLigar_Click);
            // 
            // lblAbduzidos
            // 
            this.lblAbduzidos.AutoSize = true;
            this.lblAbduzidos.Location = new System.Drawing.Point(16, 112);
            this.lblAbduzidos.Name = "lblAbduzidos";
            this.lblAbduzidos.Size = new System.Drawing.Size(59, 13);
            this.lblAbduzidos.TabIndex = 2;
            this.lblAbduzidos.Text = "Abduzidos:";
            // 
            // lblTripulantes
            // 
            this.lblTripulantes.AutoSize = true;
            this.lblTripulantes.Location = new System.Drawing.Point(16, 82);
            this.lblTripulantes.Name = "lblTripulantes";
            this.lblTripulantes.Size = new System.Drawing.Size(59, 13);
            this.lblTripulantes.TabIndex = 1;
            this.lblTripulantes.Text = "Tripulantes";
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Location = new System.Drawing.Point(13, 42);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(52, 13);
            this.lblSituacao.TabIndex = 0;
            this.lblSituacao.Text = "Situação:";
            // 
            // grbTripulantes
            // 
            this.grbTripulantes.Controls.Add(this.btnRemoverTripulantes);
            this.grbTripulantes.Controls.Add(this.btnAdicionarTripulantes);
            this.grbTripulantes.Location = new System.Drawing.Point(392, 12);
            this.grbTripulantes.Name = "grbTripulantes";
            this.grbTripulantes.Size = new System.Drawing.Size(313, 273);
            this.grbTripulantes.TabIndex = 1;
            this.grbTripulantes.TabStop = false;
            this.grbTripulantes.Text = "Tripulantes";
            // 
            // btnRemoverTripulantes
            // 
            this.btnRemoverTripulantes.Location = new System.Drawing.Point(31, 203);
            this.btnRemoverTripulantes.Name = "btnRemoverTripulantes";
            this.btnRemoverTripulantes.Size = new System.Drawing.Size(248, 40);
            this.btnRemoverTripulantes.TabIndex = 1;
            this.btnRemoverTripulantes.Text = "Remover";
            this.btnRemoverTripulantes.UseVisualStyleBackColor = true;
            this.btnRemoverTripulantes.Click += new System.EventHandler(this.btnRemoverTripulantes_Click);
            // 
            // btnAdicionarTripulantes
            // 
            this.btnAdicionarTripulantes.Location = new System.Drawing.Point(31, 134);
            this.btnAdicionarTripulantes.Name = "btnAdicionarTripulantes";
            this.btnAdicionarTripulantes.Size = new System.Drawing.Size(248, 40);
            this.btnAdicionarTripulantes.TabIndex = 0;
            this.btnAdicionarTripulantes.Text = "adicionar";
            this.btnAdicionarTripulantes.UseVisualStyleBackColor = true;
            this.btnAdicionarTripulantes.Click += new System.EventHandler(this.btnAdicionarTripulantes_Click);
            // 
            // grbAbduzidos
            // 
            this.grbAbduzidos.Controls.Add(this.btnRemoverAbduzidos);
            this.grbAbduzidos.Controls.Add(this.btnAdicionarAbduzidos);
            this.grbAbduzidos.Location = new System.Drawing.Point(729, 12);
            this.grbAbduzidos.Name = "grbAbduzidos";
            this.grbAbduzidos.Size = new System.Drawing.Size(313, 273);
            this.grbAbduzidos.TabIndex = 2;
            this.grbAbduzidos.TabStop = false;
            this.grbAbduzidos.Text = "Abduzidos";
            // 
            // btnRemoverAbduzidos
            // 
            this.btnRemoverAbduzidos.Location = new System.Drawing.Point(31, 203);
            this.btnRemoverAbduzidos.Name = "btnRemoverAbduzidos";
            this.btnRemoverAbduzidos.Size = new System.Drawing.Size(248, 40);
            this.btnRemoverAbduzidos.TabIndex = 1;
            this.btnRemoverAbduzidos.Text = "Remover ";
            this.btnRemoverAbduzidos.UseVisualStyleBackColor = true;
            this.btnRemoverAbduzidos.Click += new System.EventHandler(this.btnRemoverAbduzidos_Click);
            // 
            // btnAdicionarAbduzidos
            // 
            this.btnAdicionarAbduzidos.Location = new System.Drawing.Point(31, 134);
            this.btnAdicionarAbduzidos.Name = "btnAdicionarAbduzidos";
            this.btnAdicionarAbduzidos.Size = new System.Drawing.Size(248, 40);
            this.btnAdicionarAbduzidos.TabIndex = 0;
            this.btnAdicionarAbduzidos.Text = "adicionar";
            this.btnAdicionarAbduzidos.UseVisualStyleBackColor = true;
            this.btnAdicionarAbduzidos.Click += new System.EventHandler(this.btnAdicionarAbduzidos_Click);
            // 
            // grbPlaneta
            // 
            this.grbPlaneta.Controls.Add(this.btnRetornarDePlaneta);
            this.grbPlaneta.Controls.Add(this.btnMudarDePlaneta);
            this.grbPlaneta.Controls.Add(this.cmbPlanetas);
            this.grbPlaneta.Location = new System.Drawing.Point(18, 310);
            this.grbPlaneta.Name = "grbPlaneta";
            this.grbPlaneta.Size = new System.Drawing.Size(295, 247);
            this.grbPlaneta.TabIndex = 3;
            this.grbPlaneta.TabStop = false;
            this.grbPlaneta.Text = "Planeta";
            // 
            // btnRetornarDePlaneta
            // 
            this.btnRetornarDePlaneta.Location = new System.Drawing.Point(6, 162);
            this.btnRetornarDePlaneta.Name = "btnRetornarDePlaneta";
            this.btnRetornarDePlaneta.Size = new System.Drawing.Size(283, 41);
            this.btnRetornarDePlaneta.TabIndex = 2;
            this.btnRetornarDePlaneta.Text = "Retornar";
            this.btnRetornarDePlaneta.UseVisualStyleBackColor = true;
            // 
            // btnMudarDePlaneta
            // 
            this.btnMudarDePlaneta.Location = new System.Drawing.Point(6, 84);
            this.btnMudarDePlaneta.Name = "btnMudarDePlaneta";
            this.btnMudarDePlaneta.Size = new System.Drawing.Size(283, 41);
            this.btnMudarDePlaneta.TabIndex = 1;
            this.btnMudarDePlaneta.Text = "Mudar De Planeta";
            this.btnMudarDePlaneta.UseVisualStyleBackColor = true;
            this.btnMudarDePlaneta.Click += new System.EventHandler(this.btnMudarDePlaneta_Click);
            // 
            // cmbPlanetas
            // 
            this.cmbPlanetas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlanetas.FormattingEnabled = true;
            this.cmbPlanetas.Location = new System.Drawing.Point(7, 34);
            this.cmbPlanetas.Name = "cmbPlanetas";
            this.cmbPlanetas.Size = new System.Drawing.Size(283, 21);
            this.cmbPlanetas.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GerenciadorDeOVINI.Properties.Resources.ufo;
            this.pictureBox1.Location = new System.Drawing.Point(780, 310);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 233);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pibTerra
            // 
            this.pibTerra.Location = new System.Drawing.Point(423, 371);
            this.pibTerra.Name = "pibTerra";
            this.pibTerra.Size = new System.Drawing.Size(230, 127);
            this.pibTerra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibTerra.TabIndex = 10;
            this.pibTerra.TabStop = false;
            // 
            // Gerenciador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 587);
            this.Controls.Add(this.pibTerra);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grbPlaneta);
            this.Controls.Add(this.grbAbduzidos);
            this.Controls.Add(this.grbTripulantes);
            this.Controls.Add(this.grbinformacoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Gerenciador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciador";
            this.grbinformacoes.ResumeLayout(false);
            this.grbinformacoes.PerformLayout();
            this.grbTripulantes.ResumeLayout(false);
            this.grbAbduzidos.ResumeLayout(false);
            this.grbPlaneta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibTerra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbinformacoes;
        private System.Windows.Forms.Label lblAbduzidos;
        private System.Windows.Forms.Label lblTripulantes;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.Button btnDesligar;
        private System.Windows.Forms.Button btnLigar;
        private System.Windows.Forms.GroupBox grbTripulantes;
        private System.Windows.Forms.Button btnRemoverTripulantes;
        private System.Windows.Forms.Button btnAdicionarTripulantes;
        private System.Windows.Forms.GroupBox grbAbduzidos;
        private System.Windows.Forms.Button btnRemoverAbduzidos;
        private System.Windows.Forms.Button btnAdicionarAbduzidos;
        private System.Windows.Forms.GroupBox grbPlaneta;
        private System.Windows.Forms.Button btnMudarDePlaneta;
        private System.Windows.Forms.ComboBox cmbPlanetas;
        private System.Windows.Forms.Button btnRetornarDePlaneta;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblPlaneta;
        private System.Windows.Forms.PictureBox pibTerra;
    }
}