﻿namespace Ex7_ConversaoDolar_WinForms
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.n1 = new System.Windows.Forms.TextBox();
            this.n2 = new System.Windows.Forms.TextBox();
            this.Calcular = new System.Windows.Forms.Button();
            this.Resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DIGITE COTAÇÃO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "DIGITE VALOR EM DOLAR:";
            // 
            // n1
            // 
            this.n1.Location = new System.Drawing.Point(118, 66);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(187, 20);
            this.n1.TabIndex = 2;
            // 
            // n2
            // 
            this.n2.Location = new System.Drawing.Point(162, 120);
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(143, 20);
            this.n2.TabIndex = 3;
            this.n2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Calcular
            // 
            this.Calcular.Location = new System.Drawing.Point(15, 175);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(75, 23);
            this.Calcular.TabIndex = 4;
            this.Calcular.Text = "Converter";
            this.Calcular.UseVisualStyleBackColor = true;
            this.Calcular.Click += new System.EventHandler(this.Calcular_Click);
            // 
            // Resultado
            // 
            this.Resultado.AutoSize = true;
            this.Resultado.Location = new System.Drawing.Point(115, 180);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(50, 13);
            this.Resultado.TabIndex = 5;
            this.Resultado.Text = "resultado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.Calcular);
            this.Controls.Add(this.n2);
            this.Controls.Add(this.n1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox n1;
        private System.Windows.Forms.TextBox n2;
        private System.Windows.Forms.Button Calcular;
        private System.Windows.Forms.Label Resultado;
    }
}

