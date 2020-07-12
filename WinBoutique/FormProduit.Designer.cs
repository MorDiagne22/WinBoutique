namespace WinBoutique
{
    partial class FormProduit
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
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.txtImage = new System.Windows.Forms.TextBox();
            this.txtQteCritique = new System.Windows.Forms.TextBox();
            this.txtQteMin = new System.Windows.Forms.TextBox();
            this.txtPrixUnitaire = new System.Windows.Forms.TextBox();
            this.txtQuantite = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDesignation = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbCategorie = new System.Windows.Forms.ComboBox();
            this.btnRetour = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnChoisir = new System.Windows.Forms.Button();
            this.dgProduit = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProduit)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.Red;
            this.btnSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupprimer.Font = new System.Drawing.Font("Gabriola", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.Location = new System.Drawing.Point(596, 517);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(111, 34);
            this.btnSupprimer.TabIndex = 36;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifier.Font = new System.Drawing.Font("Gabriola", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.Location = new System.Drawing.Point(377, 517);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(111, 34);
            this.btnModifier.TabIndex = 35;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.Green;
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouter.Font = new System.Drawing.Font("Gabriola", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.Location = new System.Drawing.Point(154, 517);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(111, 34);
            this.btnAjouter.TabIndex = 34;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // txtImage
            // 
            this.txtImage.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImage.Location = new System.Drawing.Point(236, 475);
            this.txtImage.Name = "txtImage";
            this.txtImage.Size = new System.Drawing.Size(185, 26);
            this.txtImage.TabIndex = 30;
            // 
            // txtQteCritique
            // 
            this.txtQteCritique.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQteCritique.Location = new System.Drawing.Point(553, 441);
            this.txtQteCritique.Name = "txtQteCritique";
            this.txtQteCritique.Size = new System.Drawing.Size(185, 26);
            this.txtQteCritique.TabIndex = 28;
            // 
            // txtQteMin
            // 
            this.txtQteMin.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQteMin.Location = new System.Drawing.Point(236, 441);
            this.txtQteMin.Name = "txtQteMin";
            this.txtQteMin.Size = new System.Drawing.Size(185, 26);
            this.txtQteMin.TabIndex = 26;
            // 
            // txtPrixUnitaire
            // 
            this.txtPrixUnitaire.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrixUnitaire.Location = new System.Drawing.Point(553, 408);
            this.txtPrixUnitaire.Name = "txtPrixUnitaire";
            this.txtPrixUnitaire.Size = new System.Drawing.Size(185, 26);
            this.txtPrixUnitaire.TabIndex = 25;
            // 
            // txtQuantite
            // 
            this.txtQuantite.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantite.Location = new System.Drawing.Point(236, 408);
            this.txtQuantite.Name = "txtQuantite";
            this.txtQuantite.Size = new System.Drawing.Size(185, 26);
            this.txtQuantite.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(433, 442);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 29);
            this.label7.TabIndex = 20;
            this.label7.Text = "Quantité Critique";
            // 
            // txtDesignation
            // 
            this.txtDesignation.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesignation.Location = new System.Drawing.Point(553, 374);
            this.txtDesignation.Name = "txtDesignation";
            this.txtDesignation.Size = new System.Drawing.Size(185, 26);
            this.txtDesignation.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(104, 474);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 29);
            this.label8.TabIndex = 23;
            this.label8.Text = "Image";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(433, 409);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 29);
            this.label5.TabIndex = 24;
            this.label5.Text = "Prix Unitaire";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(104, 440);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 29);
            this.label6.TabIndex = 27;
            this.label6.Text = "Quantité Minimum";
            // 
            // txtCode
            // 
            this.txtCode.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.Location = new System.Drawing.Point(236, 374);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(185, 26);
            this.txtCode.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(104, 407);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 29);
            this.label4.TabIndex = 29;
            this.label4.Text = "Quantité";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(433, 375);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 29);
            this.label3.TabIndex = 31;
            this.label3.Text = "Désignation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(104, 373);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 29);
            this.label2.TabIndex = 32;
            this.label2.Text = "Code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 29);
            this.label1.TabIndex = 16;
            this.label1.Text = "Catégorie";
            // 
            // cbbCategorie
            // 
            this.cbbCategorie.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbCategorie.FormattingEnabled = true;
            this.cbbCategorie.Location = new System.Drawing.Point(159, 333);
            this.cbbCategorie.Name = "cbbCategorie";
            this.cbbCategorie.Size = new System.Drawing.Size(207, 26);
            this.cbbCategorie.TabIndex = 15;
            // 
            // btnRetour
            // 
            this.btnRetour.BackColor = System.Drawing.Color.Red;
            this.btnRetour.FlatAppearance.BorderSize = 0;
            this.btnRetour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetour.ForeColor = System.Drawing.Color.White;
            this.btnRetour.Location = new System.Drawing.Point(858, 1);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(22, 19);
            this.btnRetour.TabIndex = 37;
            this.btnRetour.Text = "X";
            this.btnRetour.UseVisualStyleBackColor = false;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.btnChoisir);
            this.panel1.Controls.Add(this.btnRetour);
            this.panel1.Controls.Add(this.dgProduit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(880, 327);
            this.panel1.TabIndex = 38;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnChoisir
            // 
            this.btnChoisir.BackColor = System.Drawing.Color.Maroon;
            this.btnChoisir.FlatAppearance.BorderSize = 0;
            this.btnChoisir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChoisir.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoisir.ForeColor = System.Drawing.Color.White;
            this.btnChoisir.Location = new System.Drawing.Point(596, 291);
            this.btnChoisir.Name = "btnChoisir";
            this.btnChoisir.Size = new System.Drawing.Size(196, 36);
            this.btnChoisir.TabIndex = 19;
            this.btnChoisir.Text = "Choisir";
            this.btnChoisir.UseVisualStyleBackColor = false;
            this.btnChoisir.Click += new System.EventHandler(this.btnChoisir_Click_1);
            // 
            // dgProduit
            // 
            this.dgProduit.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgProduit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgProduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProduit.Location = new System.Drawing.Point(75, 134);
            this.dgProduit.Name = "dgProduit";
            this.dgProduit.Size = new System.Drawing.Size(716, 157);
            this.dgProduit.TabIndex = 18;
            // 
            // FormProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 561);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.txtImage);
            this.Controls.Add(this.txtQteCritique);
            this.Controls.Add(this.txtQteMin);
            this.Controls.Add(this.txtPrixUnitaire);
            this.Controls.Add(this.txtQuantite);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDesignation);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbCategorie);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProduit";
            this.Text = "Produit";
            this.Load += new System.EventHandler(this.FormProduit_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgProduit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.TextBox txtImage;
        private System.Windows.Forms.TextBox txtQteCritique;
        private System.Windows.Forms.TextBox txtQteMin;
        private System.Windows.Forms.TextBox txtPrixUnitaire;
        private System.Windows.Forms.TextBox txtQuantite;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDesignation;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbCategorie;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnChoisir;
        private System.Windows.Forms.DataGridView dgProduit;
    }
}