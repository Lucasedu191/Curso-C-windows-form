﻿namespace ProjetoModulo01
{
    partial class Form1
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
            this.BtnBotao1 = new System.Windows.Forms.Button();
            this.Btnbotao2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkExemplo = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // BtnBotao1
            // 
            this.BtnBotao1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnBotao1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBotao1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBotao1.Location = new System.Drawing.Point(321, 61);
            this.BtnBotao1.Name = "BtnBotao1";
            this.BtnBotao1.Size = new System.Drawing.Size(75, 23);
            this.BtnBotao1.TabIndex = 0;
            this.BtnBotao1.Text = "Cadastrar";
            this.BtnBotao1.UseVisualStyleBackColor = false;
            this.BtnBotao1.Click += new System.EventHandler(this.BtnBotao1_Click);
            // 
            // Btnbotao2
            // 
            this.Btnbotao2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Btnbotao2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btnbotao2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btnbotao2.Location = new System.Drawing.Point(321, 121);
            this.Btnbotao2.Name = "Btnbotao2";
            this.Btnbotao2.Size = new System.Drawing.Size(75, 23);
            this.Btnbotao2.TabIndex = 1;
            this.Btnbotao2.Text = "Limpar";
            this.Btnbotao2.UseVisualStyleBackColor = false;
            this.Btnbotao2.Click += new System.EventHandler(this.Btnbotao2_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(47, 61);
            this.textBox1.MaxLength = 100;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            this.textBox1.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(54, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome:";
            // 
            // chkExemplo
            // 
            this.chkExemplo.AutoSize = true;
            this.chkExemplo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.chkExemplo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chkExemplo.Location = new System.Drawing.Point(12, 121);
            this.chkExemplo.Name = "chkExemplo";
            this.chkExemplo.Size = new System.Drawing.Size(43, 17);
            this.chkExemplo.TabIndex = 6;
            this.chkExemplo.Text = "Sim";
            this.chkExemplo.UseVisualStyleBackColor = false;
            this.chkExemplo.CheckStateChanged += new System.EventHandler(this.chkExemplo_CheckStateChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 271);
            this.Controls.Add(this.chkExemplo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Btnbotao2);
            this.Controls.Add(this.BtnBotao1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "Form1";
            this.Text = "Frmmain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnBotao1;
        private System.Windows.Forms.Button Btnbotao2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkExemplo;
    }
}

