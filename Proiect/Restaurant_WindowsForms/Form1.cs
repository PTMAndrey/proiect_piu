using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibrarieClase;
using NivelAccesData;

namespace Restaurant_WindowsForms
{
    public partial class Client_form : Form
    {
        public Client_form()
        {
            InitializeComponent();

        }

        bool validare = true;
        public static int last_id = 0;
        public const int CIFRE_CNP = 13;
        public const int LIMITA_TEXT = 15;

        private void Client_form_Load(object sender, EventArgs e)
        {
            rdbINTERIOR.Checked = false;
            rdbSEPAREU.Checked = false;
            rdbTERASA.Checked = false;
            grMese.Visible = false;

            lblNUME.Visible = false;
            txtNUME.Visible = false;
            lblPRENUME.Visible = false;
            txtPRENUME.Visible = false;
            lblCNP.Visible = false;
            txtCNP.Visible = false;
            btnREZERVA.Visible = false;

            lblInfoRezervare.Visible = false;

            /*lbllocuri1.Visible = false;
            lbllocuri2.Visible = false;
            lbllocuri3.Visible = false;
            lbllocuri4.Visible = false;*/

        }


        int index_rezervare;
        private void Locatie_Click(object sender, EventArgs e)
        {
            /* Stiu ca tabindex-ul butonului btnMasa1 este 2, btnMasa2 = 3, ..4, ..5, astfel ca index_locatie_in_lista va fi initializat cu -1, pentru a avea
             * In fisier eu am 4 mese pentru fiecare tip de locatie.
             * Daca este selectata locatia interior folosesc primele 4 campuri din lista
             * Daca este selectata locatia separeu folosesc de la pozitia 4 la 7 [ index_locatie_in_lista = 4 ]
             * Daca este selectata locatia terasa folosesc de la 8 la 11 [ index_locatie_in_lista = 8 ]
             */
            lblNUME.Visible = false;
            txtNUME.Visible = false;
            lblPRENUME.Visible = false;
            txtPRENUME.Visible = false;
            lblCNP.Visible = false;
            txtCNP.Visible = false;
            btnREZERVA.Visible = false;
            lblInfoRezervare.Visible = false;


            if (rdbINTERIOR.Checked)
            {
                rdbSEPAREU.Checked = false;
                rdbTERASA.Checked = false;
                index_rezervare = -1;
            }
            else
            if (rdbSEPAREU.Checked)
            {
                index_rezervare = 3;

                rdbINTERIOR.Checked = false;
                rdbTERASA.Checked = false;
            }
            else
            if (rdbTERASA.Checked)
            {
                index_rezervare = 7;

                rdbSEPAREU.Checked = false;
                rdbINTERIOR.Checked = false;
            }

            Afisare_Mese(index_rezervare+1);


            //index_rezervare = index_rezervare - 4;
            reset_controale_client();
            grMese.Visible = true;

        }

        public void Afisare_Mese(int index)
        {
            IStocareMasa stocare_info_masa = new Administrare_masa();
            List<Masa> l_mese = stocare_info_masa.GetInfo();

            foreach (Button btn in grMese.Controls.Cast<Control>().Reverse())
            {
                if (l_mese[index].ocupat == true)
                {
                    btn.BackColor = Color.Gray;
                    btn.Enabled = false;
                    btn.Text = "Masa " + btn.TabIndex + "\nOCUPAT";
                }
                else
                {
                    btn.BackColor = Color.Lime;
                    btn.Enabled = true;
                    btn.Cursor = Cursors.Hand;
                    btn.Text = "Masa " + btn.TabIndex + "\n" + l_mese[index].locuri.ToString() + " locuri";
                }

                index++;
            }
        }
        private void btnMasa_Selectat_Click(object sender, EventArgs e)
        {
            reset_controale_client();
            lblNUME.Visible = true;
            txtNUME.Visible = true;

            lblPRENUME.Visible = true;
            txtPRENUME.Visible = true;

            lblCNP.Visible = true;
            txtCNP.Visible = true;

            btnREZERVA.Visible = true;

            Button btnMasa_Click = sender as Button;
            if (btnMasa_Click == null)
                return;

            index_rezervare += btnMasa_Click.TabIndex+1;

            lblInfoRezervare.Text = "Rezervare la masa " + btnMasa_Click.TabIndex.ToString();

            lblInfoRezervare.Visible = true;
        }

        private void btnREZERVA_Click(object sender, EventArgs e) // BUTON DE ADAUGARE CLIENT IN FISIER
        {
            if (!Validare_Date_Introduse_Client())
            {
                lblNUME.ForeColor = Color.Red;
                lblPRENUME.ForeColor = Color.Red;
                lblCNP.ForeColor = Color.Red;
                MessageBox.Show("Completarea campurilor este obligatorie!");
                return;
            }

            if (validare == false)
            {
                MessageBox.Show("Date invalide");
                return;
            }

            IStocareClient stocare_info_client = new Administrare_client();
            List<Client> al_client;
            if (stocare_info_client != null)
            {
                al_client = stocare_info_client.GetInfo();
                last_id = al_client.Count + 1;
            }
            else
                last_id = 0;

            string cl = last_id.ToString() + ";" + txtNUME.Text + ";" + txtPRENUME.Text + ";" + txtCNP.Text + ";" + index_rezervare.ToString();

            Client client = new Client(cl);
            stocare_info_client.AddClient(client);

            IStocareMasa stocare_info_masa = new Administrare_masa();
            List<Masa> l_mese = stocare_info_masa.GetInfo();


            for (int i = 0; i < l_mese.Count; i++)
                if (l_mese[i].id == index_rezervare)
                {
                    stocare_info_masa.UpdateMasa(index_rezervare);
                    break;
                }
            stocare_info_masa.GetInfo();

            Afisare_Mese(index_rezervare-1);

            reset_controale_client();
        }

