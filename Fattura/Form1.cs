using FatturaMucca.Models;
using System;
using System.Windows.Forms;

namespace FatturaMucca
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            // sempre all'inizio, carica i componenti
            InitializeComponent();

            Fattura fattura1 = new Fattura();
            fattura1.Committente = "Michelangelo";
            fattura1.Professionista = "Andrea";
            fattura1.Importo = (decimal)1000.05;

            txtCommittente.Text = fattura1.Committente;
            txtProfessionista.Text = fattura1.Professionista;
            txtImporto.Text = fattura1.Importo.ToString();

            
        }

        private void btnMucca_Click(object sender, EventArgs e)
        {
            imgMucca.Visible = !imgMucca.Visible;
            btnMucca.Text = 
                imgMucca.Visible == true 
                ? "nascondi mucca" 
                : "mostra mucca";

            /*
            if (imgMucca.Visible == true)
            {
                // imposto l'img della mucca non visibile
                imgMucca.Visible = false;
                btnMucca.Text = "appari muccaaa";
            }
            else
            {
                // imposto l'img della mucca visibile
                imgMucca.Visible = true;
                btnMucca.Text = "scompari muccaaa";
            }
            */
        }


    }
}
