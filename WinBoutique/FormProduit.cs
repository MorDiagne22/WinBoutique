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
    public partial class FormProduit : Form
    {
        MetiersBoutique.Service1Client service = new MetiersBoutique.Service1Client();

        public FormProduit()
        {
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Produit p = new Produit();
            p.IdCategorie = int.Parse(cbbCategorie.SelectedValue.ToString());
            p.CodeProduit = txtCode.Text;
            p.Quantite = int.Parse(txtQuantite.Text);
            p.QuantiteQritique = int.Parse(txtQteCritique.Text);
            p.QuantiteMinimale = int.Parse(txtQteMin.Text);
            p.Pu = int.Parse(txtPrixUnitaire.Text);
            p.DesignationProduit = txtDesignation.Text;
            p.Image = txtImage.Text;
            service.addProduit(p);
            vider();
        }

        private void FormProduit_Load(object sender, EventArgs e)
        {
            var listeProduit = service.getListeProduits().Select(a => new
            {
                id = a.Id,
                Code = a.CodeProduit,
                Designation = a.DesignationProduit,
                QteMin = a.QuantiteMinimale,
                QteCri = a.QuantiteQritique,
                Prix = a.Pu,
                Categorie = a.IdCategorie
            }).ToList() ;

            dgProduit.DataSource = listeProduit;
            cbbCategorie.DisplayMember = "DesignationCategorie";
            cbbCategorie.ValueMember = "id";
            cbbCategorie.DataSource = service.getListeCategorie();
            
        }

        private void vider()
        {
            txtCode.Text = string.Empty;
            txtQuantite.Text = string.Empty;
            txtQteMin.Text = string.Empty;
            txtQteCritique.Text = string.Empty;
            txtPrixUnitaire.Text = string.Empty;
            txtImage.Text = string.Empty;
            txtDesignation.Text = string.Empty;

            dgProduit.DataSource = service.getListeProduits();
           
            cbbCategorie.DataSource = service.getListeCategorie();
            cbbCategorie.DisplayMember = "DesignationCategorie";
            cbbCategorie.ValueMember = "id";
            

        }

        private void btnChoisir_Click(object sender, EventArgs e)
        {
            txtCode.Text = dgProduit.CurrentRow.Cells[1].Value.ToString();
            txtDesignation.Text = dgProduit.CurrentRow.Cells[2].Value.ToString();
            txtQuantite.Text = dgProduit.CurrentRow.Cells[3].Value.ToString();
            txtPrixUnitaire.Text = dgProduit.CurrentRow.Cells[6].Value.ToString();
            txtQteMin.Text = dgProduit.CurrentRow.Cells[4].Value.ToString();
            txtQteCritique.Text = dgProduit.CurrentRow.Cells[5].Value.ToString();
            txtImage.Text = dgProduit.CurrentRow.Cells[7].Value.ToString();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            int idProduit = int.Parse(dgProduit.CurrentRow.Cells[0].Value.ToString());
            Produit p = service.getProduitById(idProduit);
            p.CodeProduit = txtCode.Text;
            p.DesignationProduit = txtDesignation.Text;
            p.Quantite = int.Parse(txtQuantite.Text);
            p.QuantiteQritique = int.Parse(txtQteCritique.Text);
            p.QuantiteMinimale = int.Parse(txtQteMin.Text);
            p.Pu = int.Parse(txtPrixUnitaire.Text);
            p.Image = txtImage.Text;
            service.updateProduit(p);
            vider();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (confirmDelete() == true)
            {
                int idProduit = int.Parse(dgProduit.CurrentRow.Cells[0].Value.ToString());
                service.deleteProduit(idProduit);
                vider();
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

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChoisir_Click_1(object sender, EventArgs e)
        {
            txtCode.Text = dgProduit.CurrentRow.Cells[1].Value.ToString();
            txtDesignation.Text = dgProduit.CurrentRow.Cells[2].Value.ToString();
            txtQuantite.Text = dgProduit.CurrentRow.Cells[3].Value.ToString();
            txtPrixUnitaire.Text = dgProduit.CurrentRow.Cells[6].Value.ToString();
            txtQteMin.Text = dgProduit.CurrentRow.Cells[4].Value.ToString();
            txtQteCritique.Text = dgProduit.CurrentRow.Cells[5].Value.ToString();
            //Text = dgProduit.CurrentRow.Cells[7].Value.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
