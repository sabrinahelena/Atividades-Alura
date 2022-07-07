namespace conversorDeMoedas
{
    partial class Frm_ConversorDeMoeda
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.mskd_Valor = new System.Windows.Forms.MaskedTextBox();
            this.Lbl_De = new System.Windows.Forms.Label();
            this.Lbl_ConverterDe = new System.Windows.Forms.Label();
            this.btn_DeReal = new System.Windows.Forms.Button();
            this.Lbl_ConverterPara = new System.Windows.Forms.Label();
            this.Btn_DeDolar = new System.Windows.Forms.Button();
            this.Btn_DeEuro = new System.Windows.Forms.Button();
            this.Btn_DeIene = new System.Windows.Forms.Button();
            this.Btn_DeLibra = new System.Windows.Forms.Button();
            this.Btn_ParaLibra = new System.Windows.Forms.Button();
            this.Btn_ParaIene = new System.Windows.Forms.Button();
            this.Btn_ParaEuro = new System.Windows.Forms.Button();
            this.Btn_ParaDolar = new System.Windows.Forms.Button();
            this.Btn_ParaReal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Titulo.Location = new System.Drawing.Point(89, 9);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(448, 76);
            this.Lbl_Titulo.TabIndex = 0;
            this.Lbl_Titulo.Text = "Conversão de moedas";
            // 
            // mskd_Valor
            // 
            this.mskd_Valor.Location = new System.Drawing.Point(138, 123);
            this.mskd_Valor.Mask = "000000000000000000000000";
            this.mskd_Valor.Name = "mskd_Valor";
            this.mskd_Valor.Size = new System.Drawing.Size(210, 20);
            this.mskd_Valor.TabIndex = 1;
            // 
            // Lbl_De
            // 
            this.Lbl_De.AutoSize = true;
            this.Lbl_De.Location = new System.Drawing.Point(93, 126);
            this.Lbl_De.Name = "Lbl_De";
            this.Lbl_De.Size = new System.Drawing.Size(31, 13);
            this.Lbl_De.TabIndex = 2;
            this.Lbl_De.Text = "Valor";
            // 
            // Lbl_ConverterDe
            // 
            this.Lbl_ConverterDe.AutoSize = true;
            this.Lbl_ConverterDe.Location = new System.Drawing.Point(80, 221);
            this.Lbl_ConverterDe.Name = "Lbl_ConverterDe";
            this.Lbl_ConverterDe.Size = new System.Drawing.Size(68, 13);
            this.Lbl_ConverterDe.TabIndex = 3;
            this.Lbl_ConverterDe.Text = "Converter de";
            // 
            // btn_DeReal
            // 
            this.btn_DeReal.Location = new System.Drawing.Point(12, 270);
            this.btn_DeReal.Name = "btn_DeReal";
            this.btn_DeReal.Size = new System.Drawing.Size(75, 23);
            this.btn_DeReal.TabIndex = 4;
            this.btn_DeReal.Text = "Real";
            this.btn_DeReal.UseVisualStyleBackColor = true;
            this.btn_DeReal.Click += new System.EventHandler(this.btn_DeReal_Click);
            // 
            // Lbl_ConverterPara
            // 
            this.Lbl_ConverterPara.AutoSize = true;
            this.Lbl_ConverterPara.Location = new System.Drawing.Point(458, 221);
            this.Lbl_ConverterPara.Name = "Lbl_ConverterPara";
            this.Lbl_ConverterPara.Size = new System.Drawing.Size(77, 13);
            this.Lbl_ConverterPara.TabIndex = 5;
            this.Lbl_ConverterPara.Text = "Converter para";
            // 
            // Btn_DeDolar
            // 
            this.Btn_DeDolar.Location = new System.Drawing.Point(138, 270);
            this.Btn_DeDolar.Name = "Btn_DeDolar";
            this.Btn_DeDolar.Size = new System.Drawing.Size(75, 23);
            this.Btn_DeDolar.TabIndex = 6;
            this.Btn_DeDolar.Text = "Dolar";
            this.Btn_DeDolar.UseVisualStyleBackColor = true;
            // 
            // Btn_DeEuro
            // 
            this.Btn_DeEuro.Location = new System.Drawing.Point(12, 327);
            this.Btn_DeEuro.Name = "Btn_DeEuro";
            this.Btn_DeEuro.Size = new System.Drawing.Size(75, 23);
            this.Btn_DeEuro.TabIndex = 7;
            this.Btn_DeEuro.Text = "Euro";
            this.Btn_DeEuro.UseVisualStyleBackColor = true;
            // 
            // Btn_DeIene
            // 
            this.Btn_DeIene.Location = new System.Drawing.Point(138, 327);
            this.Btn_DeIene.Name = "Btn_DeIene";
            this.Btn_DeIene.Size = new System.Drawing.Size(75, 23);
            this.Btn_DeIene.TabIndex = 8;
            this.Btn_DeIene.Text = "Iene";
            this.Btn_DeIene.UseVisualStyleBackColor = true;
            // 
            // Btn_DeLibra
            // 
            this.Btn_DeLibra.Location = new System.Drawing.Point(12, 377);
            this.Btn_DeLibra.Name = "Btn_DeLibra";
            this.Btn_DeLibra.Size = new System.Drawing.Size(112, 23);
            this.Btn_DeLibra.TabIndex = 9;
            this.Btn_DeLibra.Text = "Libra Esterlina";
            this.Btn_DeLibra.UseVisualStyleBackColor = true;
            // 
            // Btn_ParaLibra
            // 
            this.Btn_ParaLibra.Location = new System.Drawing.Point(387, 377);
            this.Btn_ParaLibra.Name = "Btn_ParaLibra";
            this.Btn_ParaLibra.Size = new System.Drawing.Size(103, 23);
            this.Btn_ParaLibra.TabIndex = 14;
            this.Btn_ParaLibra.Text = "Libra Esterlina";
            this.Btn_ParaLibra.UseVisualStyleBackColor = true;
            // 
            // Btn_ParaIene
            // 
            this.Btn_ParaIene.Location = new System.Drawing.Point(513, 327);
            this.Btn_ParaIene.Name = "Btn_ParaIene";
            this.Btn_ParaIene.Size = new System.Drawing.Size(75, 23);
            this.Btn_ParaIene.TabIndex = 13;
            this.Btn_ParaIene.Text = "Iene";
            this.Btn_ParaIene.UseVisualStyleBackColor = true;
            // 
            // Btn_ParaEuro
            // 
            this.Btn_ParaEuro.Location = new System.Drawing.Point(387, 327);
            this.Btn_ParaEuro.Name = "Btn_ParaEuro";
            this.Btn_ParaEuro.Size = new System.Drawing.Size(75, 23);
            this.Btn_ParaEuro.TabIndex = 12;
            this.Btn_ParaEuro.Text = "Euro";
            this.Btn_ParaEuro.UseVisualStyleBackColor = true;
            // 
            // Btn_ParaDolar
            // 
            this.Btn_ParaDolar.Location = new System.Drawing.Point(513, 270);
            this.Btn_ParaDolar.Name = "Btn_ParaDolar";
            this.Btn_ParaDolar.Size = new System.Drawing.Size(75, 23);
            this.Btn_ParaDolar.TabIndex = 11;
            this.Btn_ParaDolar.Text = "Dolar";
            this.Btn_ParaDolar.UseVisualStyleBackColor = true;
            // 
            // Btn_ParaReal
            // 
            this.Btn_ParaReal.Location = new System.Drawing.Point(387, 270);
            this.Btn_ParaReal.Name = "Btn_ParaReal";
            this.Btn_ParaReal.Size = new System.Drawing.Size(75, 23);
            this.Btn_ParaReal.TabIndex = 10;
            this.Btn_ParaReal.Text = "Real";
            this.Btn_ParaReal.UseVisualStyleBackColor = true;
            // 
            // Frm_ConversorDeMoeda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 450);
            this.Controls.Add(this.Btn_ParaLibra);
            this.Controls.Add(this.Btn_ParaIene);
            this.Controls.Add(this.Btn_ParaEuro);
            this.Controls.Add(this.Btn_ParaDolar);
            this.Controls.Add(this.Btn_ParaReal);
            this.Controls.Add(this.Btn_DeLibra);
            this.Controls.Add(this.Btn_DeIene);
            this.Controls.Add(this.Btn_DeEuro);
            this.Controls.Add(this.Btn_DeDolar);
            this.Controls.Add(this.Lbl_ConverterPara);
            this.Controls.Add(this.btn_DeReal);
            this.Controls.Add(this.Lbl_ConverterDe);
            this.Controls.Add(this.Lbl_De);
            this.Controls.Add(this.mskd_Valor);
            this.Controls.Add(this.Lbl_Titulo);
            this.Name = "Frm_ConversorDeMoeda";
            this.Text = "Conversor de moedas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.MaskedTextBox mskd_Valor;
        private System.Windows.Forms.Label Lbl_De;
        private System.Windows.Forms.Label Lbl_ConverterDe;
        private System.Windows.Forms.Button btn_DeReal;
        private System.Windows.Forms.Label Lbl_ConverterPara;
        private System.Windows.Forms.Button Btn_DeDolar;
        private System.Windows.Forms.Button Btn_DeEuro;
        private System.Windows.Forms.Button Btn_DeIene;
        private System.Windows.Forms.Button Btn_DeLibra;
        private System.Windows.Forms.Button Btn_ParaLibra;
        private System.Windows.Forms.Button Btn_ParaIene;
        private System.Windows.Forms.Button Btn_ParaEuro;
        private System.Windows.Forms.Button Btn_ParaDolar;
        private System.Windows.Forms.Button Btn_ParaReal;
    }
}