        private void txtNUME_TextChanged(object sender, EventArgs e)
        {
            if (txtNUME.Text.Length > LIMITA_TEXT)
            {
                lblEroareNume.Text = "MAXIM " + LIMITA_TEXT + " CARACTERE";
                lblEroareNume.ForeColor = Color.Green;
                validare = false;
            }
            else
            {
                lblEroareNume.Text = "*";
                lblEroareNume.ForeColor = Color.Transparent;
                validare = true;

            }
        }

        private void txtPRENUME_TextChanged(object sender, EventArgs e)
        {
            if (txtPRENUME.Text.Length > LIMITA_TEXT)
            {
                lblEroarePrenume.Text = "MAXIM " + LIMITA_TEXT + " CARACTERE";
                lblEroarePrenume.ForeColor = Color.Green;
                validare = false;
            }
            else
            {
                lblEroarePrenume.Text = "*";
                lblEroarePrenume.ForeColor = Color.Transparent;
                validare = true;

            }
        }

        private void txtCNP_TextChanged(object sender, EventArgs e)
        {
            if (txtCNP.Text.Length > CIFRE_CNP)
            {
                lblEroareCNP.Text = "MAXIM " + CIFRE_CNP + " CARACTERE";
                lblEroareCNP.ForeColor = Color.Green;
                validare = false;
            }
            else
            {
                lblEroareCNP.Text = "*";
                lblEroareCNP.ForeColor = Color.Transparent;
                validare = true;
                for (int i = 0; i < txtCNP.Text.Length; i++)
                    if (!char.IsDigit(txtCNP.Text[i]))
                    {
                        lblEroareCNP.Text = "TREBUIE SA CONTINA DOAR CIFRE";
                        lblEroareCNP.ForeColor = Color.Green;
                        validare = false;

                    }

            }
        }























        private void btnCOMANDA_Click(object sender, EventArgs e)
        {

        }


        private void btnAfiseazaMeniu_Click(object sender, EventArgs e)
        {
            lstMeniu.Items.Clear();

            var antetTabel = String.Format("{0,-14}\t{1,0}\t{2,15}\t{3,5}\n", "TIP", "ID", "NUME", "PRET");
            lstMeniu.Items.Add(antetTabel);
            lstMeniu.Items.Add("___________________________________________________________");

            IStocareMeniu stocare_info_meniu = new Administrare_meniu();

            List<Meniu> list_meniu = stocare_info_meniu.GetInfo();
            foreach (Meniu meniu in list_meniu)
            {
                var linieTabel = String.Format("{0,-14}\t{1,0}\t{2,15}\t{3,5}\n", meniu.tip_aliment, meniu.id, meniu.denumire, meniu.pret);
                lstMeniu.Items.Add(linieTabel);

            }
        }

        private void SelectedIndexChanged(object sender, EventArgs e)
        {
            IStocareMeniu stocare_info_meniu = new Administrare_meniu();
            Meniu camp_selectat = stocare_info_meniu.GetInfo(Convert.ToInt32(lstMeniu.SelectedIndex - 1));
            if (camp_selectat != null)
            {
                txtTip.Text = camp_selectat.tip_aliment.ToString();
                txtDenumire.Text = camp_selectat.denumire;
                txtPret.Text = camp_selectat.pret.ToString();
            } 

        }

        private void btnMODIFICA_Click(object sender, EventArgs e)
        {
            if (!Validare_Date_Introduse_Meniu())
            {
                lblTIP.ForeColor = Color.Red;
                lblDENUMIRE.ForeColor = Color.Red;
                lblPRET.ForeColor = Color.Red;
                MessageBox.Show("Campuri obligatoriu de completat");
                return;
            }

            if (validare == false)
            {
                MessageBox.Show("Valori invalide");
                return;
            }

            IStocareMeniu stocare_info_meniu = new Administrare_meniu();
            Meniu camp_modificat = stocare_info_meniu.GetInfo(Convert.ToInt32(lstMeniu.SelectedIndex - 1));

            camp_modificat.tip_aliment = txtTip.Text;
            camp_modificat.denumire = txtDenumire.Text;
            camp_modificat.pret = float.Parse(txtPret.Text, System.Globalization.CultureInfo.InvariantCulture);

            stocare_info_meniu.UpdateMeniu(camp_modificat);
            reset_controale_meniu();
            btnAfiseazaMeniu_Click(sender, e);
        }







        public bool Validare_Date_Introduse_Client()
        {
            if (txtNUME.Text == string.Empty || txtPRENUME.Text == string.Empty || txtCNP.Text == string.Empty)
                return false;
            return true;
        }
        public bool Validare_Date_Introduse_Meniu()
        {
            if (txtTip.Text == string.Empty || txtDenumire.Text == string.Empty || txtPret.Text == string.Empty)
                return false;
            return true;
        }

        public void reset_controale_client()
        {
            lblNUME.ForeColor = lblPRENUME.ForeColor = lblCNP.ForeColor = Color.Black;
            txtNUME.Text = txtPRENUME.Text = txtCNP.Text = string.Empty;

            lblInfoRezervare.Visible = false;

            lblEroareNume.Text = "*";
            lblEroareNume.ForeColor = Color.Transparent;

            lblEroarePrenume.Text = "*";
            lblEroarePrenume.ForeColor = Color.Transparent;

            lblEroareCNP.Text = "*";
            lblEroareCNP.ForeColor = Color.Transparent;
            validare = true;
        }

        public void reset_controale_meniu()
        {
            txtTip.Text = txtDenumire.Text = txtPret.Text = string.Empty;

        }
        
    }
}
