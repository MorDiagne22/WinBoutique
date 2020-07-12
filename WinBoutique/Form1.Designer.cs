namespace WinBoutique
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgCategorie = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtDesignation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSuprprimer = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgCategorie)).BeginInit();
            this.SuspendLayout();
            // 
            // dgCategorie
            // 
            this.dgCategorie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCategorie.Location = new System.Drawing.Point(418, 51);
            this.dgCategorie.Margin = new System.Windows.Forms.Padding(2);
            this.dgCategorie.Name = "dgCategorie";
            this.dgCategorie.RowTemplate.Height = 24;
            this.dgCategorie.Size = new System.Drawing.Size(391, 499);
            this.dgCategorie.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Code";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(40, 105);
            this.txtCode.Margin = new System.Windows.Forms.Padding(2);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(336, 20);
            this.txtCode.TabIndex = 2;
            // 
            // txtDesignation
            // 
            this.txtDesignation.Location = new System.Drawing.Point(40, 177);
            this.txtDesignation.Margin = new System.Windows.Forms.Padding(2);
            this.txtDesignation.Multiline = true;
            this.txtDesignation.Name = "txtDesignation";
            this.txtDesignation.Size = new System.Drawing.Size(336, 76);
            this.txtDesignation.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 151);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Désignation";
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(40, 274);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(2);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(88, 32);
            this.btnAjouter.TabIndex = 5;
            this.btnAjouter.Text = "&Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(40, 332);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(2);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(88, 32);
            this.btnModifier.TabIndex = 6;
            this.btnModifier.Text = "&Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSuprprimer
            // 
            this.btnSuprprimer.Location = new System.Drawing.Point(40, 393);
            this.btnSuprprimer.Margin = new System.Windows.Forms.Padding(2);
            this.btnSuprprimer.Name = "btnSuprprimer";
            this.btnSuprprimer.Size = new System.Drawing.Size(88, 32);
            this.btnSuprprimer.TabIndex = 7;
            this.btnSuprprimer.Text = "&Supprimer";
            this.btnSuprprimer.UseVisualStyleBackColor = true;
            this.btnSuprprimer.Click += new System.EventHandler(this.btnSuprprimer_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(287, 274);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(88, 32);
            this.btnSelect.TabIndex = 8;
            this.btnSelect.Text = "&choisir";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(20, 584);
            this.btnQuitter.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(88, 32);
            this.btnQuitter.TabIndex = 9;
            this.btnQuitter.Text = "&Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            // 
            // btnRetour
            // 
            this.btnRetour.BackColor = System.Drawing.Color.Red;
            this.btnRetour.ForeColor = System.Drawing.Color.White;
            this.btnRetour.Location = new System.Drawing.Point(862, 0);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(20, 23);
            this.btnRetour.TabIndex = 10;
            this.btnRetour.Text = "X";
            this.btnRetour.UseVisualStyleBackColor = false;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 561);
            this.ControlBox = false;
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnSuprprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.txtDesignation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgCategorie);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Catégorie";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCategorie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgCategorie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtDesignation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSuprprimer;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnRetour;
    }
}

