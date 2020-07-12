using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetierBoutique.Model;

namespace WinBoutique
{
    public partial class Frm_Ajout_Mod_Produit : Form
    {
        MetiersBoutique.Service1Client service = new MetiersBoutique.Service1Client();
        private UserControl userProduit;
        public int idProduit;
        public Frm_Ajout_Mod_Produit()
        {
            InitializeComponent();
           //this.userProduit = User;
        }

        private void Frm_Ajout_Mod_Produit_Load(object sender, EventArgs e)
        {
            cbxCategorie.DisplayMember = "DesignationCategorie";
            cbxCategorie.ValueMember = "id";
            cbxCategorie.DataSource = service.getListeCategorie();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnParcourir_Click(object sender, EventArgs e)
        {
            OpenFileDialog OP = new OpenFileDialog();
            OP.Filter = "|*.JPG;*.PNG;*.GIF;*.BMP";

            if(OP.ShowDialog() == DialogResult.OK)
            {
                pbxImage.Image = Image.FromFile(OP.FileName);
            }
        }

        private void txtCode_Leave(object sender, EventArgs e)
        {
            if(txtCode.Text.Trim() == "")
            {
                txtCode.Text = "Code";
                txtCode.ForeColor = Color.DimGray;
            }
        }

        private void txtCode_Enter(object sender, EventArgs e)
        {
            if (txtCode.Text.Trim() == "Code")
            {
                txtCode.Text = "";
                txtCode.ForeColor = Color.White;
            }
        }

        private void txtQteMin_Enter(object sender, EventArgs e)
        {
            if (txtQteMin.Text.Trim() == "Quantité Minimum")
            {
                txtQteMin.Text = "";
                txtQteMin.ForeColor = Color.White;
            }
        }

        private void txtQteMin_Leave(object sender, EventArgs e)
        {
            if (txtQteMin.Text.Trim() == "")
            {
                txtQteMin.Text = "Quantité Minimum";
                txtQteMin.ForeColor = Color.DimGray;
            }
        }

        private void txtDesignation_Enter(object sender, EventArgs e)
        {
            if (txtDesignation.Text.Trim() == "Designation")
            {
                txtDesignation.Text = "";
                txtDesignation.ForeColor = Color.White;
            }
        }

        private void txtDesignation_Leave(object sender, EventArgs e)
        {
            if (txtDesignation.Text.Trim() == "")
            {
                txtDesignation.Text = "Designation";
                txtDesignation.ForeColor = Color.DimGray;
            }
        }

        private void txtQteMax_Enter(object sender, EventArgs e)
        {
            if (txtQteMax.Text.Trim() == "Quantité Maximum")
            {
                txtQteMax.Text = "";
                txtQteMax.ForeColor = Color.White;
            }
        }

        private void txtQteMax_Leave(object sender, EventArgs e)
        {
            if (txtQteMax.Text.Trim() == "")
            {
                txtQteMax.Text = "Quantité Maximum";
                txtQteMax.ForeColor = Color.DimGray;
            }
        }

        private void txtPU_Enter(object sender, EventArgs e)
        {
            if (txtPU.Text.Trim() == "Prix Unitaire")
            {
                txtPU.Text = "";
                txtPU.ForeColor = Color.White;
            }
        }

        private void txtPU_Leave(object sender, EventArgs e)
        {
            if (txtPU.Text.Trim() == "")
            {
                txtPU.Text = "Prix Unitaire";
                txtPU.ForeColor = Color.DimGray;
            }
        }

        private void txtQteCrit_Enter(object sender, EventArgs e)
        {
            if (txtQteCrit.Text.Trim() == "Quantité Critique")
            {
                txtQteCrit.Text = "";
                txtQteCrit.ForeColor = Color.White;
            }
        }

        private void txtQteCrit_Leave(object sender, EventArgs e)
        {
            if (txtQteCrit.Text.Trim() == "")
            {
                txtQteCrit.Text = "Quantité Critique";
                txtQteCrit.ForeColor = Color.DimGray;
            }
        }

        private void cbxCategorie_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            if (!isVide())
            {
                if (lblTitre.Text == "Modifier Produit")
                {
                    Produit p = service.getProduitById(idProduit);
                    p.IdCategorie = int.Parse(cbxCategorie.SelectedValue.ToString());
                    p.CodeProduit = txtCode.Text;
                    p.QuantiteQritique = int.Parse(txtQteCrit.Text);
                    p.QuantiteMinimale = int.Parse(txtQteMin.Text);
                    p.Pu = int.Parse(txtPU.Text);
                    p.DesignationProduit = txtDesignation.Text;
                    if (service.updateProduit(p))
                    {
                        MessageBox.Show("Produit modifié", "Modifier");
                        vider();

                    }
                    else
                    {
                        MessageBox.Show("Erreur! Veuillez vérifier les elements saisie", "Modifier");
                    }

                }
                else
                {
                    Produit p = new Produit();
                    p.IdCategorie = int.Parse(cbxCategorie.SelectedValue.ToString());
                    p.CodeProduit = txtCode.Text;
                    p.QuantiteQritique = int.Parse(txtQteCrit.Text);
                    p.QuantiteMinimale = int.Parse(txtQteMin.Text);
                    p.Pu = int.Parse(txtPU.Text);
                    p.DesignationProduit = txtDesignation.Text;
                    if (service.addProduit(p))
                    {
                        MessageBox.Show("Produit ajouté avec succés", "Ajouter");
                        // (userProduit as FrmProduit).actualiserDgProduit();

                        FrmProduit fp = new FrmProduit();
                        fp.Refresh();
                        vider();
                    }
                    else
                    {
                        MessageBox.Show("Erreur! Veuillez vérifier le produit", "Ajouter");
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs SVP !");
            }
            
        }

        private void vider()
        {
            txtCode.Text = "Code";
            txtCode.ForeColor = Color.DimGray;
            txtQteMin.Text = "Quantité Minimum";
            txtQteMin.ForeColor = Color.DimGray;
            txtQteMax.Text = "Quantité Maximum";
            txtQteMax.ForeColor = Color.DimGray;
            txtPU.Text = "Prix Unitaire";
            txtPU.ForeColor = Color.DimGray;
            txtQteCrit.Text = "Quantité Critique";
            txtQteCrit.ForeColor = Color.DimGray;
            txtDesignation.Text = "Designation";
            txtDesignation.ForeColor = Color.DimGray;
            cbxCategorie.DataSource = service.getListeCategorie();
            cbxCategorie.DisplayMember = "DesignationCategorie";
            cbxCategorie.ValueMember = "id";


        }

        private void btnActualiser_Click(object sender, EventArgs e)
        {
            vider();
        }

        private bool isVide()
        {
            if(txtCode.Text == "Code" || txtCode.Text.Trim() == "" || txtDesignation.Text == "Designation" || txtDesignation.Text.Trim() == ""
                || txtQteMin.Text == "Quantité Minimum" || txtQteMin.Text.Trim() == "" || txtQteCrit.Text == "Quantité Critique" || txtQteCrit.Text.Trim() == ""
                || txtPU.Text == "Prix Unitaire" || txtPU.Text.Trim() == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
