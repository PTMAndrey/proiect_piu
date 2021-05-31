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
using System.Globalization;

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
        public const int LIMITA_MAXIMA_TEXT = 15;
        public const int LIMITA_MINIMA_TEXT = 3;
       
        
        
        private void Client_form_Load(object sender, EventArgs e)
        {
            rdbINTERIOR.Checked = false;
            rdbSEPAREU.Checked = false;
            rdbTERASA.Checked = false;
            rdbANULEAZA.Checked = false;

            grLocatie.Visible = false;
            grMese.Visible = false;
            grRezervareClient.Visible = false;
            grAfiseazaInfo.Visible = false;
            grIntroducetiCodulMesei.Visible = false;

            lblOPTMASA.Visible = false;

            grOPTIUNI.Visible = true;
            lblGetPret.Text = "";
            lblPretTotal.Text = "";
            btnCodGata.Visible = false;

            lblGetDenumire.ForeColor = Color.Transparent;
            lblGetTip.ForeColor = Color.Transparent;
            lblPretTotal.ForeColor = Color.Transparent;
            lblGetPret.ForeColor = Color.Transparent;

            grModificareMeniu.Visible = false;
            reset_erori();
        }


        // #########  Butoane de selectie in prim-plan. --- Rezerva masa --- Detin masa

        private void btnOptRezervare_Click(object sender, EventArgs e) // Buton de rezervara masa
        {
            // Mut cele doua groupbox-uri mai jos fiindca la actionarea click pe butonul Detin masa cele doua 
            // butoane sunt mutate mai sus
            reset_erori();
            grIntroducetiCodulMesei.Location = new Point(645, 542);
            grAfiseazaInfo.Location = new Point(1147, 204);

            grOPTIUNI.Visible = false;

            grIntroducetiCodulMesei.Visible = false;
            grAfiseazaInfo.Visible = false;

            grLocatie.Visible = true;

            lblOPTMASA.Visible = false;

            rdbANULEAZA.Visible = false;

            lblPretTotal.Text = "";

        }

        private void btnOptDetinMasa_Click(object sender, EventArgs e) // buton "Detin masa" -- cer introducerea codului si 
        {
            reset_erori();
            grIntroducetiCodulMesei.Location = new Point(384, 204);// (433, 231);
            grAfiseazaInfo.Location = new Point(899, 204);

            txtCodUnic.Text = "";
            grAfiseazaInfo.Visible = false;
            lblOPTMASA.Visible = false;

            grIntroducetiCodulMesei.Visible = true;
        }


        int index_rezervare = -1;
        private void Locatie_CheckedChanged(object sender, EventArgs e)
        {

            /* Stiu ca tabindex-ul butonului btnMasa1 este 2, btnMasa2 = 3, ..4, ..5, astfel ca index_locatie_in_lista va fi initializat cu -1, pentru a avea
             * In fisier eu am 4 mese pentru fiecare tip de locatie.
             * Daca este selectata locatia interior folosesc primele 4 campuri din lista
             * Daca este selectata locatia separeu folosesc de la pozitia 4 la 7 [ index_locatie_in_lista = 3 ] 3, pt ca apelez afisare_mese ( index + 1 )
             * Daca este selectata locatia terasa folosesc de la 8 la 11 [ index_locatie_in_lista = 7 ]
             * index_locatie_in_lista, dupa ce se va apasa pe o masa, va fi adunat cu indexul mesei respective ( 1 / 2 / 3 / 4 ),
             *      iar pt a accesa pozitia corecta a fost necesar ca anterior aceasta variabila sa aiba o valoare mai mica cu o unitate
             */

            //grRezervareClient.Visible = false;

            grIntroducetiCodulMesei.Visible = false;
            grAfiseazaInfo.Visible = false;

            if (rdbINTERIOR.Checked)
            {
                rdbSEPAREU.Checked = false;
                rdbTERASA.Checked = false;
                index_rezervare = -1;

                Afisare_Mese(index_rezervare + 1);

                reset_controale_client();
                grMese.Visible = true;
            }
            if (rdbSEPAREU.Checked)
            {
                index_rezervare = 3;

                rdbINTERIOR.Checked = false;
                rdbTERASA.Checked = false;

                Afisare_Mese(index_rezervare + 1);

                reset_controale_client();
                grMese.Visible = true;
            }
            if (rdbTERASA.Checked)
            {
                index_rezervare = 7;

                rdbSEPAREU.Checked = false;
                rdbINTERIOR.Checked = false;

                Afisare_Mese(index_rezervare + 1);

                reset_controale_client();
                grMese.Visible = true;
            }

            if (rdbANULEAZA.Checked)
            {
                reset_controale_client();
                reset_erori();
                rdbINTERIOR.Checked = false;
                rdbSEPAREU.Checked = false;
                rdbTERASA.Checked = false;
                rdbANULEAZA.Checked = false;

                grLocatie.Visible = false;
                grMese.Visible = false;
                grRezervareClient.Visible = false;
                grAfiseazaInfo.Visible = false;
                grIntroducetiCodulMesei.Visible = false;

                lblOPTMASA.Visible = false;

                grOPTIUNI.Visible = true;
            }
            
        }

        public void Afisare_Mese(int index)
        {
            rdbANULEAZA.Visible = true;
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

        static int index_rezervare_dupa_selectie_masa = 0;
        private void btnMasa_Selectat_Click(object sender, EventArgs e)
        {
            reset_controale_client();
            Button btnMasa_Click = sender as Button;
            if (btnMasa_Click == null)
                return;

            index_rezervare_dupa_selectie_masa = index_rezervare + btnMasa_Click.TabIndex + 1;

            grIntroducetiCodulMesei.Visible = false;
            grAfiseazaInfo.Visible = false;

            grRezervareClient.Text = "Rezervare la masa " + btnMasa_Click.TabIndex.ToString();

            grRezervareClient.Visible = true;
        }

        private void btnREZERVA_Click(object sender, EventArgs e) // BUTON DE REZERVARE ---- ADAUGARE CLIENT IN FISIER
        {

            if (! Validari.Validare_Date_Rezervare(lblNUME.Text, lblPRENUME.Text, lblCNP.Text) )
            {
                lblNUME.ForeColor = Color.Red;
                lblPRENUME.ForeColor = Color.Red;
                lblCNP.ForeColor = Color.Red;
                MessageBox.Show("Completarea campurilor este obligatorie!");
                return;
            }

            if (validare == false)
            {
                MessageBox.Show("Date introduse gresit! Verificati din nou informatiile din campuri");
                return;
            }


            grIntroducetiCodulMesei.Visible = false;
            grAfiseazaInfo.Visible = false;
            grRezervareClient.Visible = false;

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

            int cod_unic = 0;
            for (int i = 0; i < l_mese.Count; i++)
                if (l_mese[i].id == index_rezervare_dupa_selectie_masa)
                {
                    stocare_info_masa.UpdateMasa(l_mese[i].id, false);
                    cod_unic = l_mese[i].cod_unic;
                    break;
                }
            stocare_info_masa.GetInfo();
            
            Afisare_Mese(index_rezervare+1);

            reset_controale_client();

            DialogResult raspuns;

            raspuns = MessageBox.Show($"Codul mesei este: [ {cod_unic} ]", "COD UNIC", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (raspuns == System.Windows.Forms.DialogResult.Cancel)
            {
                MessageBox.Show($"Este necesara cunoasterea codului unic al mesei pentru a putea efectua comenzi in cazul in care ati rezervat mai multe mese.\n\nCodul este: [ {cod_unic} ]", "ATENTIE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                grIntroducetiCodulMesei.Visible = true;

            rdbANULEAZA.Checked = false; // just in case
            rdbANULEAZA.Visible = false; // nu permit anularea actiunii daca s-a efectuat actiunea de rezervare


        }
        bool validare_cod = true;
        private void txtCodUnic_TextChanged(object sender, EventArgs e) // textbox introducere cod masa
        {
            validare_cod = true;

            btnCodGata.Visible = false;
            if (txtCodUnic.Text.Length > 5)
            {
                lblEroareCOD.Text = "SUNT NECESARE EXACT 5 CIFRE";
                lblEroareCOD.ForeColor = Color.Green;
                validare_cod = false;
            }
            else if (txtCodUnic.Text.Length <= 5)
            {
                string txtcodunic = txtCodUnic.Text;
                for (int i = 0; i < txtcodunic.Length; i++)
                    if (char.IsLetter(txtcodunic[i]))
                    {
                        lblEroareCOD.Text = "TREBUIE SA CONTINA DOAR CIFRE";
                        lblEroareCOD.ForeColor = Color.Green;
                        validare_cod = false;
                    }

            }
            if (validare_cod == true)
            {
                lblEroareCOD.Text = "";
                lblEroareCOD.ForeColor = Color.Transparent;
                btnCodGata.Visible = true;
            }
            

        }


        static int id_masa_pentru_actualizare_pret_total_comanda = 0;
        private void btnCodGata_Click(object sender, EventArgs e) // buton Gata ce apare dupa ce este introdus codul unic
        {
            IStocareMasa stocare_info_masa = new Administrare_masa();
            List<Masa> l_mese = stocare_info_masa.GetInfo();
            bool test = false;
            for (int i = 0; i < l_mese.Count; i++)
            {
                if (l_mese[i].cod_unic == Convert.ToInt32(txtCodUnic.Text))
                {
                    id_masa_pentru_actualizare_pret_total_comanda = l_mese[i].id;
                    if (l_mese[i].ocupat == false)
                    {
                        MessageBox.Show("Masa cu acest cod nu a fost rezervata de dumneavoastra!");
                        grAfiseazaInfo.Visible = false;
                        lblOPTMASA.Visible = false;
                    }
                    else
                    {
                        lblOPTMASA.Visible = true;
                        if(l_mese[i].locatie == "Interior")
                            lblOPTMASA.Text = $"MASA {id_masa_pentru_actualizare_pret_total_comanda} - {l_mese[i].locatie}";

                        if (l_mese[i].locatie == "Separeu")
                            lblOPTMASA.Text = $"MASA {id_masa_pentru_actualizare_pret_total_comanda - 4} - {l_mese[i].locatie}";

                        if (l_mese[i].locatie == "Terasa")
                            lblOPTMASA.Text = $"MASA {id_masa_pentru_actualizare_pret_total_comanda - 8} - {l_mese[i].locatie}";

                        lblPretTotal.Text = (Validari.Validare_ConvertToFloat_Pret_Meniu(l_mese[i].total_plata.ToString())).ToString(); // primeste 0 din fisier sau valoarea adunata a preturilor
                         
                        // 4 comenzi necesare pentru revenirea de la admin la client
                        grAfiseazaInfo.Visible = true;
                        grAfiseazaInfo.Text = "Meniu";
                        lblTotalPlata_Bon.Visible = true;
                        btnCOMANDA.Visible = true;

                        lblPretTotal.ForeColor = Color.Transparent;
                        lblTotalPlata_Bon.Text = $"Total plata\n{lblPretTotal.Text} RON";

                       

                        lblGetPret.Text = "";
                        lstAfisareInfo.Items.Clear();
                    }

                    test = true; 
                    break;
                }

            }
            if (test == false)
                MessageBox.Show("Codul mesei nu corespunde cu una dintre mesele rezervate!");
        }

        private void txtNUME_TextChanged(object sender, EventArgs e) // eveniment in textbox Nume. Afisare erori
        {
            validare = true;
            if (txtNUME.Text.Length > LIMITA_MAXIMA_TEXT)
            {
                lblEroareNume.Text = "MAXIM " + LIMITA_MAXIMA_TEXT + " CARACTERE";
                lblEroareNume.ForeColor = Color.Green;
                lblEroareNume.Visible = true;
                validare = false;
            }
            else
            if (txtNUME.Text.Length < LIMITA_MINIMA_TEXT)
            {
                lblEroareNume.Text = "MINIM " + LIMITA_MINIMA_TEXT + " CARACTERE";
                lblEroareNume.ForeColor = Color.Green; 
                lblEroareNume.Visible = true;
                validare = false;
            }

            if(validare == true)
            {
                lblEroareNume.Text = "";
                lblEroareNume.ForeColor = Color.Transparent;
                lblEroareNume.Visible = false;

            }
        }

        private void txtPRENUME_TextChanged(object sender, EventArgs e)
        {
            validare = true;
            if (txtPRENUME.Text.Length > LIMITA_MAXIMA_TEXT)
            {
                lblEroarePrenume.Text = "MAXIM " + LIMITA_MAXIMA_TEXT + " CARACTERE";
                lblEroarePrenume.ForeColor = Color.Green; 
                lblEroarePrenume.Visible = true;
                validare = false;
            }
            else
            if(txtPRENUME.Text.Length < LIMITA_MINIMA_TEXT)
            {
                lblEroarePrenume.Text = "MINIM " + LIMITA_MINIMA_TEXT + " CARACTERE";
                lblEroarePrenume.ForeColor = Color.Green;
                lblEroarePrenume.Visible = true;
                validare = false;
            }

            if( validare == true )
            {
                lblEroarePrenume.Text = "";
                lblEroarePrenume.ForeColor = Color.Transparent;
                lblEroarePrenume.Visible = false;

            }
        } // eveniment in textbox Prenume. Afisare erori

        private void txtCNP_TextChanged(object sender, EventArgs e)
        {
            validare = true;
            if (txtCNP.Text.Length != CIFRE_CNP)
            {
                lblEroareCNP.Text = "DOAR " + CIFRE_CNP + " CIFRE";
                lblEroareCNP.ForeColor = Color.Green;
                lblEroareCNP.Visible = true;
                validare = false;
            }
            else
            {
                string cnp = txtCNP.Text;
                for (int i = 0; i < cnp.Length; i++)
                    if (!char.IsDigit(cnp[i]))
                    {
                        lblEroareCNP.Text = "TREBUIE SA CONTINA DOAR CIFRE";
                        lblEroareCNP.ForeColor = Color.Green;
                        lblEroareCNP.Visible = true;
                        validare = false;

                    }

            }
            if( validare == true)
            {
                lblEroareCNP.Visible = false;
                lblEroareCNP.Text = "";
                lblEroareCNP.ForeColor = Color.Transparent;
            }
        }  // eveniment in textbox CNP. Afisare erori




        private void btnCOMANDA_Click(object sender, EventArgs e) // buton comanda din meniu. Efectuare calcul pret total -> memorare in fisier
        {
            if (lblGetPret.Text != "")
            {
                float pret_total;
                if (lblPretTotal.Text == "")
                    pret_total = 0;
                else
                    pret_total = Validari.Validare_ConvertToFloat_Pret_Meniu(lblPretTotal.Text);

                float pret_item_meniu = Validari.Validare_ConvertToFloat_Pret_Meniu(lblGetPret.Text);
                lblPretTotal.Text = (pret_total + pret_item_meniu).ToString();
                lblPretTotal.ForeColor = Color.Transparent;
                lblTotalPlata_Bon.Text = $"Total plată:\n{lblPretTotal.Text} RON";

                IStocareMasa stocare_info_masa = new Administrare_masa();
                List<Masa> l_mese = stocare_info_masa.GetInfo();

                MessageBox.Show(lblPretTotal.Text);
                stocare_info_masa.UpdateMasa(l_mese[id_masa_pentru_actualizare_pret_total_comanda-1].id, false, lblPretTotal.Text);
                        

                stocare_info_masa.GetInfo();

                lstAfisareInfo.ClearSelected();

            }
        }


        private void btnAfiseazaMeniu_Click(object sender, EventArgs e) // buton Afiseaza --- afiseaza meniul
        {
            lblGetPret.Text = "";
            lstAfisareInfo.Items.Clear();

            var antetTabel = String.Format("{0,-14}\t{1,0}\t{2,15}\t{3,5}\n", "TIP", "ID", "NUME", "PRET");
            lstAfisareInfo.Items.Add(antetTabel);
            lstAfisareInfo.Items.Add("___________________________________________________________");

            IStocareMeniu stocare_info_meniu = new Administrare_meniu();

            List<Meniu> list_meniu = stocare_info_meniu.GetInfo();
            foreach (Meniu meniu in list_meniu)
            {
                var linieTabel = String.Format("{0,-14}\t{1,0}\t{2,15}\t{3,5}\n", meniu.tip_aliment, meniu.id, meniu.denumire, meniu.pret);
                lstAfisareInfo.Items.Add(linieTabel);

            }
        }

        private void SelectedIndexChanged(object sender, EventArgs e)
        {
            IStocareMeniu stocare_info_meniu = new Administrare_meniu();
            Meniu camp_selectat = stocare_info_meniu.GetInfo(Convert.ToInt32(lstAfisareInfo.SelectedIndex - 1));
            if (camp_selectat != null)
            {
                lblGetTip.Text = txtModificaTip.Text = camp_selectat.tip_aliment.ToString();
                lblGetDenumire.Text = txtModificaDenumire.Text = camp_selectat.denumire;
                lblGetPret.Text = txtModificaPret.Text = camp_selectat.pret.ToString();

            }
            else { lblGetPret.Text = ""; }

        } // eveniment pentru itemul selectat din meniu

        private void btnMODIFICA_Click(object sender, EventArgs e) // buton de modificare meniu --- admin
        {
            if (! Validari.Admin_Validare_Date_Meniu(lblTIP.Text, lblDENUMIRE.Text, lblPRET.Text) )
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
            Meniu camp_modificat = stocare_info_meniu.GetInfo(Convert.ToInt32(lstAfisareInfo.SelectedIndex - 1));

            camp_modificat.tip_aliment = txtModificaTip.Text;
            camp_modificat.denumire = txtModificaDenumire.Text;
            camp_modificat.pret = float.Parse(txtModificaPret.Text, System.Globalization.CultureInfo.InvariantCulture);

            stocare_info_meniu.UpdateMeniu(camp_modificat);
            admin_reset_controale_meniu();
            btnAfiseazaMeniu_Click(sender, e);
        } // Buton de modificare pentru rolul de administrator








        public void reset_controale_client() // sterge textul si erorile afisate la textboxuri
        {
            lblNUME.ForeColor = Color.Black; lblPRENUME.ForeColor = Color.Black; lblCNP.ForeColor = Color.Black;
            txtNUME.Text = ""; txtPRENUME.Text = ""; txtCNP.Text = "";

            lblEroareNume.Text = "";
            lblEroareNume.ForeColor = Color.Transparent;

            lblEroarePrenume.Text = "";
            lblEroarePrenume.ForeColor = Color.Transparent;

            lblEroareCNP.Text = "";
            lblEroareCNP.ForeColor = Color.Transparent;
            validare = true;
        }

        public void admin_reset_controale_meniu() // sterge textul din textboxurile din modificare meniu - admin mode
        {
            txtModificaTip.Text = ""; txtModificaDenumire.Text = ""; txtModificaPret.Text = "";

        }

        public void reset_erori() // resetarea generala a erorilor
        {
            lblEroareNume.Text = ""; lblEroarePrenume.Text = ""; lblEroareCNP.Text = ""; lblEroareCOD.Text = "";
            lblEroareNume.ForeColor = Color.Transparent; lblEroarePrenume.ForeColor = Color.Transparent; lblEroareCNP.ForeColor = Color.Transparent; lblEroareCOD.ForeColor = Color.Transparent;
        }

        private void Client_form_Closing(object sender, FormClosingEventArgs e)
        {

            DialogResult raspuns = MessageBox.Show("Doriti sa parasiti restaurantul?", "PARASIRE RESTAURANT", MessageBoxButtons.YesNo);

            if (raspuns == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            if (raspuns == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnADMIN_Click(object sender, EventArgs e)
        {

        }
    }
}
