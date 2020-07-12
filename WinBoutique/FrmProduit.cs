using MetierBoutique.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinBoutique
{
    public partial class FrmProduit : Form
    {

        MetiersBoutique.Service1Client service = new MetiersBoutique.Service1Client();
        public FrmProduit()
        {
            InitializeComponent();
            actualiserDgProduit();
            txtRecherche.Enabled = false; //desactiver la zone de recherche
        }

        private void FrmProduit_Load(object sender, EventArgs e)
        {
            actualiserDgProduit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //activer la zone de recherche.
            txtRecherche.Enabled = true;
            txtRecherche.Text = "";
        }

        private void txtRecherche_Enter(object sender, EventArgs e)
        {
            if (txtRecherche.Text == "Recherche")
            {
                txtRecherche.Text = "";
                txtRecherche.ForeColor = Color.Black; 
            }
        }

        public void actualiserDgProduit()
        {
            dgProduit.Rows.Clear();
            Categorie cat = new Categorie();
            foreach (var p in service.getListeProduits())
            {
                cat = service.getCategorieById(p.IdCategorie);
                if(cat != null)
                {
                    dgProduit.Rows.Add(false,p.Id, p.CodeProduit, p.DesignationProduit, p.QuantiteMinimale, p.QuantiteQritique, p.Pu, cat.DesignationCategorie);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Frm_Ajout_Mod_Produit frame = new Frm_Ajout_Mod_Produit();
            frame.ShowDialog();
        }

        private void txtRecherche_Leave(object sender, EventArgs e)
        {
            if (txtRecherche.Text.Trim() == "")
            {
                txtRecherche.Text = "Recherche";
                txtRecherche.ForeColor = Color.DimGray;
            }
        }

        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {
            var  listeprod = service.getListeProduits();
            string attribut, val;
            double val1;
            if(txtRecherche.Text != "")
            {
                switch (comboBox1.Text)
                {
                    case "Code":
                        attribut = "code";
                        val = txtRecherche.Text;
                        listeprod = service.getListeProduitsByAttribut(listeprod, attribut, val);                        
                        break;
                    case "Designation":
                        attribut = "designation";
                        val = txtRecherche.Text;
                        listeprod = service.getListeProduitsByAttribut(listeprod, attribut, val);                        
                        break;
                    case "Quantite Minimum":
                        attribut = "qteMin";
                        if (txtRecherche.Text != "")
                        {
                            val1 = double.Parse(txtRecherche.Text);
                            listeprod = service.getListeProduitsByAttributInt(listeprod, attribut, val1);
                        }                         
                        break;
                    case "Quantite Critique":
                        attribut = "qteCrit";
                        if (txtRecherche.Text != "")
                        {
                            val1 = double.Parse(txtRecherche.Text);
                            listeprod = service.getListeProduitsByAttributInt(listeprod, attribut, val1);
                        }
                        break;
                }
            }
            //MessageBox.Show("bien");

            dgProduit.Rows.Clear();

            foreach (var p in listeprod)
            {
                var cat = service.getCategorieById(p.IdCategorie);
                if (cat != null)
                {
                    dgProduit.Rows.Add(false, p.Id, p.CodeProduit, p.DesignationProduit, p.QuantiteMinimale, p.QuantiteQritique, p.Pu, cat.DesignationCategorie);
                }
            }


        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            Frm_Ajout_Mod_Produit frmAddMod = new Frm_Ajout_Mod_Produit();

            if(selectVerif() == null )
            {
                for (int i = 0; i < dgProduit.Rows.Count; i++)
                {
                    if ((bool)dgProduit.Rows[i].Cells[0].Value == true)
                    {
                        frmAddMod.idProduit = int.Parse(dgProduit.Rows[i].Cells[1].Value.ToString());

                        frmAddMod.txtCode.Text = dgProduit.Rows[i].Cells[2].Value.ToString();
                        frmAddMod.txtDesignation.Text = dgProduit.Rows[i].Cells[3].Value.ToString();
                        frmAddMod.txtQteMin.Text = dgProduit.Rows[i].Cells[4].Value.ToString();
                        frmAddMod.txtQteCrit.Text = dgProduit.Rows[i].Cells[5].Value.ToString();
                        frmAddMod.txtPU.Text = dgProduit.Rows[i].Cells[6].Value.ToString();
                        //frmAddMod.txtQteMax.Text = dgProduit.Rows[i].Cells[3].Value.ToString();
                        frmAddMod.cbxCategorie.Text = dgProduit.Rows[i].Cells[7].Value.ToString();

                        frmAddMod.txtCode.ForeColor = Color.White;
                        frmAddMod.txtDesignation.ForeColor = Color.White;
                        frmAddMod.txtQteMin.ForeColor = Color.White;
                        frmAddMod.txtQteCrit.ForeColor = Color.White;
                        frmAddMod.txtPU.ForeColor = Color.White;
                        frmAddMod.lblTitre.Text = "Modifier Produit";

                    }
                }
                frmAddMod.ShowDialog();
            }
            else
            {
                MessageBox.Show(selectVerif(), "Alert");
            }

        }

        public string selectVerif()
        {
            int nbLigneSelect = 0;
            for (int i = 0; i < dgProduit.Rows.Count; i++)
            {
                if ((bool)dgProduit.Rows[i].Cells[0].Value == true)
                {
                    nbLigneSelect++;
                }
            }


            if(nbLigneSelect == 0)
            {
                return "Selectionner un Produit";
            }
            if(nbLigneSelect > 1)
            {
                return "Selectionner une (1) seule produit";
            }

            return null;
        }

        public string selectVerifSupprimer()
        {
            int nbLigneSelect = 0;
            for (int i = 0; i < dgProduit.Rows.Count; i++)
            {
                if ((bool)dgProduit.Rows[i].Cells[0].Value == true)
                {
                    nbLigneSelect++;
                }
            }


            if (nbLigneSelect == 0)
            {
                return "Selectionner un Produit";
            }

            return null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            actualiserDgProduit();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (selectVerifSupprimer() == null)
            {
                if (confirmDelete() == true)
                {
                    int nbrEltChochet=0, nbreEltSupprimer =0 ;
                    for (int i = 0; i < dgProduit.Rows.Count; i++)
                    {
                        if ((bool)dgProduit.Rows[i].Cells[0].Value == true)
                        {
                            nbrEltChochet++;
                            int idProduit = int.Parse(dgProduit.Rows[i].Cells[1].Value.ToString());
                            if (service.deleteProduit(idProduit))
                            {
                                nbreEltSupprimer++;   
                            }

                        }
                    }   
                    
                    if(nbrEltChochet == nbreEltSupprimer)
                    {
                        MessageBox.Show("Suppression terminé avec succés");
                        actualiserDgProduit();
                    }
                    else
                    {
                        MessageBox.Show("Erreur de suppression!", "Suppression");
                    }
                }
                
            }
        }

        private bool confirmDelete()
        {
            if (MessageBox.Show("Voulez-vous vraiment supprimer ce produit", "Message de confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
