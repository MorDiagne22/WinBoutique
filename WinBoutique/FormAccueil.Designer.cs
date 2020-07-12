namespace WinBoutique
{
    partial class FormAccueil
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
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnCategorie = new System.Windows.Forms.Button();
            this.panelBout = new System.Windows.Forms.Panel();
            this.btnUtilisateur = new System.Windows.Forms.Button();
            this.btnCommande = new System.Windows.Forms.Button();
            this.btnClient = new System.Windows.Forms.Button();
            this.btnProduit = new System.Windows.Forms.Button();
            this.btnReduire = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelChildForm
            // 
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelChildForm.Location = new System.Drawing.Point(209, 43);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(960, 547);
            this.panelChildForm.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Crimson;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(209, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(960, 13);
            this.panel4.TabIndex = 1;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.panelMenu.Controls.Add(this.btnCategorie);
            this.panelMenu.Controls.Add(this.panelBout);
            this.panelMenu.Controls.Add(this.btnUtilisateur);
            this.panelMenu.Controls.Add(this.btnCommande);
            this.panelMenu.Controls.Add(this.btnClient);
            this.panelMenu.Controls.Add(this.btnProduit);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(209, 590);
            this.panelMenu.TabIndex = 0;
            // 
            // btnCategorie
            // 
            this.btnCategorie.BackColor = System.Drawing.Color.Transparent;
            this.btnCategorie.FlatAppearance.BorderSize = 0;
            this.btnCategorie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategorie.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategorie.ForeColor = System.Drawing.Color.White;
            this.btnCategorie.Image = global::WinBoutique.Properties.Resources.Categorie;
            this.btnCategorie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategorie.Location = new System.Drawing.Point(12, 250);
            this.btnCategorie.Name = "btnCategorie";
            this.btnCategorie.Size = new System.Drawing.Size(186, 57);
            this.btnCategorie.TabIndex = 0;
            this.btnCategorie.Text = "        Catégorie";
            this.btnCategorie.UseVisualStyleBackColor = false;
            this.btnCategorie.Click += new System.EventHandler(this.btnCategorie_Click);
            // 
            // panelBout
            // 
            this.panelBout.BackColor = System.Drawing.Color.Crimson;
            this.panelBout.Location = new System.Drawing.Point(1, 78);
            this.panelBout.Name = "panelBout";
            this.panelBout.Size = new System.Drawing.Size(10, 57);
            this.panelBout.TabIndex = 0;
            // 
            // btnUtilisateur
            // 
            this.btnUtilisateur.BackColor = System.Drawing.Color.Transparent;
            this.btnUtilisateur.FlatAppearance.BorderSize = 0;
            this.btnUtilisateur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUtilisateur.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUtilisateur.ForeColor = System.Drawing.Color.White;
            this.btnUtilisateur.Image = global::WinBoutique.Properties.Resources.customer_service_icon;
            this.btnUtilisateur.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUtilisateur.Location = new System.Drawing.Point(12, 422);
            this.btnUtilisateur.Name = "btnUtilisateur";
            this.btnUtilisateur.Size = new System.Drawing.Size(186, 57);
            this.btnUtilisateur.TabIndex = 0;
            this.btnUtilisateur.Text = "       Utilisateur";
            this.btnUtilisateur.UseVisualStyleBackColor = false;
            this.btnUtilisateur.Click += new System.EventHandler(this.btnUtilisateur_Click);
            // 
            // btnCommande
            // 
            this.btnCommande.BackColor = System.Drawing.Color.Transparent;
            this.btnCommande.FlatAppearance.BorderSize = 0;
            this.btnCommande.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCommande.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCommande.ForeColor = System.Drawing.Color.White;
            this.btnCommande.Image = global::WinBoutique.Properties.Resources.shopping_icon;
            this.btnCommande.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCommande.Location = new System.Drawing.Point(12, 336);
            this.btnCommande.Name = "btnCommande";
            this.btnCommande.Size = new System.Drawing.Size(186, 57);
            this.btnCommande.TabIndex = 0;
            this.btnCommande.Text = "        Commande";
            this.btnCommande.UseVisualStyleBackColor = false;
            this.btnCommande.Click += new System.EventHandler(this.btnCommande_Click);
            // 
            // btnClient
            // 
            this.btnClient.BackColor = System.Drawing.Color.Transparent;
            this.btnClient.FlatAppearance.BorderSize = 0;
            this.btnClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClient.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClient.ForeColor = System.Drawing.Color.White;
            this.btnClient.Image = global::WinBoutique.Properties.Resources.Office_Client_Male_Light_icon;
            this.btnClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClient.Location = new System.Drawing.Point(12, 78);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(186, 57);
            this.btnClient.TabIndex = 0;
            this.btnClient.Text = "     Client";
            this.btnClient.UseVisualStyleBackColor = false;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // btnProduit
            // 
            this.btnProduit.BackColor = System.Drawing.Color.Transparent;
            this.btnProduit.FlatAppearance.BorderSize = 0;
            this.btnProduit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduit.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduit.ForeColor = System.Drawing.Color.White;
            this.btnProduit.Image = global::WinBoutique.Properties.Resources.shop_cart_add_icon;
            this.btnProduit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduit.Location = new System.Drawing.Point(12, 164);
            this.btnProduit.Name = "btnProduit";
            this.btnProduit.Size = new System.Drawing.Size(186, 57);
            this.btnProduit.TabIndex = 0;
            this.btnProduit.Text = "     Produit";
            this.btnProduit.UseVisualStyleBackColor = false;
            this.btnProduit.Click += new System.EventHandler(this.btnProduit_Click);
            // 
            // btnReduire
            // 
            this.btnReduire.FlatAppearance.BorderSize = 0;
            this.btnReduire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReduire.Image = global::WinBoutique.Properties.Resources.Subtract_32;
            this.btnReduire.Location = new System.Drawing.Point(1113, 14);
            this.btnReduire.Name = "btnReduire";
            this.btnReduire.Size = new System.Drawing.Size(19, 28);
            this.btnReduire.TabIndex = 2;
            this.btnReduire.UseVisualStyleBackColor = true;
            this.btnReduire.Click += new System.EventHandler(this.btnReduire_Click);
            // 
            // btnFermer
            // 
            this.btnFermer.FlatAppearance.BorderSize = 0;
            this.btnFermer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFermer.Image = global::WinBoutique.Properties.Resources.Shutdown_32;
            this.btnFermer.Location = new System.Drawing.Point(1136, 14);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(31, 28);
            this.btnFermer.TabIndex = 2;
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // FormAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 590);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.btnReduire);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAccueil";
            this.Text = "FormAccueil";
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnProduit;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Button btnReduire;
        private System.Windows.Forms.Button btnUtilisateur;
        private System.Windows.Forms.Button btnCommande;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Button btnCategorie;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelBout;
    }
}