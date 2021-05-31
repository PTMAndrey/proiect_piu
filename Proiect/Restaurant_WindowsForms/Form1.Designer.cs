
namespace Restaurant_WindowsForms
{
    partial class Client_form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client_form));
            this.txtNumeRestaurant = new System.Windows.Forms.Label();
            this.grLocatie = new System.Windows.Forms.GroupBox();
            this.rdbANULEAZA = new System.Windows.Forms.RadioButton();
            this.rdbTERASA = new System.Windows.Forms.RadioButton();
            this.rdbSEPAREU = new System.Windows.Forms.RadioButton();
            this.rdbINTERIOR = new System.Windows.Forms.RadioButton();
            this.btnMasa1 = new System.Windows.Forms.Button();
            this.btnMasa2 = new System.Windows.Forms.Button();
            this.btnMasa3 = new System.Windows.Forms.Button();
            this.btnMasa4 = new System.Windows.Forms.Button();
            this.grMese = new System.Windows.Forms.GroupBox();
            this.lblNUME = new System.Windows.Forms.Label();
            this.lblPRENUME = new System.Windows.Forms.Label();
            this.txtNUME = new System.Windows.Forms.TextBox();
            this.txtPRENUME = new System.Windows.Forms.TextBox();
            this.txtCNP = new System.Windows.Forms.TextBox();
            this.lblCNP = new System.Windows.Forms.Label();
            this.btnREZERVA = new System.Windows.Forms.Button();
            this.lblEroareNume = new System.Windows.Forms.Label();
            this.lblEroarePrenume = new System.Windows.Forms.Label();
            this.lblEroareCNP = new System.Windows.Forms.Label();
            this.btnAfiseazaInfo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnMODIFICA = new System.Windows.Forms.Button();
            this.txtModificaPret = new System.Windows.Forms.TextBox();
            this.lblPRET = new System.Windows.Forms.Label();
            this.txtModificaDenumire = new System.Windows.Forms.TextBox();
            this.txtModificaTip = new System.Windows.Forms.TextBox();
            this.lblDENUMIRE = new System.Windows.Forms.Label();
            this.lblTIP = new System.Windows.Forms.Label();
            this.btnCOMANDA = new System.Windows.Forms.Button();
            this.grRezervareClient = new System.Windows.Forms.GroupBox();
            this.grAfiseazaInfo = new System.Windows.Forms.GroupBox();
            this.lblPretTotal = new System.Windows.Forms.Label();
            this.lblTotalPlata_Bon = new System.Windows.Forms.Label();
            this.lblGetPret = new System.Windows.Forms.Label();
            this.lblGetDenumire = new System.Windows.Forms.Label();
            this.lblGetTip = new System.Windows.Forms.Label();
            this.lstAfisareInfo = new System.Windows.Forms.ListBox();
            this.grIntroducetiCodulMesei = new System.Windows.Forms.GroupBox();
            this.btnCodGata = new System.Windows.Forms.Button();
            this.lblEroareCOD = new System.Windows.Forms.Label();
            this.txtCodUnic = new System.Windows.Forms.TextBox();
            this.grOPTIUNI = new System.Windows.Forms.GroupBox();
            this.btnOptDetinMasa = new System.Windows.Forms.Button();
            this.btnOptRezervare = new System.Windows.Forms.Button();
            this.lblOPTMASA = new System.Windows.Forms.Label();
            this.grModificareMeniu = new System.Windows.Forms.GroupBox();
            this.btnADMIN = new System.Windows.Forms.Button();
            this.grLocatie.SuspendLayout();
            this.grMese.SuspendLayout();
            this.grRezervareClient.SuspendLayout();
            this.grAfiseazaInfo.SuspendLayout();
            this.grIntroducetiCodulMesei.SuspendLayout();
            this.grOPTIUNI.SuspendLayout();
            this.grModificareMeniu.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNumeRestaurant
            // 
            this.txtNumeRestaurant.AutoSize = true;
            this.txtNumeRestaurant.Font = new System.Drawing.Font("Showcard Gothic", 30F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtNumeRestaurant.Location = new System.Drawing.Point(450, 16);
            this.txtNumeRestaurant.Name = "txtNumeRestaurant";
            this.txtNumeRestaurant.Size = new System.Drawing.Size(522, 124);
            this.txtNumeRestaurant.TabIndex = 0;
            this.txtNumeRestaurant.Text = "RESTAURANT \r\n             \" LA CUMATRU \"";
            // 
            // grLocatie
            // 
            this.grLocatie.Controls.Add(this.rdbANULEAZA);
            this.grLocatie.Controls.Add(this.rdbTERASA);
            this.grLocatie.Controls.Add(this.rdbSEPAREU);
            this.grLocatie.Controls.Add(this.rdbINTERIOR);
            this.grLocatie.Font = new System.Drawing.Font("Hobo Std", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grLocatie.Location = new System.Drawing.Point(92, 204);
            this.grLocatie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grLocatie.Name = "grLocatie";
            this.grLocatie.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grLocatie.Size = new System.Drawing.Size(208, 284);
            this.grLocatie.TabIndex = 1;
            this.grLocatie.TabStop = false;
            this.grLocatie.Text = "Alege locatia";
            // 
            // rdbANULEAZA
            // 
            this.rdbANULEAZA.AutoSize = true;
            this.rdbANULEAZA.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdbANULEAZA.Location = new System.Drawing.Point(32, 232);
            this.rdbANULEAZA.Name = "rdbANULEAZA";
            this.rdbANULEAZA.Size = new System.Drawing.Size(132, 32);
            this.rdbANULEAZA.TabIndex = 14;
            this.rdbANULEAZA.Text = "ANULEAZA";
            this.rdbANULEAZA.UseVisualStyleBackColor = true;
            this.rdbANULEAZA.CheckedChanged += new System.EventHandler(this.Locatie_CheckedChanged);
            // 
            // rdbTERASA
            // 
            this.rdbTERASA.AutoSize = true;
            this.rdbTERASA.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdbTERASA.Location = new System.Drawing.Point(32, 162);
            this.rdbTERASA.Name = "rdbTERASA";
            this.rdbTERASA.Size = new System.Drawing.Size(102, 32);
            this.rdbTERASA.TabIndex = 13;
            this.rdbTERASA.Text = "TERASA";
            this.rdbTERASA.UseVisualStyleBackColor = true;
            this.rdbTERASA.CheckedChanged += new System.EventHandler(this.Locatie_CheckedChanged);
            // 
            // rdbSEPAREU
            // 
            this.rdbSEPAREU.AutoSize = true;
            this.rdbSEPAREU.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdbSEPAREU.Location = new System.Drawing.Point(32, 111);
            this.rdbSEPAREU.Name = "rdbSEPAREU";
            this.rdbSEPAREU.Size = new System.Drawing.Size(113, 32);
            this.rdbSEPAREU.TabIndex = 12;
            this.rdbSEPAREU.Text = "SEPAREU";
            this.rdbSEPAREU.UseVisualStyleBackColor = true;
            this.rdbSEPAREU.CheckedChanged += new System.EventHandler(this.Locatie_CheckedChanged);
            // 
            // rdbINTERIOR
            // 
            this.rdbINTERIOR.AutoSize = true;
            this.rdbINTERIOR.Checked = true;
            this.rdbINTERIOR.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdbINTERIOR.Location = new System.Drawing.Point(32, 61);
            this.rdbINTERIOR.Name = "rdbINTERIOR";
            this.rdbINTERIOR.Size = new System.Drawing.Size(117, 32);
            this.rdbINTERIOR.TabIndex = 11;
            this.rdbINTERIOR.TabStop = true;
            this.rdbINTERIOR.Text = "INTERIOR";
            this.rdbINTERIOR.UseVisualStyleBackColor = true;
            this.rdbINTERIOR.CheckedChanged += new System.EventHandler(this.Locatie_CheckedChanged);
            // 
            // btnMasa1
            // 
            this.btnMasa1.BackColor = System.Drawing.Color.Lime;
            this.btnMasa1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMasa1.FlatAppearance.BorderSize = 0;
            this.btnMasa1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMasa1.Location = new System.Drawing.Point(35, 70);
            this.btnMasa1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMasa1.Name = "btnMasa1";
            this.btnMasa1.Size = new System.Drawing.Size(101, 94);
            this.btnMasa1.TabIndex = 1;
            this.btnMasa1.Text = "Masa 1";
            this.btnMasa1.UseVisualStyleBackColor = false;
            this.btnMasa1.Click += new System.EventHandler(this.btnMasa_Selectat_Click);
            // 
            // btnMasa2
            // 
            this.btnMasa2.BackColor = System.Drawing.Color.Lime;
            this.btnMasa2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMasa2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMasa2.Location = new System.Drawing.Point(216, 70);
            this.btnMasa2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMasa2.Name = "btnMasa2";
            this.btnMasa2.Size = new System.Drawing.Size(101, 94);
            this.btnMasa2.TabIndex = 2;
            this.btnMasa2.Text = "Masa 2";
            this.btnMasa2.UseVisualStyleBackColor = false;
            this.btnMasa2.Click += new System.EventHandler(this.btnMasa_Selectat_Click);
            // 
            // btnMasa3
            // 
            this.btnMasa3.BackColor = System.Drawing.Color.Lime;
            this.btnMasa3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMasa3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMasa3.Location = new System.Drawing.Point(397, 70);
            this.btnMasa3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMasa3.Name = "btnMasa3";
            this.btnMasa3.Size = new System.Drawing.Size(101, 94);
            this.btnMasa3.TabIndex = 3;
            this.btnMasa3.Text = "Masa 3";
            this.btnMasa3.UseVisualStyleBackColor = false;
            this.btnMasa3.Click += new System.EventHandler(this.btnMasa_Selectat_Click);
            // 
            // btnMasa4
            // 
            this.btnMasa4.BackColor = System.Drawing.Color.Lime;
            this.btnMasa4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMasa4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMasa4.Location = new System.Drawing.Point(579, 70);
            this.btnMasa4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMasa4.Name = "btnMasa4";
            this.btnMasa4.Size = new System.Drawing.Size(101, 94);
            this.btnMasa4.TabIndex = 4;
            this.btnMasa4.Text = "Masa 4";
            this.btnMasa4.UseVisualStyleBackColor = false;
            this.btnMasa4.Click += new System.EventHandler(this.btnMasa_Selectat_Click);
            // 
            // grMese
            // 
            this.grMese.Controls.Add(this.btnMasa4);
            this.grMese.Controls.Add(this.btnMasa3);
            this.grMese.Controls.Add(this.btnMasa2);
            this.grMese.Controls.Add(this.btnMasa1);
            this.grMese.Font = new System.Drawing.Font("Hobo Std", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grMese.Location = new System.Drawing.Point(384, 204);
            this.grMese.Name = "grMese";
            this.grMese.Size = new System.Drawing.Size(719, 222);
            this.grMese.TabIndex = 10;
            this.grMese.TabStop = false;
            this.grMese.Text = "Alege masa";
            // 
            // lblNUME
            // 
            this.lblNUME.AutoSize = true;
            this.lblNUME.Font = new System.Drawing.Font("Hobo Std", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNUME.Location = new System.Drawing.Point(17, 79);
            this.lblNUME.Name = "lblNUME";
            this.lblNUME.Size = new System.Drawing.Size(86, 34);
            this.lblNUME.TabIndex = 11;
            this.lblNUME.Text = "NUME";
            // 
            // lblPRENUME
            // 
            this.lblPRENUME.AutoSize = true;
            this.lblPRENUME.Font = new System.Drawing.Font("Hobo Std", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPRENUME.Location = new System.Drawing.Point(17, 182);
            this.lblPRENUME.Name = "lblPRENUME";
            this.lblPRENUME.Size = new System.Drawing.Size(134, 34);
            this.lblPRENUME.TabIndex = 12;
            this.lblPRENUME.Text = "PRENUME";
            // 
            // txtNUME
            // 
            this.txtNUME.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNUME.Location = new System.Drawing.Point(172, 79);
            this.txtNUME.Name = "txtNUME";
            this.txtNUME.PlaceholderText = " Numele de familie...";
            this.txtNUME.Size = new System.Drawing.Size(284, 27);
            this.txtNUME.TabIndex = 13;
            this.txtNUME.TextChanged += new System.EventHandler(this.txtNUME_TextChanged);
            // 
            // txtPRENUME
            // 
            this.txtPRENUME.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPRENUME.Location = new System.Drawing.Point(172, 182);
            this.txtPRENUME.Name = "txtPRENUME";
            this.txtPRENUME.PlaceholderText = " Prenumele...";
            this.txtPRENUME.Size = new System.Drawing.Size(284, 27);
            this.txtPRENUME.TabIndex = 14;
            this.txtPRENUME.TextChanged += new System.EventHandler(this.txtPRENUME_TextChanged);
            // 
            // txtCNP
            // 
            this.txtCNP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCNP.Location = new System.Drawing.Point(172, 284);
            this.txtCNP.Name = "txtCNP";
            this.txtCNP.PlaceholderText = " Cod numeric personal...";
            this.txtCNP.Size = new System.Drawing.Size(284, 27);
            this.txtCNP.TabIndex = 16;
            this.txtCNP.TextChanged += new System.EventHandler(this.txtCNP_TextChanged);
            // 
            // lblCNP
            // 
            this.lblCNP.AutoSize = true;
            this.lblCNP.Font = new System.Drawing.Font("Hobo Std", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCNP.Location = new System.Drawing.Point(17, 284);
            this.lblCNP.Name = "lblCNP";
            this.lblCNP.Size = new System.Drawing.Size(65, 34);
            this.lblCNP.TabIndex = 15;
            this.lblCNP.Text = "CNP";
            // 
            // btnREZERVA
            // 
            this.btnREZERVA.Font = new System.Drawing.Font("Hobo Std", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnREZERVA.Location = new System.Drawing.Point(172, 373);
            this.btnREZERVA.Name = "btnREZERVA";
            this.btnREZERVA.Size = new System.Drawing.Size(134, 39);
            this.btnREZERVA.TabIndex = 17;
            this.btnREZERVA.Text = "REZERVA";
            this.btnREZERVA.UseVisualStyleBackColor = true;
            this.btnREZERVA.Click += new System.EventHandler(this.btnREZERVA_Click);
            // 
            // lblEroareNume
            // 
            this.lblEroareNume.AutoSize = true;
            this.lblEroareNume.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEroareNume.ForeColor = System.Drawing.Color.Transparent;
            this.lblEroareNume.Location = new System.Drawing.Point(172, 112);
            this.lblEroareNume.Name = "lblEroareNume";
            this.lblEroareNume.Size = new System.Drawing.Size(0, 20);
            this.lblEroareNume.TabIndex = 18;
            // 
            // lblEroarePrenume
            // 
            this.lblEroarePrenume.AutoSize = true;
            this.lblEroarePrenume.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEroarePrenume.ForeColor = System.Drawing.Color.Transparent;
            this.lblEroarePrenume.Location = new System.Drawing.Point(172, 212);
            this.lblEroarePrenume.Name = "lblEroarePrenume";
            this.lblEroarePrenume.Size = new System.Drawing.Size(0, 20);
            this.lblEroarePrenume.TabIndex = 19;
            // 
            // lblEroareCNP
            // 
            this.lblEroareCNP.AutoSize = true;
            this.lblEroareCNP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEroareCNP.ForeColor = System.Drawing.Color.Transparent;
            this.lblEroareCNP.Location = new System.Drawing.Point(172, 314);
            this.lblEroareCNP.Name = "lblEroareCNP";
            this.lblEroareCNP.Size = new System.Drawing.Size(0, 20);
            this.lblEroareCNP.TabIndex = 20;
            // 
            // btnAfiseazaInfo
            // 
            this.btnAfiseazaInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAfiseazaInfo.Font = new System.Drawing.Font("Hobo Std", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAfiseazaInfo.Location = new System.Drawing.Point(23, 72);
            this.btnAfiseazaInfo.Name = "btnAfiseazaInfo";
            this.btnAfiseazaInfo.Size = new System.Drawing.Size(134, 39);
            this.btnAfiseazaInfo.TabIndex = 22;
            this.btnAfiseazaInfo.Text = "AFISEAZA";
            this.btnAfiseazaInfo.UseVisualStyleBackColor = true;
            this.btnAfiseazaInfo.Click += new System.EventHandler(this.btnAfiseazaMeniu_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(1487, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 20);
            this.label3.TabIndex = 34;
            this.label3.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(193, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(193, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 20);
            this.label5.TabIndex = 32;
            this.label5.Text = "*";
            // 
            // btnMODIFICA
            // 
            this.btnMODIFICA.Font = new System.Drawing.Font("Hobo Std", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMODIFICA.Location = new System.Drawing.Point(193, 245);
            this.btnMODIFICA.Name = "btnMODIFICA";
            this.btnMODIFICA.Size = new System.Drawing.Size(134, 39);
            this.btnMODIFICA.TabIndex = 31;
            this.btnMODIFICA.Text = "MODIFICA";
            this.btnMODIFICA.UseVisualStyleBackColor = true;
            this.btnMODIFICA.Click += new System.EventHandler(this.btnMODIFICA_Click);
            // 
            // txtModificaPret
            // 
            this.txtModificaPret.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtModificaPret.Location = new System.Drawing.Point(193, 187);
            this.txtModificaPret.Name = "txtModificaPret";
            this.txtModificaPret.PlaceholderText = " Pret produs";
            this.txtModificaPret.Size = new System.Drawing.Size(284, 27);
            this.txtModificaPret.TabIndex = 30;
            // 
            // lblPRET
            // 
            this.lblPRET.AutoSize = true;
            this.lblPRET.Font = new System.Drawing.Font("Hobo Std", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPRET.Location = new System.Drawing.Point(38, 187);
            this.lblPRET.Name = "lblPRET";
            this.lblPRET.Size = new System.Drawing.Size(79, 34);
            this.lblPRET.TabIndex = 29;
            this.lblPRET.Text = "PRET";
            // 
            // txtModificaDenumire
            // 
            this.txtModificaDenumire.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtModificaDenumire.Location = new System.Drawing.Point(193, 126);
            this.txtModificaDenumire.Name = "txtModificaDenumire";
            this.txtModificaDenumire.PlaceholderText = " Nume produs...";
            this.txtModificaDenumire.Size = new System.Drawing.Size(284, 27);
            this.txtModificaDenumire.TabIndex = 28;
            // 
            // txtModificaTip
            // 
            this.txtModificaTip.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtModificaTip.Location = new System.Drawing.Point(193, 58);
            this.txtModificaTip.Name = "txtModificaTip";
            this.txtModificaTip.PlaceholderText = " Tip produs...";
            this.txtModificaTip.Size = new System.Drawing.Size(284, 27);
            this.txtModificaTip.TabIndex = 27;
            // 
            // lblDENUMIRE
            // 
            this.lblDENUMIRE.AutoSize = true;
            this.lblDENUMIRE.Font = new System.Drawing.Font("Hobo Std", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDENUMIRE.Location = new System.Drawing.Point(38, 126);
            this.lblDENUMIRE.Name = "lblDENUMIRE";
            this.lblDENUMIRE.Size = new System.Drawing.Size(143, 34);
            this.lblDENUMIRE.TabIndex = 26;
            this.lblDENUMIRE.Text = "DENUMIRE";
            // 
            // lblTIP
            // 
            this.lblTIP.AutoSize = true;
            this.lblTIP.Font = new System.Drawing.Font("Hobo Std", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTIP.Location = new System.Drawing.Point(38, 58);
            this.lblTIP.Name = "lblTIP";
            this.lblTIP.Size = new System.Drawing.Size(55, 34);
            this.lblTIP.TabIndex = 25;
            this.lblTIP.Text = "TIP";
            // 
            // btnCOMANDA
            // 
            this.btnCOMANDA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCOMANDA.Font = new System.Drawing.Font("Hobo Std", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCOMANDA.Location = new System.Drawing.Point(23, 336);
            this.btnCOMANDA.Name = "btnCOMANDA";
            this.btnCOMANDA.Size = new System.Drawing.Size(134, 39);
            this.btnCOMANDA.TabIndex = 36;
            this.btnCOMANDA.Text = "COMANDA";
            this.btnCOMANDA.Click += new System.EventHandler(this.btnCOMANDA_Click);
            // 
            // grRezervareClient
            // 
            this.grRezervareClient.Controls.Add(this.txtCNP);
            this.grRezervareClient.Controls.Add(this.lblNUME);
            this.grRezervareClient.Controls.Add(this.lblPRENUME);
            this.grRezervareClient.Controls.Add(this.txtNUME);
            this.grRezervareClient.Controls.Add(this.txtPRENUME);
            this.grRezervareClient.Controls.Add(this.lblCNP);
            this.grRezervareClient.Controls.Add(this.lblEroareNume);
            this.grRezervareClient.Controls.Add(this.lblEroarePrenume);
            this.grRezervareClient.Controls.Add(this.lblEroareCNP);
            this.grRezervareClient.Controls.Add(this.btnREZERVA);
            this.grRezervareClient.Font = new System.Drawing.Font("Hobo Std", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grRezervareClient.Location = new System.Drawing.Point(92, 493);
            this.grRezervareClient.Name = "grRezervareClient";
            this.grRezervareClient.Size = new System.Drawing.Size(480, 424);
            this.grRezervareClient.TabIndex = 37;
            this.grRezervareClient.TabStop = false;
            this.grRezervareClient.Text = "Rezervare la masa";
            // 
            // grAfiseazaInfo
            // 
            this.grAfiseazaInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grAfiseazaInfo.Controls.Add(this.lblPretTotal);
            this.grAfiseazaInfo.Controls.Add(this.lblTotalPlata_Bon);
            this.grAfiseazaInfo.Controls.Add(this.lblGetPret);
            this.grAfiseazaInfo.Controls.Add(this.lblGetDenumire);
            this.grAfiseazaInfo.Controls.Add(this.lblGetTip);
            this.grAfiseazaInfo.Controls.Add(this.lstAfisareInfo);
            this.grAfiseazaInfo.Controls.Add(this.btnAfiseazaInfo);
            this.grAfiseazaInfo.Controls.Add(this.btnCOMANDA);
            this.grAfiseazaInfo.Font = new System.Drawing.Font("Hobo Std", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grAfiseazaInfo.Location = new System.Drawing.Point(1147, 204);
            this.grAfiseazaInfo.Name = "grAfiseazaInfo";
            this.grAfiseazaInfo.Size = new System.Drawing.Size(685, 496);
            this.grAfiseazaInfo.TabIndex = 21;
            this.grAfiseazaInfo.TabStop = false;
            this.grAfiseazaInfo.Text = "Meniu";
            // 
            // lblPretTotal
            // 
            this.lblPretTotal.AutoSize = true;
            this.lblPretTotal.Font = new System.Drawing.Font("Segoe UI", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPretTotal.ForeColor = System.Drawing.Color.Transparent;
            this.lblPretTotal.Location = new System.Drawing.Point(23, 271);
            this.lblPretTotal.Name = "lblPretTotal";
            this.lblPretTotal.Size = new System.Drawing.Size(0, 3);
            this.lblPretTotal.TabIndex = 41;
            // 
            // lblTotalPlata_Bon
            // 
            this.lblTotalPlata_Bon.AutoSize = true;
            this.lblTotalPlata_Bon.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalPlata_Bon.ForeColor = System.Drawing.Color.Black;
            this.lblTotalPlata_Bon.Location = new System.Drawing.Point(23, 410);
            this.lblTotalPlata_Bon.Name = "lblTotalPlata_Bon";
            this.lblTotalPlata_Bon.Size = new System.Drawing.Size(135, 70);
            this.lblTotalPlata_Bon.TabIndex = 40;
            this.lblTotalPlata_Bon.Text = "Total plată:\r\n0 RON\r\n";
            // 
            // lblGetPret
            // 
            this.lblGetPret.AutoSize = true;
            this.lblGetPret.Font = new System.Drawing.Font("Segoe UI", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGetPret.ForeColor = System.Drawing.Color.Transparent;
            this.lblGetPret.Location = new System.Drawing.Point(23, 232);
            this.lblGetPret.Name = "lblGetPret";
            this.lblGetPret.Size = new System.Drawing.Size(0, 3);
            this.lblGetPret.TabIndex = 39;
            // 
            // lblGetDenumire
            // 
            this.lblGetDenumire.AutoSize = true;
            this.lblGetDenumire.Font = new System.Drawing.Font("Segoe UI", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGetDenumire.ForeColor = System.Drawing.Color.Transparent;
            this.lblGetDenumire.Location = new System.Drawing.Point(23, 198);
            this.lblGetDenumire.Name = "lblGetDenumire";
            this.lblGetDenumire.Size = new System.Drawing.Size(0, 3);
            this.lblGetDenumire.TabIndex = 38;
            // 
            // lblGetTip
            // 
            this.lblGetTip.AutoSize = true;
            this.lblGetTip.Font = new System.Drawing.Font("Segoe UI", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGetTip.ForeColor = System.Drawing.Color.Transparent;
            this.lblGetTip.Location = new System.Drawing.Point(23, 164);
            this.lblGetTip.Name = "lblGetTip";
            this.lblGetTip.Size = new System.Drawing.Size(0, 3);
            this.lblGetTip.TabIndex = 37;
            // 
            // lstAfisareInfo
            // 
            this.lstAfisareInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstAfisareInfo.FormattingEnabled = true;
            this.lstAfisareInfo.ItemHeight = 20;
            this.lstAfisareInfo.Location = new System.Drawing.Point(256, 45);
            this.lstAfisareInfo.Name = "lstAfisareInfo";
            this.lstAfisareInfo.Size = new System.Drawing.Size(411, 424);
            this.lstAfisareInfo.TabIndex = 24;
            this.lstAfisareInfo.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChanged);
            // 
            // grIntroducetiCodulMesei
            // 
            this.grIntroducetiCodulMesei.Controls.Add(this.btnCodGata);
            this.grIntroducetiCodulMesei.Controls.Add(this.lblEroareCOD);
            this.grIntroducetiCodulMesei.Controls.Add(this.txtCodUnic);
            this.grIntroducetiCodulMesei.Font = new System.Drawing.Font("Hobo Std", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grIntroducetiCodulMesei.Location = new System.Drawing.Point(639, 493);
            this.grIntroducetiCodulMesei.Name = "grIntroducetiCodulMesei";
            this.grIntroducetiCodulMesei.Size = new System.Drawing.Size(413, 201);
            this.grIntroducetiCodulMesei.TabIndex = 38;
            this.grIntroducetiCodulMesei.TabStop = false;
            this.grIntroducetiCodulMesei.Text = "Introduceti codul mesei";
            // 
            // btnCodGata
            // 
            this.btnCodGata.Location = new System.Drawing.Point(150, 134);
            this.btnCodGata.Name = "btnCodGata";
            this.btnCodGata.Size = new System.Drawing.Size(136, 44);
            this.btnCodGata.TabIndex = 22;
            this.btnCodGata.Text = "Gata";
            this.btnCodGata.UseVisualStyleBackColor = true;
            this.btnCodGata.Click += new System.EventHandler(this.btnCodGata_Click);
            // 
            // lblEroareCOD
            // 
            this.lblEroareCOD.AutoSize = true;
            this.lblEroareCOD.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEroareCOD.ForeColor = System.Drawing.Color.Transparent;
            this.lblEroareCOD.Location = new System.Drawing.Point(71, 112);
            this.lblEroareCOD.Name = "lblEroareCOD";
            this.lblEroareCOD.Size = new System.Drawing.Size(0, 20);
            this.lblEroareCOD.TabIndex = 21;
            // 
            // txtCodUnic
            // 
            this.txtCodUnic.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCodUnic.Location = new System.Drawing.Point(71, 79);
            this.txtCodUnic.Name = "txtCodUnic";
            this.txtCodUnic.PlaceholderText = " Codul unic al mesei...";
            this.txtCodUnic.Size = new System.Drawing.Size(284, 27);
            this.txtCodUnic.TabIndex = 21;
            this.txtCodUnic.TextChanged += new System.EventHandler(this.txtCodUnic_TextChanged);
            // 
            // grOPTIUNI
            // 
            this.grOPTIUNI.Controls.Add(this.btnOptDetinMasa);
            this.grOPTIUNI.Controls.Add(this.btnOptRezervare);
            this.grOPTIUNI.Font = new System.Drawing.Font("Hobo Std", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grOPTIUNI.Location = new System.Drawing.Point(92, 204);
            this.grOPTIUNI.Name = "grOPTIUNI";
            this.grOPTIUNI.Size = new System.Drawing.Size(208, 203);
            this.grOPTIUNI.TabIndex = 39;
            this.grOPTIUNI.TabStop = false;
            this.grOPTIUNI.Text = "OPTIUNI";
            // 
            // btnOptDetinMasa
            // 
            this.btnOptDetinMasa.Font = new System.Drawing.Font("Hobo Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOptDetinMasa.Location = new System.Drawing.Point(11, 133);
            this.btnOptDetinMasa.Name = "btnOptDetinMasa";
            this.btnOptDetinMasa.Size = new System.Drawing.Size(185, 44);
            this.btnOptDetinMasa.TabIndex = 1;
            this.btnOptDetinMasa.Text = "Detin o masa";
            this.btnOptDetinMasa.UseVisualStyleBackColor = true;
            this.btnOptDetinMasa.Click += new System.EventHandler(this.btnOptDetinMasa_Click);
            // 
            // btnOptRezervare
            // 
            this.btnOptRezervare.Font = new System.Drawing.Font("Hobo Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOptRezervare.Location = new System.Drawing.Point(11, 57);
            this.btnOptRezervare.Name = "btnOptRezervare";
            this.btnOptRezervare.Size = new System.Drawing.Size(185, 44);
            this.btnOptRezervare.TabIndex = 0;
            this.btnOptRezervare.Text = "Rezervare masa";
            this.btnOptRezervare.UseVisualStyleBackColor = true;
            this.btnOptRezervare.Click += new System.EventHandler(this.btnOptRezervare_Click);
            // 
            // lblOPTMASA
            // 
            this.lblOPTMASA.AutoSize = true;
            this.lblOPTMASA.Font = new System.Drawing.Font("Hobo Std", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOPTMASA.Location = new System.Drawing.Point(1153, 134);
            this.lblOPTMASA.Name = "lblOPTMASA";
            this.lblOPTMASA.Size = new System.Drawing.Size(94, 34);
            this.lblOPTMASA.TabIndex = 40;
            this.lblOPTMASA.Text = "MASA ";
            // 
            // grModificareMeniu
            // 
            this.grModificareMeniu.Controls.Add(this.label4);
            this.grModificareMeniu.Controls.Add(this.label5);
            this.grModificareMeniu.Controls.Add(this.txtModificaPret);
            this.grModificareMeniu.Controls.Add(this.lblPRET);
            this.grModificareMeniu.Controls.Add(this.txtModificaDenumire);
            this.grModificareMeniu.Controls.Add(this.txtModificaTip);
            this.grModificareMeniu.Controls.Add(this.btnMODIFICA);
            this.grModificareMeniu.Controls.Add(this.lblDENUMIRE);
            this.grModificareMeniu.Controls.Add(this.lblTIP);
            this.grModificareMeniu.Font = new System.Drawing.Font("Hobo Std", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grModificareMeniu.Location = new System.Drawing.Point(1147, 706);
            this.grModificareMeniu.Name = "grModificareMeniu";
            this.grModificareMeniu.Size = new System.Drawing.Size(496, 290);
            this.grModificareMeniu.TabIndex = 41;
            this.grModificareMeniu.TabStop = false;
            this.grModificareMeniu.Text = "Modificare meniu";
            // 
            // btnADMIN
            // 
            this.btnADMIN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnADMIN.Font = new System.Drawing.Font("Hobo Std", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnADMIN.Location = new System.Drawing.Point(26, 25);
            this.btnADMIN.Name = "btnADMIN";
            this.btnADMIN.Size = new System.Drawing.Size(134, 39);
            this.btnADMIN.TabIndex = 42;
            this.btnADMIN.Text = "ADMIN";
            this.btnADMIN.UseVisualStyleBackColor = true;
            this.btnADMIN.Click += new System.EventHandler(this.btnADMIN_Click);
            // 
            // Client_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1844, 1007);
            this.Controls.Add(this.btnADMIN);
            this.Controls.Add(this.grModificareMeniu);
            this.Controls.Add(this.lblOPTMASA);
            this.Controls.Add(this.grOPTIUNI);
            this.Controls.Add(this.grIntroducetiCodulMesei);
            this.Controls.Add(this.grAfiseazaInfo);
            this.Controls.Add(this.grRezervareClient);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grMese);
            this.Controls.Add(this.txtNumeRestaurant);
            this.Controls.Add(this.grLocatie);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Client_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RESTAURANT \" LA CUMATRU \"";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Client_form_Closing);
            this.Load += new System.EventHandler(this.Client_form_Load);
            this.grLocatie.ResumeLayout(false);
            this.grLocatie.PerformLayout();
            this.grMese.ResumeLayout(false);
            this.grRezervareClient.ResumeLayout(false);
            this.grRezervareClient.PerformLayout();
            this.grAfiseazaInfo.ResumeLayout(false);
            this.grAfiseazaInfo.PerformLayout();
            this.grIntroducetiCodulMesei.ResumeLayout(false);
            this.grIntroducetiCodulMesei.PerformLayout();
            this.grOPTIUNI.ResumeLayout(false);
            this.grModificareMeniu.ResumeLayout(false);
            this.grModificareMeniu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtNumeRestaurant;
        private System.Windows.Forms.GroupBox grLocatie;
        private System.Windows.Forms.Button btnMasa1;
        private System.Windows.Forms.Button btnMasa2;
        private System.Windows.Forms.Button btnMasa3;
        private System.Windows.Forms.Button btnMasa4;
        private System.Windows.Forms.RadioButton rdbINTERIOR;
        private System.Windows.Forms.RadioButton rdbSEPAREU;
        private System.Windows.Forms.RadioButton rdbTERASA;
        private System.Windows.Forms.GroupBox grMese;
        private System.Windows.Forms.Label lblNUME;
        private System.Windows.Forms.Label lblPRENUME;
        private System.Windows.Forms.TextBox txtNUME;
        private System.Windows.Forms.TextBox txtPRENUME;
        private System.Windows.Forms.TextBox txtCNP;
        private System.Windows.Forms.Label lblCNP;
        private System.Windows.Forms.Button btnREZERVA;
        private System.Windows.Forms.Label lblEroareNume;
        private System.Windows.Forms.Label lblEroarePrenume;
        private System.Windows.Forms.Label lblEroareCNP;
        private System.Windows.Forms.Button btnAfiseazaInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnMODIFICA;
        private System.Windows.Forms.TextBox txtModificaPret;
        private System.Windows.Forms.Label lblPRET;
        private System.Windows.Forms.TextBox txtModificaDenumire;
        private System.Windows.Forms.TextBox txtModificaTip;
        private System.Windows.Forms.Label lblDENUMIRE;
        private System.Windows.Forms.Label lblTIP;
        private System.Windows.Forms.Button btnCOMANDA;
        private System.Windows.Forms.GroupBox grRezervareClient;
        private System.Windows.Forms.GroupBox grAfiseazaInfo;
        private System.Windows.Forms.Label lblGetPret;
        private System.Windows.Forms.Label lblGetDenumire;
        private System.Windows.Forms.Label lblGetTip;
        private System.Windows.Forms.Label lblTotalPlata_Bon;
        private System.Windows.Forms.GroupBox grIntroducetiCodulMesei;
        private System.Windows.Forms.TextBox txtCodUnic;
        private System.Windows.Forms.Label lblEroareCOD;
        private System.Windows.Forms.GroupBox grOPTIUNI;
        private System.Windows.Forms.Button btnOptDetinMasa;
        private System.Windows.Forms.Button btnOptRezervare;
        private System.Windows.Forms.Label lblOPTMASA;
        private System.Windows.Forms.Button btnCodGata;
        private System.Windows.Forms.ListBox lstAfisareInfo;
        private System.Windows.Forms.GroupBox grModificareMeniu;
        private System.Windows.Forms.Label lblPretTotal;
        private System.Windows.Forms.RadioButton rdbANULEAZA;
        private System.Windows.Forms.Button btnADMIN;
    }
}

