﻿namespace PI_3_Defensores_de_Hastings
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
            this.btnPartida = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nomeDaPartida = new System.Windows.Forms.TextBox();
            this.senhaDaPartida = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nomeDoGrupo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.idDaPartida = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnPartida
            // 
            this.btnPartida.BackColor = System.Drawing.Color.Transparent;
            this.btnPartida.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPartida.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnPartida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPartida.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnPartida.ForeColor = System.Drawing.Color.Transparent;
            this.btnPartida.Location = new System.Drawing.Point(152, 111);
            this.btnPartida.Name = "btnPartida";
            this.btnPartida.Size = new System.Drawing.Size(75, 23);
            this.btnPartida.TabIndex = 0;
            this.btnPartida.Text = "Criar";
            this.btnPartida.UseVisualStyleBackColor = false;
            this.btnPartida.Click += new System.EventHandler(this.btnPartida_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(10, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Partida:";
            // 
            // nomeDaPartida
            // 
            this.nomeDaPartida.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.nomeDaPartida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nomeDaPartida.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.nomeDaPartida.Location = new System.Drawing.Point(12, 71);
            this.nomeDaPartida.Name = "nomeDaPartida";
            this.nomeDaPartida.Size = new System.Drawing.Size(100, 21);
            this.nomeDaPartida.TabIndex = 2;
            // 
            // senhaDaPartida
            // 
            this.senhaDaPartida.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.senhaDaPartida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.senhaDaPartida.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.senhaDaPartida.Location = new System.Drawing.Point(140, 71);
            this.senhaDaPartida.Name = "senhaDaPartida";
            this.senhaDaPartida.Size = new System.Drawing.Size(100, 21);
            this.senhaDaPartida.TabIndex = 4;
            this.senhaDaPartida.TextChanged += new System.EventHandler(this.textBox1_TextChanged_2);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(138, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Senha:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // nomeDoGrupo
            // 
            this.nomeDoGrupo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.nomeDoGrupo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nomeDoGrupo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.nomeDoGrupo.Location = new System.Drawing.Point(273, 71);
            this.nomeDoGrupo.Name = "nomeDoGrupo";
            this.nomeDoGrupo.Size = new System.Drawing.Size(100, 21);
            this.nomeDoGrupo.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(271, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Grupo:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AccessibleRole = System.Windows.Forms.AccessibleRole.Diagram;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(260, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(251, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Defensores de Hastings\r\n";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // idDaPartida
            // 
            this.idDaPartida.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.idDaPartida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idDaPartida.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.idDaPartida.Location = new System.Drawing.Point(487, 71);
            this.idDaPartida.Name = "idDaPartida";
            this.idDaPartida.ReadOnly = true;
            this.idDaPartida.Size = new System.Drawing.Size(100, 21);
            this.idDaPartida.TabIndex = 9;
            this.idDaPartida.TextChanged += new System.EventHandler(this.idDaPartida_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(485, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "ID:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(757, 421);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 29);
            this.label6.TabIndex = 10;
            this.label6.Text = "1.0";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(15, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Buscar Partidas";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listBox1.Font = new System.Drawing.Font("Arial", 9F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(15, 216);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(242, 214);
            this.listBox1.TabIndex = 13;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            // 
            // listBox2
            // 
            this.listBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listBox2.Font = new System.Drawing.Font("Arial", 9F);
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Location = new System.Drawing.Point(273, 216);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(139, 214);
            this.listBox2.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.idDaPartida);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nomeDoGrupo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.senhaDaPartida);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nomeDaPartida);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPartida);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Form1";
            this.Text = "Lobby";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPartida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nomeDaPartida;
        private System.Windows.Forms.TextBox senhaDaPartida;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nomeDoGrupo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox idDaPartida;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
    }
}

