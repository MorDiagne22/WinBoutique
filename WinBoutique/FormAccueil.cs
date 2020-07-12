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
    public partial class FormAccueil : Form
    {
        public FormAccueil()
        {
            InitializeComponent();
        }

        private Form activeForm = null;

        private void openChildForm(Form childForm)
        {
            
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            
        }


        

        private void btnProduit_Click(object sender, EventArgs e)
        {
            panelBout.Top = btnProduit.Top;
            //openChildForm(new FormProduit());
            openChildForm(new FrmProduit());
        }

        private void btnCategorie_Click(object sender, EventArgs e)
        {
            panelBout.Top = btnCategorie.Top;
            openChildForm(new Form1());
        }

       
        private void btnReduire_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            panelBout.Top = btnClient.Top;
        }

        private void btnCommande_Click(object sender, EventArgs e)
        {
            panelBout.Top = btnCommande.Top;
        }

        private void btnUtilisateur_Click(object sender, EventArgs e)
        {
            panelBout.Top = btnUtilisateur.Top;
        }
    }
}
