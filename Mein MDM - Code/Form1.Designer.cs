namespace PersonData
{
    partial class PersonForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonForm));
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbStrasse = new System.Windows.Forms.TextBox();
            this.tbHausnummer = new System.Windows.Forms.TextBox();
            this.tbPLZ = new System.Windows.Forms.TextBox();
            this.tbOrt = new System.Windows.Forms.TextBox();
            this.tbGeburt = new System.Windows.Forms.TextBox();
            this.tbTelefon = new System.Windows.Forms.TextBox();
            this.cbLand = new System.Windows.Forms.ComboBox();
            this.lbPerson = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbNotes = new System.Windows.Forms.TextBox();
            this.cbFirma = new System.Windows.Forms.ComboBox();
            this.tbBegriff = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClearSuche = new System.Windows.Forms.Button();
            this.btnSuche = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmsPerson = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.öffnenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.löschenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wirklichLöschenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jetztLöschenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsComboBox = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eintragLöschenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wirklichLöschenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.jetztLöschenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.linkGithub = new System.Windows.Forms.LinkLabel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cmsPerson.SuspendLayout();
            this.cmsComboBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(100, 19);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(133, 20);
            this.tbFirstName.TabIndex = 0;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(242, 19);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(133, 20);
            this.tbLastName.TabIndex = 1;
            // 
            // tbStrasse
            // 
            this.tbStrasse.Location = new System.Drawing.Point(100, 45);
            this.tbStrasse.Name = "tbStrasse";
            this.tbStrasse.Size = new System.Drawing.Size(133, 20);
            this.tbStrasse.TabIndex = 2;
            // 
            // tbHausnummer
            // 
            this.tbHausnummer.Location = new System.Drawing.Point(242, 45);
            this.tbHausnummer.Name = "tbHausnummer";
            this.tbHausnummer.Size = new System.Drawing.Size(46, 20);
            this.tbHausnummer.TabIndex = 3;
            // 
            // tbPLZ
            // 
            this.tbPLZ.Location = new System.Drawing.Point(100, 71);
            this.tbPLZ.Name = "tbPLZ";
            this.tbPLZ.Size = new System.Drawing.Size(70, 20);
            this.tbPLZ.TabIndex = 4;
            // 
            // tbOrt
            // 
            this.tbOrt.Location = new System.Drawing.Point(176, 71);
            this.tbOrt.Name = "tbOrt";
            this.tbOrt.Size = new System.Drawing.Size(112, 20);
            this.tbOrt.TabIndex = 5;
            // 
            // tbGeburt
            // 
            this.tbGeburt.Location = new System.Drawing.Point(100, 124);
            this.tbGeburt.Name = "tbGeburt";
            this.tbGeburt.Size = new System.Drawing.Size(100, 20);
            this.tbGeburt.TabIndex = 7;
            // 
            // tbTelefon
            // 
            this.tbTelefon.Location = new System.Drawing.Point(100, 150);
            this.tbTelefon.Name = "tbTelefon";
            this.tbTelefon.Size = new System.Drawing.Size(125, 20);
            this.tbTelefon.TabIndex = 8;
            // 
            // cbLand
            // 
            this.cbLand.FormattingEnabled = true;
            this.cbLand.Items.AddRange(new object[] {
            "DEUTSCHLAND",
            "PORTUGAL"});
            this.cbLand.Location = new System.Drawing.Point(100, 97);
            this.cbLand.Name = "cbLand";
            this.cbLand.Size = new System.Drawing.Size(188, 21);
            this.cbLand.TabIndex = 6;
            this.cbLand.Text = "DEUTSCHLAND";
            this.cbLand.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cbLand_MouseDown);
            // 
            // lbPerson
            // 
            this.lbPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPerson.FormattingEnabled = true;
            this.lbPerson.HorizontalScrollbar = true;
            this.lbPerson.ItemHeight = 16;
            this.lbPerson.Location = new System.Drawing.Point(400, 96);
            this.lbPerson.Name = "lbPerson";
            this.lbPerson.Size = new System.Drawing.Size(203, 212);
            this.lbPerson.TabIndex = 12;
            this.lbPerson.DoubleClick += new System.EventHandler(this.lbPerson_DoubleClick);
            this.lbPerson.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbPerson_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Vor- Nachname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Straße, Nr.:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "PLZ, Ort:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Land:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Geburtsdatum:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Tel. Nr.:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Firma:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Bemerkung:";
            // 
            // tbNotes
            // 
            this.tbNotes.Location = new System.Drawing.Point(100, 203);
            this.tbNotes.Multiline = true;
            this.tbNotes.Name = "tbNotes";
            this.tbNotes.Size = new System.Drawing.Size(188, 105);
            this.tbNotes.TabIndex = 10;
            // 
            // cbFirma
            // 
            this.cbFirma.FormattingEnabled = true;
            this.cbFirma.Items.AddRange(new object[] {
            "Buchner IT",
            "IT Pfau",
            "Sanders"});
            this.cbFirma.Location = new System.Drawing.Point(100, 176);
            this.cbFirma.Name = "cbFirma";
            this.cbFirma.Size = new System.Drawing.Size(188, 21);
            this.cbFirma.TabIndex = 9;
            this.cbFirma.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cbFirma_MouseDown);
            // 
            // tbBegriff
            // 
            this.tbBegriff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBegriff.Location = new System.Drawing.Point(400, 53);
            this.tbBegriff.Name = "tbBegriff";
            this.tbBegriff.Size = new System.Drawing.Size(135, 26);
            this.tbBegriff.TabIndex = 17;
            this.toolTip1.SetToolTip(this.tbBegriff, "Suchbegriff eingeben");
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackgroundImage = global::PersonData.Properties.Resources.update;
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpdate.Location = new System.Drawing.Point(351, 268);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(40, 40);
            this.btnUpdate.TabIndex = 31;
            this.btnUpdate.TabStop = false;
            this.toolTip1.SetToolTip(this.btnUpdate, "Aktualisieren");
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClearSuche
            // 
            this.btnClearSuche.BackgroundImage = global::PersonData.Properties.Resources.cancel;
            this.btnClearSuche.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClearSuche.Location = new System.Drawing.Point(573, 51);
            this.btnClearSuche.Name = "btnClearSuche";
            this.btnClearSuche.Size = new System.Drawing.Size(30, 30);
            this.btnClearSuche.TabIndex = 19;
            this.toolTip1.SetToolTip(this.btnClearSuche, "Zurücksetzen");
            this.btnClearSuche.UseVisualStyleBackColor = true;
            this.btnClearSuche.Click += new System.EventHandler(this.btnClearSuche_Click_1);
            // 
            // btnSuche
            // 
            this.btnSuche.BackgroundImage = global::PersonData.Properties.Resources.search;
            this.btnSuche.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSuche.Location = new System.Drawing.Point(541, 51);
            this.btnSuche.Name = "btnSuche";
            this.btnSuche.Size = new System.Drawing.Size(30, 30);
            this.btnSuche.TabIndex = 18;
            this.toolTip1.SetToolTip(this.btnSuche, "Suchen");
            this.btnSuche.UseVisualStyleBackColor = true;
            this.btnSuche.Click += new System.EventHandler(this.btnSuche_Click_1);
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = global::PersonData.Properties.Resources.add;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdd.Location = new System.Drawing.Point(297, 268);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(40, 40);
            this.btnAdd.TabIndex = 11;
            this.toolTip1.SetToolTip(this.btnAdd, "Speichern");
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // cmsPerson
            // 
            this.cmsPerson.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öffnenToolStripMenuItem,
            this.löschenToolStripMenuItem});
            this.cmsPerson.Name = "personMenu";
            this.cmsPerson.Size = new System.Drawing.Size(177, 48);
            // 
            // öffnenToolStripMenuItem
            // 
            this.öffnenToolStripMenuItem.Name = "öffnenToolStripMenuItem";
            this.öffnenToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.öffnenToolStripMenuItem.Text = "öffnen / bearbeiten";
            this.öffnenToolStripMenuItem.Click += new System.EventHandler(this.öffnenToolStripMenuItem_Click);
            // 
            // löschenToolStripMenuItem
            // 
            this.löschenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wirklichLöschenToolStripMenuItem});
            this.löschenToolStripMenuItem.Name = "löschenToolStripMenuItem";
            this.löschenToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.löschenToolStripMenuItem.Text = "löschen";
            // 
            // wirklichLöschenToolStripMenuItem
            // 
            this.wirklichLöschenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jetztLöschenToolStripMenuItem});
            this.wirklichLöschenToolStripMenuItem.Name = "wirklichLöschenToolStripMenuItem";
            this.wirklichLöschenToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.wirklichLöschenToolStripMenuItem.Text = "wirklich löschen?";
            // 
            // jetztLöschenToolStripMenuItem
            // 
            this.jetztLöschenToolStripMenuItem.Name = "jetztLöschenToolStripMenuItem";
            this.jetztLöschenToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.jetztLöschenToolStripMenuItem.Text = "jetzt löschen.";
            this.jetztLöschenToolStripMenuItem.Click += new System.EventHandler(this.jetztLöschenToolStripMenuItem_Click);
            // 
            // cmsComboBox
            // 
            this.cmsComboBox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eintragLöschenToolStripMenuItem});
            this.cmsComboBox.Name = "cmsComboBox";
            this.cmsComboBox.Size = new System.Drawing.Size(156, 26);
            // 
            // eintragLöschenToolStripMenuItem
            // 
            this.eintragLöschenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wirklichLöschenToolStripMenuItem1});
            this.eintragLöschenToolStripMenuItem.Name = "eintragLöschenToolStripMenuItem";
            this.eintragLöschenToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.eintragLöschenToolStripMenuItem.Text = "Eintrag löschen";
            // 
            // wirklichLöschenToolStripMenuItem1
            // 
            this.wirklichLöschenToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jetztLöschenToolStripMenuItem1});
            this.wirklichLöschenToolStripMenuItem1.Name = "wirklichLöschenToolStripMenuItem1";
            this.wirklichLöschenToolStripMenuItem1.Size = new System.Drawing.Size(164, 22);
            this.wirklichLöschenToolStripMenuItem1.Text = "wirklich löschen?";
            // 
            // jetztLöschenToolStripMenuItem1
            // 
            this.jetztLöschenToolStripMenuItem1.Name = "jetztLöschenToolStripMenuItem1";
            this.jetztLöschenToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.jetztLöschenToolStripMenuItem1.Text = "Jetzt löschen.";
            this.jetztLöschenToolStripMenuItem1.Click += new System.EventHandler(this.jetztLöschenToolStripMenuItem1_Click);
            // 
            // linkGithub
            // 
            this.linkGithub.AutoSize = true;
            this.linkGithub.Font = new System.Drawing.Font("Consolas", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkGithub.Location = new System.Drawing.Point(12, 309);
            this.linkGithub.Name = "linkGithub";
            this.linkGithub.Size = new System.Drawing.Size(29, 9);
            this.linkGithub.TabIndex = 33;
            this.linkGithub.TabStop = true;
            this.linkGithub.Text = "GitHub";
            this.linkGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkGithub_LinkClicked);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(376, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 18);
            this.label9.TabIndex = 34;
            this.label9.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(289, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 18);
            this.label10.TabIndex = 35;
            this.label10.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(289, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 18);
            this.label11.TabIndex = 36;
            this.label11.Text = "*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(289, 94);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(14, 18);
            this.label12.TabIndex = 37;
            this.label12.Text = "*";
            // 
            // PersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(625, 327);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.linkGithub);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClearSuche);
            this.Controls.Add(this.btnSuche);
            this.Controls.Add(this.tbBegriff);
            this.Controls.Add(this.cbFirma);
            this.Controls.Add(this.tbNotes);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbPerson);
            this.Controls.Add(this.cbLand);
            this.Controls.Add(this.tbTelefon);
            this.Controls.Add(this.tbGeburt);
            this.Controls.Add(this.tbOrt);
            this.Controls.Add(this.tbPLZ);
            this.Controls.Add(this.tbHausnummer);
            this.Controls.Add(this.tbStrasse);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbFirstName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PersonForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stammdaten";
            this.cmsPerson.ResumeLayout(false);
            this.cmsComboBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbFirma;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbBegriff;
        private System.Windows.Forms.Button btnSuche;
        private System.Windows.Forms.Button btnClearSuche;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ContextMenuStrip cmsPerson;
        private System.Windows.Forms.ToolStripMenuItem öffnenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem löschenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wirklichLöschenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jetztLöschenToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsComboBox;
        private System.Windows.Forms.ToolStripMenuItem eintragLöschenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wirklichLöschenToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem jetztLöschenToolStripMenuItem1;
        private System.Windows.Forms.LinkLabel linkGithub;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        //private System.Windows.Forms.TextBox tbNotes;
        //private System.Windows.Forms.ComboBox cbFirma;

        //private System.Windows.Forms.Button btnShow;

        #endregion
        /*
        private System.Windows.Forms.TextBox tbFirstname;
        private System.Windows.Forms.TextBox tbLastname;
        private System.Windows.Forms.TextBox tbStrasse;
        private System.Windows.Forms.TextBox tbHausnummer;
        private System.Windows.Forms.TextBox tbPLZ;
        private System.Windows.Forms.TextBox tbOrt;
        private System.Windows.Forms.TextBox tbGeburt;
        private System.Windows.Forms.ComboBox cbFirma;
        private System.Windows.Forms.TextBox tbTelefon;
        private System.Windows.Forms.ComboBox cbLand;
        private System.Windows.Forms.ListBox lbPerson;
        private System.Windows.Forms.Button btnAdd;
        */
    }
}

