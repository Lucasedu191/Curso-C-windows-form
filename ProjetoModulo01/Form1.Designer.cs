namespace ProjetoModulo01
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lvlNomes = new System.Windows.Forms.ListView();
            this.clhNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhIdade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblIdade = new System.Windows.Forms.Label();
            this.txtBoxIdade = new System.Windows.Forms.TextBox();
            this.btnRemoverNome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnBotao1
            // 
            this.BtnBotao1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnBotao1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBotao1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBotao1.Location = new System.Drawing.Point(248, 61);
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
            this.Btnbotao2.Location = new System.Drawing.Point(353, 61);
            this.Btnbotao2.Name = "Btnbotao2";
            this.Btnbotao2.Size = new System.Drawing.Size(75, 23);
            this.Btnbotao2.TabIndex = 1;
            this.Btnbotao2.Text = "Limpar";
            this.Btnbotao2.UseVisualStyleBackColor = false;
            this.Btnbotao2.Click += new System.EventHandler(this.Btnbotao2_Click);
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Location = new System.Drawing.Point(7, 61);
            this.txtNome.MaxLength = 100;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(109, 20);
            this.txtNome.TabIndex = 4;
            this.txtNome.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            this.txtNome.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(14, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome:";
            // 
            // lvlNomes
            // 
            this.lvlNomes.AllowColumnReorder = true;
            this.lvlNomes.BackColor = System.Drawing.Color.Chartreuse;
            this.lvlNomes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvlNomes.CheckBoxes = true;
            this.lvlNomes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhNome,
            this.clhIdade});
            this.lvlNomes.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlNomes.FullRowSelect = true;
            this.lvlNomes.GridLines = true;
            this.lvlNomes.Location = new System.Drawing.Point(47, 122);
            this.lvlNomes.Name = "lvlNomes";
            this.lvlNomes.Size = new System.Drawing.Size(352, 137);
            this.lvlNomes.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvlNomes.TabIndex = 6;
            this.lvlNomes.UseCompatibleStateImageBehavior = false;
            this.lvlNomes.View = System.Windows.Forms.View.Details;
            this.lvlNomes.DoubleClick += new System.EventHandler(this.lvlNomes_DoubleClick);
            // 
            // clhNome
            // 
            this.clhNome.Text = "Nome";
            this.clhNome.Width = 200;
            // 
            // clhIdade
            // 
            this.clhIdade.Text = "idade";
            this.clhIdade.Width = 150;
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblIdade.Location = new System.Drawing.Point(144, 33);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(37, 13);
            this.lblIdade.TabIndex = 7;
            this.lblIdade.Text = "Idade:";
            // 
            // txtBoxIdade
            // 
            this.txtBoxIdade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtBoxIdade.Location = new System.Drawing.Point(132, 60);
            this.txtBoxIdade.Name = "txtBoxIdade";
            this.txtBoxIdade.Size = new System.Drawing.Size(100, 20);
            this.txtBoxIdade.TabIndex = 8;
            this.txtBoxIdade.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxIdade_Validating);
            // 
            // btnRemoverNome
            // 
            this.btnRemoverNome.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRemoverNome.Image = global::ProjetoModulo01.Properties.Resources.if_icon_82_document_remove_314765;
            this.btnRemoverNome.Location = new System.Drawing.Point(421, 215);
            this.btnRemoverNome.Name = "btnRemoverNome";
            this.btnRemoverNome.Size = new System.Drawing.Size(45, 44);
            this.btnRemoverNome.TabIndex = 9;
            this.btnRemoverNome.UseVisualStyleBackColor = false;
            this.btnRemoverNome.Click += new System.EventHandler(this.btnRemoverNome_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(490, 271);
            this.Controls.Add(this.btnRemoverNome);
            this.Controls.Add(this.txtBoxIdade);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.lvlNomes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
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
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvlNomes;
        private System.Windows.Forms.ColumnHeader clhNome;
        private System.Windows.Forms.ColumnHeader clhIdade;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.TextBox txtBoxIdade;
        private System.Windows.Forms.Button btnRemoverNome;
    }
}

