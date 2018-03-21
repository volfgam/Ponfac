namespace Ponfac3
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ltbGerado = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ltbProcessadas = new System.Windows.Forms.ListBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColunaString = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaLetras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.btnParar = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnNovoCiclo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ltbGerado
            // 
            this.ltbGerado.FormattingEnabled = true;
            this.ltbGerado.Location = new System.Drawing.Point(35, 29);
            this.ltbGerado.Name = "ltbGerado";
            this.ltbGerado.Size = new System.Drawing.Size(339, 199);
            this.ltbGerado.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Strings Geradas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(392, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Strings Processadas";
            // 
            // ltbProcessadas
            // 
            this.ltbProcessadas.FormattingEnabled = true;
            this.ltbProcessadas.Location = new System.Drawing.Point(395, 29);
            this.ltbProcessadas.Name = "ltbProcessadas";
            this.ltbProcessadas.Size = new System.Drawing.Size(339, 199);
            this.ltbProcessadas.TabIndex = 2;
            // 
            // timer2
            // 
            this.timer2.Interval = 500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColunaString,
            this.ColunaLetras});
            this.dataGridView1.Location = new System.Drawing.Point(35, 252);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(699, 150);
            this.dataGridView1.TabIndex = 4;
            // 
            // ColunaString
            // 
            this.ColunaString.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColunaString.HeaderText = "String";
            this.ColunaString.Name = "ColunaString";
            // 
            // ColunaLetras
            // 
            this.ColunaLetras.HeaderText = "Letras";
            this.ColunaLetras.Name = "ColunaLetras";
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // btnParar
            // 
            this.btnParar.Location = new System.Drawing.Point(589, 408);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(145, 23);
            this.btnParar.TabIndex = 5;
            this.btnParar.Text = "Parar Processamento";
            this.btnParar.UseVisualStyleBackColor = true;
            this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(35, 408);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(144, 23);
            this.btnIniciar.TabIndex = 6;
            this.btnIniciar.Text = "Iniciar Processamento";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnNovoCiclo
            // 
            this.btnNovoCiclo.Location = new System.Drawing.Point(313, 408);
            this.btnNovoCiclo.Name = "btnNovoCiclo";
            this.btnNovoCiclo.Size = new System.Drawing.Size(144, 23);
            this.btnNovoCiclo.TabIndex = 7;
            this.btnNovoCiclo.Text = "Iniciar Novo Ciclo";
            this.btnNovoCiclo.UseVisualStyleBackColor = true;
            this.btnNovoCiclo.Click += new System.EventHandler(this.btnNovoCiclo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNovoCiclo);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.btnParar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ltbProcessadas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ltbGerado);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox ltbGerado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox ltbProcessadas;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaString;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaLetras;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Button btnParar;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnNovoCiclo;
    }
}

