
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
            this.btnAfiseazaMeniu = new System.Windows.Forms.Button();
            this.lstMeniu = new System.Windows.Forms.ListBox();
            this.lblModificareMeniu = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnMODIFICA = new System.Windows.Forms.Button();
            this.txtPret = new System.Windows.Forms.TextBox();
            this.lblPRET = new System.Windows.Forms.Label();
            this.txtDenumire = new System.Windows.Forms.TextBox();
            this.txtTip = new System.Windows.Forms.TextBox();
            this.lblDENUMIRE = new System.Windows.Forms.Label();
            this.lblTIP = new System.Windows.Forms.Label();
            this.btnCOMANDA = new System.Windows.Forms.Button();
            this.grRezervareClient = new System.Windows.Forms.GroupBox();
            this.grMeniu = new System.Windows.Forms.GroupBox();
            this.grLocatie.SuspendLayout();
            this.grMese.SuspendLayout();
            this.grRezervareClient.SuspendLayout();
            this.grMeniu.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNumeRestaurant
            // 
            this.txtNumeRestaurant.AutoSize = true;
            this.txtNumeRestaurant.Font = new System.Drawing.Font("Showcard Gothic", 30F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtNumeRestaurant.Location = new System.Drawing.Point(327, 20);
            this.txtNumeRestaurant.Name = "txtNumeRestaurant";
            this.txtNumeRestaurant.Size = new System.Drawing.Size(522, 124);
            this.txtNumeRestaurant.TabIndex = 0;
            this.txtNumeRestaurant.Text = "RESTAURANT \r\n             \" LA CUMATRU \"";
            // 
            // grLocatie
            // 
            this.grLocatie.Controls.Add(this.rdbTERASA);
            this.grLocatie.Controls.Add(this.rdbSEPAREU);
            this.grLocatie.Controls.Add(this.rdbINTERIOR);
            this.grLocatie.Font = new System.Drawing.Font("Hobo Std", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grLocatie.Location = new System.Drawing.Point(86, 180);
            this.grLocatie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grLocatie.Name = "grLocatie";
            this.grLocatie.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grLocatie.Size = new System.Drawing.Size(208, 222);
            this.grLocatie.TabIndex = 1;
            this.grLocatie.TabStop = false;
            this.grLocatie.Text = "Alege locatia";
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
            this.rdbTERASA.CheckedChanged += new System.EventHandler(this.Locatie_Click);
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
            this.rdbSEPAREU.CheckedChanged += new System.EventHandler(this.Locatie_Click);
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
            this.rdbINTERIOR.CheckedChanged += new System.EventHandler(this.Locatie_Click);
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
            this.grMese.Location = new System.Drawing.Point(389, 180);
            this.grMese.Name = "grMese";
            this.grMese.Size = new System.Drawing.Size(715, 222);
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
            this.lblEroareNume.Size = new System.Drawing.Size(15, 20);
            this.lblEroareNume.TabIndex = 18;
            this.lblEroareNume.Text = "*";
            // 
            // lblEroarePrenume
            // 
            this.lblEroarePrenume.AutoSize = true;
            this.lblEroarePrenume.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEroarePrenume.ForeColor = System.Drawing.Color.Transparent;
            this.lblEroarePrenume.Location = new System.Drawing.Point(172, 212);
            this.lblEroarePrenume.Name = "lblEroarePrenume";
            this.lblEroarePrenume.Size = new System.Drawing.Size(15, 20);
            this.lblEroarePrenume.TabIndex = 19;
            this.lblEroarePrenume.Text = "*";
            // 
            // lblEroareCNP
            // 
            this.lblEroareCNP.AutoSize = true;
            this.lblEroareCNP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEroareCNP.ForeColor = System.Drawing.Color.Transparent;
            this.lblEroareCNP.Location = new System.Drawing.Point(172, 314);
            this.lblEroareCNP.Name = "lblEroareCNP";
            this.lblEroareCNP.Size = new System.Drawing.Size(15, 20);
            this.lblEroareCNP.TabIndex = 20;
            this.lblEroareCNP.Text = "*";
            // 
            // btnAfiseazaMeniu
            // 
            this.btnAfiseazaMeniu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAfiseazaMeniu.Font = new System.Drawing.Font("Hobo Std", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAfiseazaMeniu.Location = new System.Drawing.Point(23, 67);
            this.btnAfiseazaMeniu.Name = "btnAfiseazaMeniu";
            this.btnAfiseazaMeniu.Size = new System.Drawing.Size(134, 39);
            this.btnAfiseazaMeniu.TabIndex = 22;
            this.btnAfiseazaMeniu.Text = "AFISEAZA";
            this.btnAfiseazaMeniu.UseVisualStyleBackColor = true;
            this.btnAfiseazaMeniu.Click += new System.EventHandler(this.btnAfiseazaMeniu_Click);
            // 
            // lstMeniu
            // 
            this.lstMeniu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstMeniu.FormattingEnabled = true;
            this.lstMeniu.ItemHeight = 20;
            this.lstMeniu.Location = new System.Drawing.Point(203, 45);
            this.lstMeniu.Name = "lstMeniu";
            this.lstMeniu.Size = new System.Drawing.Size(411, 424);
            this.lstMeniu.TabIndex = 24;
            this.lstMeniu.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChanged);
            // 
            // lblModificareMeniu
            // 
            this.lblModificareMeniu.AutoSize = true;
            this.lblModificareMeniu.Font = new System.Drawing.Font("Hobo Std", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblModificareMeniu.Location = new System.Drawing.Point(1332, 55);
            this.lblModificareMeniu.Name = "lblModificareMeniu";
            this.lblModificareMeniu.Size = new System.Drawing.Size(212, 34);
            this.lblModificareMeniu.TabIndex = 35;
            this.lblModificareMeniu.Text = "Modificare meniu";
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
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(1487, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(1487, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 20);
            this.label5.TabIndex = 32;
            this.label5.Text = "*";
            // 
            // btnMODIFICA
            // 
            this.btnMODIFICA.Font = new System.Drawing.Font("Hobo Std", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMODIFICA.Location = new System.Drawing.Point(1487, 318);
            this.btnMODIFICA.Name = "btnMODIFICA";
            this.btnMODIFICA.Size = new System.Drawing.Size(134, 39);
            this.btnMODIFICA.TabIndex = 31;
            this.btnMODIFICA.Text = "MODIFICA";
            this.btnMODIFICA.UseVisualStyleBackColor = true;
            this.btnMODIFICA.Click += new System.EventHandler(this.btnMODIFICA_Click);
            // 
            // txtPret
            // 
            this.txtPret.Location = new System.Drawing.Point(1487, 242);
            this.txtPret.Name = "txtPret";
            this.txtPret.PlaceholderText = " Pret produs";
            this.txtPret.Size = new System.Drawing.Size(284, 27);
            this.txtPret.TabIndex = 30;
            // 
            // lblPRET
            // 
            this.lblPRET.AutoSize = true;
            this.lblPRET.Font = new System.Drawing.Font("Hobo Std", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPRET.Location = new System.Drawing.Point(1332, 242);
            this.lblPRET.Name = "lblPRET";
            this.lblPRET.Size = new System.Drawing.Size(79, 34);
            this.lblPRET.TabIndex = 29;
            this.lblPRET.Text = "PRET";
            // 
            // txtDenumire
            // 
            this.txtDenumire.Location = new System.Drawing.Point(1487, 174);
            this.txtDenumire.Name = "txtDenumire";
            this.txtDenumire.PlaceholderText = " Nume produs...";
            this.txtDenumire.Size = new System.Drawing.Size(284, 27);
            this.txtDenumire.TabIndex = 28;
            // 
            // txtTip
            // 
            this.txtTip.Location = new System.Drawing.Point(1487, 106);
            this.txtTip.Name = "txtTip";
            this.txtTip.PlaceholderText = " Tip produs...";
            this.txtTip.Size = new System.Drawing.Size(284, 27);
            this.txtTip.TabIndex = 27;
            // 
            // lblDENUMIRE
            // 
            this.lblDENUMIRE.AutoSize = true;
            this.lblDENUMIRE.Font = new System.Drawing.Font("Hobo Std", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDENUMIRE.Location = new System.Drawing.Point(1332, 174);
            this.lblDENUMIRE.Name = "lblDENUMIRE";
            this.lblDENUMIRE.Size = new System.Drawing.Size(143, 34);
            this.lblDENUMIRE.TabIndex = 26;
            this.lblDENUMIRE.Text = "DENUMIRE";
            // 
            // lblTIP
            // 
            this.lblTIP.AutoSize = true;
            this.lblTIP.Font = new System.Drawing.Font("Hobo Std", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTIP.Location = new System.Drawing.Point(1332, 106);
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
            this.grRezervareClient.Location = new System.Drawing.Point(98, 470);
            this.grRezervareClient.Name = "grRezervareClient";
            this.grRezervareClient.Size = new System.Drawing.Size(480, 496);
            this.grRezervareClient.TabIndex = 37;
            this.grRezervareClient.TabStop = false;
            this.grRezervareClient.Text = "Rezervare la masa";
            // 
            // grMeniu
            // 
            this.grMeniu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grMeniu.Controls.Add(this.lstMeniu);
            this.grMeniu.Controls.Add(this.btnAfiseazaMeniu);
            this.grMeniu.Controls.Add(this.btnCOMANDA);
            this.grMeniu.Font = new System.Drawing.Font("Hobo Std", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grMeniu.Location = new System.Drawing.Point(628, 470);
            this.grMeniu.Name = "grMeniu";
            this.grMeniu.Size = new System.Drawing.Size(645, 496);
            this.grMeniu.TabIndex = 21;
            this.grMeniu.TabStop = false;
            this.grMeniu.Text = "Meniu";
            // 
            // Client_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1844, 994);
            this.Controls.Add(this.grMeniu);
            this.Controls.Add(this.grRezervareClient);
            this.Controls.Add(this.lblModificareMeniu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnMODIFICA);
            this.Controls.Add(this.txtPret);
            this.Controls.Add(this.lblPRET);
            this.Controls.Add(this.txtDenumire);
            this.Controls.Add(this.txtTip);
            this.Controls.Add(this.lblDENUMIRE);
            this.Controls.Add(this.lblTIP);
            this.Controls.Add(this.grMese);
            this.Controls.Add(this.grLocatie);
            this.Controls.Add(this.txtNumeRestaurant);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Client_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RESTAURANT \" LA CUMATRU \"";
            this.Load += new System.EventHandler(this.Client_form_Load);
            this.grLocatie.ResumeLayout(false);
            this.grLocatie.PerformLayout();
            this.grMese.ResumeLayout(false);
            this.grRezervareClient.ResumeLayout(false);
            this.grRezervareClient.PerformLayout();
            this.grMeniu.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnAfiseazaMeniu;
        private System.Windows.Forms.ListBox lstMeniu;
        private System.Windows.Forms.Label lblModificareMeniu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnMODIFICA;
        private System.Windows.Forms.TextBox txtPret;
        private System.Windows.Forms.Label lblPRET;
        private System.Windows.Forms.TextBox txtDenumire;
        private System.Windows.Forms.TextBox txtTip;
        private System.Windows.Forms.Label lblDENUMIRE;
        private System.Windows.Forms.Label lblTIP;
        private System.Windows.Forms.Button btnCOMANDA;
        private System.Windows.Forms.GroupBox grRezervareClient;
        private System.Windows.Forms.GroupBox grMeniu;
    }
}

