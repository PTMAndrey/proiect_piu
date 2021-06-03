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
    public partial class Restaurant_Form : Form
    {
        public Restaurant_Form()
        {
            InitializeComponent();

        }

        bool validare = true;
        public static int last_id = 0;
        public const int CIFRE_CNP = 13;
        public const int LIMITA_MAXIMA_TEXT = 30;
        public const int LIMITA_MINIMA_TEXT = 3;
        public bool btn_pentru_mese = true;



        private void Restaurant_form_Load(object sender, EventArgs e)
        {
            revenire_form_client();

            reset_erori();

            mentenanta();
        }

        #region CLIENT

        public void revenire_form_client()
        {
            btnEliberareMasa.Visible = false;
            lstAfisareInfo.Enabled = true;

            rdbINTERIOR.Checked = false;
            rdbSEPAREU.Checked = false;
            rdbTERASA.Checked = false;
            rdbANULEAZA.Checked = false;

            grLocatie.Visible = false;
            grMese.Visible = false;
            grRezervareClient.Visible = false;
            grAfiseazaInfo.Visible = false;

            grIntroducetiCodulMesei.Visible = false;
            btnCodGata.Visible = false;

            lblOPTMASA.Visible = false; btnCOMANDA.Visible = true;
            lblTotalPlata_Bon.Visible = true;

            grOPTIUNI.Visible = true;
            btnOptDetinMasa.BackColor = Color.LightGray;
            btnOptRezervare.BackColor = Color.LightGray;
            btnOptDetinMasa.ForeColor = Color.Black;


            lblGetPret.Text = "";
            lblPretTotal.Text = "";

            lblTextCamp1.Text = "Tip";
            lblTextCamp2.Text = "Denumire";
            lblTextCamp3.Text = "Pret";
            lblTextCamp2.Visible = true;

            btnAdminModifica.Text = "Adauga";

            grAfiseazaInfo.Text = "Meniu";
            btnCOMANDA.Visible = true;
            lblTotalPlata_Bon.Visible = true;



            lblGetDenumire.ForeColor = Color.Transparent;
            lblGetTip.ForeColor = Color.Transparent;
            lblPretTotal.ForeColor = Color.Transparent;
            lblGetPret.ForeColor = Color.Transparent;


            lblEroareNume.Text = "";
            lblEroareNume.ForeColor = Color.Transparent;
            lblEroareNume.Visible = true;
            lblEroarePrenume.Text = "";
            lblEroarePrenume.ForeColor = Color.Transparent;
            lblEroarePrenume.Visible = true;
            lblEroareCNP.Text = "";
            lblEroareCNP.ForeColor = Color.Transparent;
            lblEroareCNP.Visible = true;

            lblEroareCOD.Text = "";
            lblEroareCOD.ForeColor = Color.Transparent;

            lblEroareCamp1.Text = "";
            lblEroareCamp1.ForeColor = Color.Transparent;
            lblEroareCamp2.Text = "";
            lblEroareCamp2.ForeColor = Color.Transparent;
            lblEroareCamp3.Text = "";
            lblEroareCamp3.ForeColor = Color.Transparent;


            btnADMIN.Location = new Point(26, 25);
            btnADMIN.Visible = true;
            btnAdminIesire.Visible = false;

            grAdminModificare.Visible = false;
            grAdminOptiuni.Visible = false;
            btnAdminIesire.Visible = false;
            btnAdminInapoi.Visible = false;


            btn_pentru_mese = false;

            //mentenanta();
        }

        public void mentenanta()
        {
            IStocareMasa stocare_info_masa = new Administrare_masa();
            List<Masa> l_mese = stocare_info_masa.GetInfo();


            if (Masa.last_id != 0)
            {
                IStocareMeniu stocare_info_meniu = new Administrare_meniu();
                List<Meniu> l_meniu = stocare_info_meniu.GetInfo();
                if (l_meniu.Count != 0)
                {
                    grOPTIUNI.Visible = true;
                    btnADMIN.Location = new Point(26, 25);
                }
                else
                {
                    grOPTIUNI.Visible = false;
                    btnADMIN.Location = new Point(639, 435);
                    MessageBox.Show("Momentan restaurantul este in mentenanta! Ne cerem scuze pentru discomfortul creat!\n\n* Daca sunteti administratorul va rugam sa actualizati meniul in restaurant!");
                }
            }
            else
            {
                grOPTIUNI.Visible = false;
                btnADMIN.Location = new Point(639, 435);
                MessageBox.Show("Momentan restaurantul este in mentenanta! Ne cerem scuze pentru discomfortul creat!\n\n* Daca sunteti administratorul va rugam sa actualizati mesele in restaurant!");
            }
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


            btnOptRezervare.BackColor = Color.LightGray;
            btnOptDetinMasa.BackColor = Color.LightGray;
            btnOptDetinMasa.ForeColor = Color.Black;

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

            btnOptDetinMasa.BackColor = Color.LightGreen;
            btnOptDetinMasa.ForeColor = Color.White;
            btnOptRezervare.BackColor = Color.LightGray;

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

            //IStocareMasa stocare_info_masa = new Administrare_masa();
            //List<Masa> l_mese = stocare_info_masa.GetInfo();

            //int nr = 0, x = 35;
            if (rdbINTERIOR.Checked)
            {/*
                int ok = 0;
                foreach (Masa m in l_mese)
                {
                    if (m.locatie == "Interior")
                    {
                        nr++;
                        ok++;
                        Button btnMasa = new Button();
                        btnMasa.Name = "btnMasa" + ok;
                        btnMasa.Text = "Masa " + ok;
                        btnMasa.TabIndex = nr;
                        btnMasa.Location = new Point(x, 70);
                        btnMasa.Height = 101;
                        btnMasa.Width = 94;
                        x += 181;
                    }
                }*/
                rdbSEPAREU.Checked = false;
                rdbTERASA.Checked = false;
                index_rezervare = -1;

                Afisare_Mese(index_rezervare + 1);

                reset_controale_client();
                grMese.Visible = true;

            }
            if (rdbSEPAREU.Checked)
            {
                /*
                foreach (Masa m in l_mese)
                {
                    if (m.locatie == "Separeu")
                    {
                        nr++;
                        Button btnMasa = new Button();
                        btnMasa.Name = "btnMasa" + nr;
                        btnMasa.Text = "Masa " + nr;
                        btnMasa.TabIndex = nr;
                        btnMasa.Location = new Point(x, 70);
                        btnMasa.Height = 101;
                        btnMasa.Width = 94;
                        x += 181;
                    }
                }*/
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
                btnOptRezervare.BackColor = Color.LightGray;
                btnOptDetinMasa.BackColor = Color.LightGray;
                btnOptDetinMasa.ForeColor = Color.Black;

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

            if (l_mese != null)
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

            if (!Validari.Validare_Date_Rezervare(lblNUME.Text, lblPRENUME.Text, lblCNP.Text))
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

            string cl = last_id.ToString() + ";" + txtNUME.Text + ";" + txtPRENUME.Text + ";" + txtCNP.Text + ";" + index_rezervare_dupa_selectie_masa.ToString();
            MessageBox.Show(cl);
            Client client = new Client(cl);
            stocare_info_client.AddClient(client);

            IStocareMasa stocare_info_masa = new Administrare_masa();
            List<Masa> l_mese = stocare_info_masa.GetInfo();

            int cod_unic = 0;
            for (int i = 0; i < l_mese.Count; i++)
                if (l_mese[i].id == index_rezervare_dupa_selectie_masa)
                {
                    stocare_info_masa.UpdateMasa(l_mese[i].id, true);
                    cod_unic = l_mese[i].cod_unic;
                    break;
                }
            stocare_info_masa.GetInfo();

            Afisare_Mese(index_rezervare + 1);

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
            btnEliberareMasa.Visible = true;
            
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
                    if (!char.IsDigit(txtcodunic[i]) || txtcodunic[i] == '-' )
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
                        txtCodUnic.Text = "";
                        btnCodGata.Visible = false;
                        grAfiseazaInfo.Visible = false;
                        lblOPTMASA.Visible = false;
                    }
                    else
                    {
                        lblOPTMASA.Visible = true;
                        if (l_mese[i].locatie == "Interior")
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
            {
                txtCodUnic.Text = "";
                btnCodGata.Visible = false;
                MessageBox.Show("Codul mesei nu corespunde cu una dintre mesele rezervate!");
                grAfiseazaInfo.Visible = false;
                lblOPTMASA.Visible = false;
            }
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

            if (validare == true)
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
            if (txtPRENUME.Text.Length < LIMITA_MINIMA_TEXT)
            {
                lblEroarePrenume.Text = "MINIM " + LIMITA_MINIMA_TEXT + " CARACTERE";
                lblEroarePrenume.ForeColor = Color.Green;
                lblEroarePrenume.Visible = true;
                validare = false;
            }

            if (validare == true)
            {
                lblEroarePrenume.Text = "";
                lblEroarePrenume.ForeColor = Color.Transparent;
                lblEroarePrenume.Visible = false;

            }
        } // eveniment in textbox Prenume. Afisare erori

        private void txtCNP_TextChanged(object sender, EventArgs e) // eveniment in textbox CNP. Afisare erori
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
                    if (!char.IsDigit(cnp[i]) )
                    {
                        lblEroareCNP.Text = "TREBUIE SA CONTINA DOAR CIFRE";
                        lblEroareCNP.ForeColor = Color.Green;
                        lblEroareCNP.Visible = true;
                        validare = false;

                    }

            }
            if (validare == true)
            {
                lblEroareCNP.Visible = false;
                lblEroareCNP.Text = "";
                lblEroareCNP.ForeColor = Color.Transparent;
            }
        }




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

                stocare_info_masa.UpdateMasa(l_mese[id_masa_pentru_actualizare_pret_total_comanda - 1].id, true, 0, "", lblPretTotal.Text);


                stocare_info_masa.GetInfo();

                lstAfisareInfo.ClearSelected();

            }
        }


        private void btnEliberareMasa_Click(object sender, EventArgs e)
        {
            DialogResult intrebare = MessageBox.Show("Sunteti sigur ca doriti sa eliberati masa " + id_masa_pentru_actualizare_pret_total_comanda.ToString(),"Parasire restaurant", MessageBoxButtons.OKCancel);
            if (intrebare == DialogResult.OK)
            {
                MessageBox.Show("Masa " + id_masa_pentru_actualizare_pret_total_comanda.ToString() + " a fost eliberata! Va asteptam cu drag la restaurantul nostru");
                IStocareMasa stocare_info_masa = new Administrare_masa();
                stocare_info_masa.UpdateMasa(id_masa_pentru_actualizare_pret_total_comanda, false, 0, "", "", true);
                revenire_form_client();
            }
            
        }

        private void btnAfiseazaInfo_Click(object sender, EventArgs e) // buton Afiseaza --- afiseaza meniul || afiseaza mesele
        {
            if (btn_pentru_mese == false) // afisarea meniu client + admin
            {
                btnEliberareMasa.Visible = true;
                lstAfisareInfo.Enabled = true;
                lblGetPret.Text = "";
                lstAfisareInfo.Items.Clear();

                var antetTabel = String.Format("{0,-14}\t{1,0}\t{2,-30}\t{3,5}\n", "TIP", "ID", "NUME", "PRET");
                lstAfisareInfo.Items.Add(antetTabel);
                lstAfisareInfo.Items.Add("___________________________________________________________________");

                IStocareMeniu stocare_info_meniu = new Administrare_meniu();

                List<Meniu> list_meniu = stocare_info_meniu.GetInfo();

                foreach (Meniu meniu in list_meniu)
                {
                    string linieTabel = "";
                    //if( meniu.denumire.Length)
                    linieTabel = String.Format("{0,-14}\t{1,0}\t{2,-30}\t{3,5}\n", meniu.tip_aliment, meniu.id, meniu.denumire, meniu.pret);
                    //linieTabel= String.Format("{0,-14}\t{1,0}\t{2,15}\t\t{3,5}\n", meniu.tip_aliment, meniu.id, meniu.denumire, meniu.pret);
                    if (meniu.tip_aliment == Tip_aliment.Mancare.ToString())
                        lstAfisareInfo.Items.Add(linieTabel);
                }
                foreach (Meniu meniu in list_meniu)
                {
                    string linieTabel = String.Format("{0,-14}\t{1,0}\t{2,-30}\t{3,5}\n", meniu.tip_aliment, meniu.id, meniu.denumire, meniu.pret);
                    if (meniu.tip_aliment == Tip_aliment.Bautura.ToString())
                        lstAfisareInfo.Items.Add(linieTabel);
                }
                foreach (Meniu meniu in list_meniu)
                {
                    string linieTabel = String.Format("{0,-14}\t{1,0}\t{2,-30}\t{3,5}\n", meniu.tip_aliment, meniu.id, meniu.denumire, meniu.pret);
                    if (meniu.tip_aliment == Tip_aliment.Desert.ToString())
                        lstAfisareInfo.Items.Add(linieTabel);
                }
            }
            // afisarea meselor in cadrul ADMIN
            else
            {
                btnEliberareMasa.Visible = false;
                lstAfisareInfo.Enabled = true;
                lblGetPret.Text = "";
                lstAfisareInfo.Items.Clear();

                var antetTabel = String.Format("{0,-10}\t{1,-5}\t{2,-5}\t{3,-5}\t{4,-5}\t{5,-5}\n", "ID", "LOCATIE", "LOCURI", "COD", "TOTAL", "STATUS");
                lstAfisareInfo.Items.Add(antetTabel);
                lstAfisareInfo.Items.Add("________________________________________________________________");

                IStocareMasa stocare_info_masa = new Administrare_masa();

                List<Masa> list_masa = stocare_info_masa.GetInfo();

                foreach (Masa masa in list_masa)
                {
                    string linieTabel = "";
                    if (masa.ocupat == true)
                        linieTabel = String.Format("{0,-10}\t{1,-5}\t{2,-5}\t{3,-5}\t{4,-5}\t{5,-5}\n", masa.id, masa.locatie, masa.locuri, masa.cod_unic, masa.total_plata, "Rezervat");
                    else
                        linieTabel = String.Format("{0,-10}\t{1,-5}\t{2,-5}\t{3,-5}\t{4,-5}\t{5,-5}\n", masa.id, masa.locatie, masa.locuri, masa.cod_unic, masa.total_plata, "Liber");
                    //if (masa.tip_aliment == Tip_aliment.Mancare.ToString())

                    lstAfisareInfo.Items.Add(linieTabel);
                }
            }
        }

        private void SelectedIndexChanged(object sender, EventArgs e)// eveniment pentru itemul selectat din meeniu
        {
            IStocareMeniu stocare_info_meniu = new Administrare_meniu();
            Meniu camp_selectat = stocare_info_meniu.GetInfo(Convert.ToInt32(lstAfisareInfo.SelectedIndex - 1));
            if (camp_selectat != null)
            {
                // liniile comentate pot fi folosite pentru modificare meniu
                //lblGetTip.Text = txtAdminCamp1.Text = camp_selectat.tip_aliment.ToString();
                lblGetTip.Text = camp_selectat.tip_aliment.ToString();
                //lblGetDenumire.Text = txtAdminCamp2.Text = camp_selectat.denumire;
                lblGetDenumire.Text = camp_selectat.denumire;
                //lblGetPret.Text = txtAdminCamp3.Text = camp_selectat.pret.ToString();
                lblGetPret.Text = camp_selectat.pret.ToString();

            }
            else { lblGetPret.Text = ""; }

        }


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


        public void reset_erori() // resetarea generala a erorilor
        {
            lblEroareNume.Text = ""; lblEroarePrenume.Text = ""; lblEroareCNP.Text = ""; lblEroareCOD.Text = "";
            lblEroareNume.ForeColor = Color.Transparent; lblEroarePrenume.ForeColor = Color.Transparent; lblEroareCNP.ForeColor = Color.Transparent; lblEroareCOD.ForeColor = Color.Transparent;

        }


        #endregion


        #region ADMIN

        private void btnADMIN_Click(object sender, EventArgs e)
        {
            revenire_form_client();
            grOPTIUNI.Visible = false;

            grAdminOptiuni.Visible = true;

            grAfiseazaInfo.Visible = false;
            grAdminModificare.Visible = false;

            lblEroareCamp1.Visible = false;
            lblEroareCamp2.Text = "";
            lblEroareCamp2.ForeColor = Color.Transparent;
            lblEroareCamp2.Visible = false;
            lblEroareCamp3.Visible = false;

            btnADMIN.Visible = false;
            btnAdminIesire.Visible = true;
            
            rdbAdmin_rdb1.Checked = false;
            rdbAdmin_rdb2.Checked = false;
            rdbAdmin_rdb3.Checked = false;
            rdb2locuri.Checked = false;
            rdb3locuri.Checked = false;
            rdb5locuri.Checked = false;
            rdb7locuri.Checked = false;
            rdb9locuri.Checked = false;
            txtAdminCamp1.Text = "";
            txtAdminCamp2.Text = "";
            txtAdminCamp3.Text = "";

        }

        private void btnAdaugaMese_Click(object sender, EventArgs e)
        {

            btnAdminInapoi.Visible = true;

            lstAfisareInfo.Enabled = true;
            lstAfisareInfo.Items.Clear();
            lstAfisareInfo.ClearSelected();

            grAdminOptiuni.Visible = false;

            // modific text, nume, date in grupul cu list
            grAfiseazaInfo.Text = "Mese";
            btnCOMANDA.Visible = false;
            lblTotalPlata_Bon.Visible = false;
            grAfiseazaInfo.Visible = true;


            grAdminModificare.Text = "Adauga mese";
            grAdminModificare.Location = new Point(300, 250);
            grAdminModificare.Visible = true;

            txtAdminCamp1.Text = "";
            txtAdminCamp2.Text = "";
            txtAdminCamp3.Text = "";
            grAdmin_rdbCamp1.Visible = true;
            grAdminLocuri.Visible = true;
            txtAdminCamp1.Visible = false;
            txtAdminCamp2.Visible = false;
            txtAdminCamp3.Visible = false;

            lblTextCamp1.Text = "Locatie";
            lblTextCamp2.Visible = false;
            lblTextCamp3.Text = "Nr locuri";


            rdbAdmin_rdb1.Visible = true;
            rdbAdmin_rdb2.Visible = true;
            rdbAdmin_rdb3.Visible = true;
            rdbAdmin_rdb1.Checked = false;
            rdbAdmin_rdb2.Checked = false;
            rdbAdmin_rdb3.Checked = false;


            rdbAdmin_rdb1.Text = "Interior";
            rdbAdmin_rdb2.Text = "Separeu";
            rdbAdmin_rdb3.Text = "Terasa";

            rdb2locuri.Visible = true;
            rdb3locuri.Visible = true;
            rdb5locuri.Visible = true;
            rdb7locuri.Visible = true;
            rdb9locuri.Visible = true;

            rdb2locuri.Checked = false;
            rdb3locuri.Checked = false;
            rdb5locuri.Checked = false;
            rdb7locuri.Checked = false;
            rdb9locuri.Checked = false;

            btnAdminModifica.Text = "Adauga";

            btn_pentru_mese = true;

        }

        private void btnAdaugaMeniu_Click(object sender, EventArgs e)
        {
            btnAdminInapoi.Visible = true;

            lstAfisareInfo.Enabled = true;
            lstAfisareInfo.Items.Clear();
            lstAfisareInfo.ClearSelected();

            grAdminOptiuni.Visible = false;

            grAfiseazaInfo.Visible = true;

            rdbAdmin_rdb1.Visible = true;
            rdbAdmin_rdb2.Visible = true;
            rdbAdmin_rdb3.Visible = true;
            rdbAdmin_rdb1.Checked = false;
            rdbAdmin_rdb2.Checked = false;
            rdbAdmin_rdb3.Checked = false;

            rdbAdmin_rdb1.Text = "Mancare";
            rdbAdmin_rdb2.Text = "Bautura";
            rdbAdmin_rdb3.Text = "Desert";

            rdb2locuri.Visible = false;
            rdb3locuri.Visible = false;
            rdb5locuri.Visible = false;
            rdb7locuri.Visible = false;
            rdb9locuri.Visible = false;

            rdb2locuri.Checked = false;
            rdb3locuri.Checked = false;
            rdb5locuri.Checked = false;
            rdb7locuri.Checked = false;
            rdb9locuri.Checked = false;


            grAdminModificare.Text = "Adauga meniu";
            grAdminModificare.Location = new Point(300, 250);
            grAdminModificare.Visible = true;

            lblTextCamp1.Text = "Tip";
            lblTextCamp2.Text = "Denumire";
            lblTextCamp3.Text = "Pret";
            lblTextCamp2.Visible = true;

            grAdmin_rdbCamp1.Visible = true;
            grAdminLocuri.Visible = false;
            txtAdminCamp1.Visible = false;
            txtAdminCamp2.Visible = true;
            txtAdminCamp3.Visible = true;

            btnAdminModifica.Text = "Adauga";

            grAfiseazaInfo.Text = "Meniu";
            btnCOMANDA.Visible = false;
            lblTotalPlata_Bon.Visible = false;

            btn_pentru_mese = false;
        }


        // Controale meniu

        private void txtAdminCamp1_TextChanged(object sender, EventArgs e)
        {

            validare = true;
            if (txtAdminCamp1.Text.Length > LIMITA_MAXIMA_TEXT)
            {
                lblEroareCamp1.Text = "MAXIM " + LIMITA_MAXIMA_TEXT + " CARACTERE";
                lblEroareCamp1.ForeColor = Color.Green;
                lblEroareCamp1.Visible = true;
                validare = false;
            }
            else
            if (txtAdminCamp1.Text.Length < LIMITA_MINIMA_TEXT)
            {
                lblEroareCamp1.Text = "MINIM " + LIMITA_MINIMA_TEXT + " CARACTERE";
                lblEroareCamp1.ForeColor = Color.Green;
                lblEroareCamp1.Visible = true;
                validare = false;
            }

            if (validare == true)
            {
                lblEroareCamp1.Text = "";
                lblEroareCamp1.ForeColor = Color.Transparent;
                lblEroareCamp1.Visible = false;

            }
        }

        private void txtAdminCamp2_TextChanged(object sender, EventArgs e)
        {

            validare = true;
            if (txtAdminCamp2.Text.Length > LIMITA_MAXIMA_TEXT)
            {
                lblEroareCamp2.Text = "MAXIM " + LIMITA_MAXIMA_TEXT + " CARACTERE";
                lblEroareCamp2.ForeColor = Color.Green;
                lblEroareCamp2.Visible = true;
                validare = false;
            }
            else
            if (txtAdminCamp2.Text.Length < LIMITA_MINIMA_TEXT)
            {
                lblEroareCamp2.Text = "MINIM " + LIMITA_MINIMA_TEXT + " CARACTERE";
                lblEroareCamp2.ForeColor = Color.Green;
                lblEroareCamp2.Visible = true;
                validare = false;
            }

            if (validare == true)
            {
                lblEroareCamp2.Text = "";
                lblEroareCamp2.ForeColor = Color.Transparent;
                lblEroareCamp2.Visible = false;

            }
        }

        // inca e eroare la pret
        private void txtAdminCamp3_TextChanged(object sender, EventArgs e)
        {
            validare = true;
            string pret = txtAdminCamp3.Text;

            for (int i = 0; i < pret.Length; i++)
            {
                if (!char.IsDigit(pret[i]) || pret[i] == '-')
                {
                    lblEroareCamp3.Text = "TREBUIE SA CONTINA DOAR CIFRE";
                    lblEroareCamp3.ForeColor = Color.Green;
                    lblEroareCamp3.Visible = true;
                    validare = false;
                }
            }

            if (validare == true)
            {
                lblEroareCamp3.Visible = false;
                lblEroareCamp3.Text = "";
                lblEroareCamp3.ForeColor = Color.Transparent;
            }
        }
        private void btnAdminAdauga_Modifica_Click(object sender, EventArgs e)// Buton de modificare meniu pentru rolul de administrator
        {
            validare = true;
            if (btn_pentru_mese == false) // am selectat in admin optiunea de adaugare meniu
            {
                rdbAdmin_rdb1.Checked = false;
                rdbAdmin_rdb2.Checked = false;
                rdbAdmin_rdb3.Checked = false;

                lblTextCamp1.ForeColor = Color.Black;
                lblTextCamp2.ForeColor = Color.Black;
                lblTextCamp3.ForeColor = Color.Black;


                if (rdbAdmin_rdb1.Checked == false && rdbAdmin_rdb2.Checked == false && rdbAdmin_rdb3.Checked == false)
                {
                    lblEroareCamp1.Text = "Selectati locatia mesei";
                    lblEroareCamp1.ForeColor = Color.Green;
                    lblEroareCamp1.Visible = true;
                    validare = false;
                }

                if (txtAdminCamp2.Text == "")
                {
                    lblEroareCamp2.Text = "Introduceti denumirea produsului";
                    lblEroareCamp2.ForeColor = Color.Green;
                    lblEroareCamp2.Visible = true;
                    validare = false;
                }
                if (txtAdminCamp3.Text == "")
                {
                    lblEroareCamp3.Text = "Introduceti pretul produsului";
                    lblEroareCamp3.ForeColor = Color.Green;
                    lblEroareCamp3.Visible = true;
                    validare = false;
                }


                if (validare == true)
                {

                    rdbAdmin_rdb1.Checked = false;
                    rdbAdmin_rdb2.Checked = false;
                    rdbAdmin_rdb3.Checked = false;

                    IStocareMeniu stocare_info_meniu = new Administrare_meniu();
                    List<Meniu> list_meniu = stocare_info_meniu.GetInfo();

                    Meniu add_meniu = new Meniu();
                    if (rdbAdmin_rdb1.Checked == true)
                        add_meniu.tip_aliment = rdbAdmin_rdb1.Text;
                    else
                    if (rdbAdmin_rdb2.Checked == true)
                        add_meniu.tip_aliment = rdbAdmin_rdb2.Text;
                    else
                    if (rdbAdmin_rdb3.Checked == true)
                        add_meniu.tip_aliment = rdbAdmin_rdb3.Text;

                    add_meniu.denumire = txtAdminCamp2.Text;
                    //txtAdminCamp3.Text
                    string pret_nou = "";
                    string pret = txtAdminCamp3.Text;
                    for (int i = 0; i < pret.Length; i++)
                    {
                        if (pret[i] == '.')
                            pret_nou += '.';
                        else
                            if (pret[i] == ',')
                            pret_nou += '.';
                        else
                        if (char.IsDigit(pret[i]))
                            pret_nou += pret[i];
                    }

                    MessageBox.Show(pret_nou);
                    add_meniu.pret = float.Parse(pret_nou, System.Globalization.CultureInfo.InvariantCulture);

                    if (list_meniu.Count != 0)
                    {
                        add_meniu.id = Meniu.last_id;
                        stocare_info_meniu.UpdateMeniu(add_meniu);
                    }
                    else
                    {
                        add_meniu.id = 1;
                        stocare_info_meniu.UpdateMeniu(add_meniu, true);
                    }


                    admin_reset_controale_meniu();
                    btnAfiseazaInfo_Click(sender, e);
                }

            }
            // adaugare mese
            else
            {
                if (rdbAdmin_rdb1.Checked == false && rdbAdmin_rdb2.Checked == false && rdbAdmin_rdb3.Checked == false)
                {
                    lblEroareCamp1.Text = "Selectati locatia mesei";
                    lblEroareCamp1.ForeColor = Color.Green;
                    lblEroareCamp1.Visible = true;
                    validare = false;
                }
                if (rdb2locuri.Checked == false && rdb3locuri.Checked == false && rdb5locuri.Checked == false && rdb7locuri.Checked == false && rdb9locuri.Checked == false)
                {
                    lblEroareCamp3.Text = "Selectati numarul de locuri";
                    lblEroareCamp3.ForeColor = Color.Green;
                    lblEroareCamp3.Visible = true;
                    validare = false;
                }

                if (validare == true)
                {
                    lblEroareCamp1.Text = "";
                    lblEroareCamp2.Text = "";
                    lblEroareCamp3.Text = "";
                    lblEroareCamp1.ForeColor = Color.Transparent;
                    lblEroareCamp2.ForeColor = Color.Transparent;
                    lblEroareCamp3.ForeColor = Color.Transparent;


                    string _locatie = "";
                    int _locuri = 0;

                    if (rdbAdmin_rdb1.Checked == true)
                        _locatie = rdbAdmin_rdb1.Text;
                    else
                    if (rdbAdmin_rdb2.Checked == true)
                        _locatie = rdbAdmin_rdb2.Text;
                    else
                    if (rdbAdmin_rdb3.Checked == true)
                        _locatie = rdbAdmin_rdb3.Text;

                    if (rdb2locuri.Checked)
                        _locuri = Convert.ToInt32(rdb2locuri.Text);
                    if (rdb3locuri.Checked)
                        _locuri = Convert.ToInt32(rdb3locuri.Text);
                    if (rdb5locuri.Checked)
                        _locuri = Convert.ToInt32(rdb5locuri.Text);
                    if (rdb7locuri.Checked)
                        _locuri = Convert.ToInt32(rdb7locuri.Text);
                    if (rdb9locuri.Checked)
                        _locuri = Convert.ToInt32(rdb9locuri.Text);



                    Masa b = new Masa();
                    b.locuri = b.GenerareCodUnic();
                    IStocareMasa stocare_info_masa = new Administrare_masa();
                    List<Masa> list_masa = stocare_info_masa.GetInfo();

                    if (list_masa.Count != 0)
                    {
                        // Verificare numar mese 
                        int nr1 = 0;
                        foreach (Masa m in list_masa)
                            if (m.locatie == _locatie)
                                nr1++;

                        if (nr1 < 4)
                            stocare_info_masa.UpdateMasa(Masa.last_id, false, _locuri, _locatie);

                        if (nr1 == 4)
                            MessageBox.Show($"Nu se mai pot adauga mese in {_locatie}!\nNumar maxim de mese: 4");
                    }
                    else
                    {
                        stocare_info_masa.UpdateMasa(1, false, _locuri, _locatie);
                    }

                    rdbAdmin_rdb1.Checked = false;
                    rdbAdmin_rdb2.Checked = false;
                    rdbAdmin_rdb3.Checked = false;
                    rdb2locuri.Checked = false;
                    rdb3locuri.Checked = false;
                    rdb5locuri.Checked = false;
                    rdb7locuri.Checked = false;
                    rdb9locuri.Checked = false;
                    txtAdminCamp1.Text = "";
                    txtAdminCamp2.Text = "";
                    txtAdminCamp3.Text = "";
                }
            }
        }

        public void admin_reset_controale_meniu()
        {
            txtAdminCamp1.Text = "";
            txtAdminCamp2.Text = "";
            txtAdminCamp3.Text = "";
            lblEroareCamp1.Visible = true;
            lblEroareCamp2.Visible = true;
            lblEroareCamp3.Visible = true;
            lblEroareCamp1.Text = "";
            lblEroareCamp2.Text = "";
            lblEroareCamp3.Text = "";
            lblEroareCamp1.ForeColor = Color.Transparent;
            lblEroareCamp2.ForeColor = Color.Transparent;
            lblEroareCamp3.ForeColor = Color.Transparent;
        }

        private void btnAdminIesire_Click(object sender, EventArgs e)
        {
            revenire_form_client();
            admin_reset_controale_meniu();
            reset_controale_client();
            reset_erori();
        }
        #endregion


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

    }
}
