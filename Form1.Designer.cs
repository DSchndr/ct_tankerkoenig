
namespace Tankerkönig
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.comboBoxSort = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBarRad = new System.Windows.Forms.TrackBar();
            this.buttonMap = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.radioButtonPLZ = new System.Windows.Forms.RadioButton();
            this.radioButtonKoord = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Breitengrad = new System.Windows.Forms.TextBox();
            this.Laengengrad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.RadiusLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.buttonRemoveFromFav = new System.Windows.Forms.Button();
            this.buttonAddToFav = new System.Windows.Forms.Button();
            this.dataGridViewFav = new System.Windows.Forms.DataGridView();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.trackBarAktTime = new System.Windows.Forms.TrackBar();
            this.checkBoxAktualisieren = new System.Windows.Forms.CheckBox();
            this.labelAktTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRad)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFav)).BeginInit();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAktTime)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Aktualisieren";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(10, 43);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(114, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Use Dev API Keys";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 174);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1196, 224);
            this.dataGridView1.StandardTab = true;
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Typ";
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(62, 16);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(137, 21);
            this.comboBoxType.TabIndex = 4;
            // 
            // comboBoxSort
            // 
            this.comboBoxSort.FormattingEnabled = true;
            this.comboBoxSort.Location = new System.Drawing.Point(62, 40);
            this.comboBoxSort.Name = "comboBoxSort";
            this.comboBoxSort.Size = new System.Drawing.Size(137, 21);
            this.comboBoxSort.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sortierung";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Radius";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // trackBarRad
            // 
            this.trackBarRad.Location = new System.Drawing.Point(62, 67);
            this.trackBarRad.Maximum = 250;
            this.trackBarRad.Minimum = 10;
            this.trackBarRad.Name = "trackBarRad";
            this.trackBarRad.Size = new System.Drawing.Size(137, 45);
            this.trackBarRad.SmallChange = 10;
            this.trackBarRad.TabIndex = 8;
            this.trackBarRad.Value = 100;
            this.trackBarRad.Scroll += new System.EventHandler(this.trackBarRad_Scroll);
            // 
            // buttonMap
            // 
            this.buttonMap.Location = new System.Drawing.Point(90, 110);
            this.buttonMap.Name = "buttonMap";
            this.buttonMap.Size = new System.Drawing.Size(121, 23);
            this.buttonMap.TabIndex = 9;
            this.buttonMap.Text = "Auf Karte anzeigen";
            this.buttonMap.UseVisualStyleBackColor = true;
            this.buttonMap.Click += new System.EventHandler(this.buttonMap_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.RadiusLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonMap);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.trackBarRad);
            this.groupBox1.Controls.Add(this.comboBoxType);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBoxSort);
            this.groupBox1.Location = new System.Drawing.Point(14, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(612, 147);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sucheinstellungen";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.radioButtonPLZ);
            this.groupBox5.Controls.Add(this.radioButtonKoord);
            this.groupBox5.Location = new System.Drawing.Point(408, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(184, 69);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Suche anhand von";
            // 
            // radioButtonPLZ
            // 
            this.radioButtonPLZ.AutoSize = true;
            this.radioButtonPLZ.Location = new System.Drawing.Point(9, 44);
            this.radioButtonPLZ.Name = "radioButtonPLZ";
            this.radioButtonPLZ.Size = new System.Drawing.Size(78, 17);
            this.radioButtonPLZ.TabIndex = 1;
            this.radioButtonPLZ.Text = "Postleitzahl";
            this.radioButtonPLZ.UseVisualStyleBackColor = true;
            // 
            // radioButtonKoord
            // 
            this.radioButtonKoord.AutoSize = true;
            this.radioButtonKoord.Checked = true;
            this.radioButtonKoord.Location = new System.Drawing.Point(9, 20);
            this.radioButtonKoord.Name = "radioButtonKoord";
            this.radioButtonKoord.Size = new System.Drawing.Size(82, 17);
            this.radioButtonKoord.TabIndex = 0;
            this.radioButtonKoord.TabStop = true;
            this.radioButtonKoord.Text = "Koordinaten";
            this.radioButtonKoord.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox2);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Enabled = false;
            this.groupBox4.Location = new System.Drawing.Point(218, 90);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(184, 43);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ortssuche";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(74, 14);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Postleitzahl";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Breitengrad);
            this.groupBox3.Controls.Add(this.Laengengrad);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(218, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(184, 68);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Koordinatensuche";
            // 
            // Breitengrad
            // 
            this.Breitengrad.Location = new System.Drawing.Point(77, 41);
            this.Breitengrad.Name = "Breitengrad";
            this.Breitengrad.Size = new System.Drawing.Size(100, 20);
            this.Breitengrad.TabIndex = 14;
            // 
            // Laengengrad
            // 
            this.Laengengrad.Location = new System.Drawing.Point(76, 14);
            this.Laengengrad.Name = "Laengengrad";
            this.Laengengrad.Size = new System.Drawing.Size(100, 20);
            this.Laengengrad.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Breitengrad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Längengrad";
            // 
            // RadiusLabel
            // 
            this.RadiusLabel.AutoSize = true;
            this.RadiusLabel.Location = new System.Drawing.Point(11, 87);
            this.RadiusLabel.Name = "RadiusLabel";
            this.RadiusLabel.Size = new System.Drawing.Size(41, 13);
            this.RadiusLabel.TabIndex = 10;
            this.RadiusLabel.Text = "?.? KM";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Location = new System.Drawing.Point(1040, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(168, 101);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "API-Werte";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(10, 66);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Aktualisieren";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "API Key:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(60, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.buttonRemoveFromFav);
            this.groupBox6.Controls.Add(this.buttonAddToFav);
            this.groupBox6.Controls.Add(this.dataGridViewFav);
            this.groupBox6.Location = new System.Drawing.Point(14, 404);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(1194, 244);
            this.groupBox6.TabIndex = 12;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Favoriten";
            // 
            // buttonRemoveFromFav
            // 
            this.buttonRemoveFromFav.Location = new System.Drawing.Point(148, 13);
            this.buttonRemoveFromFav.Name = "buttonRemoveFromFav";
            this.buttonRemoveFromFav.Size = new System.Drawing.Size(135, 23);
            this.buttonRemoveFromFav.TabIndex = 2;
            this.buttonRemoveFromFav.Text = "Von Favoriten Entfernen";
            this.buttonRemoveFromFav.UseVisualStyleBackColor = true;
            this.buttonRemoveFromFav.Click += new System.EventHandler(this.buttonRemoveFromFav_Click);
            // 
            // buttonAddToFav
            // 
            this.buttonAddToFav.Location = new System.Drawing.Point(7, 13);
            this.buttonAddToFav.Name = "buttonAddToFav";
            this.buttonAddToFav.Size = new System.Drawing.Size(135, 23);
            this.buttonAddToFav.TabIndex = 1;
            this.buttonAddToFav.Text = "Zu Favoriten Hinzufügen";
            this.buttonAddToFav.UseVisualStyleBackColor = true;
            this.buttonAddToFav.Click += new System.EventHandler(this.buttonAddToFav_Click);
            // 
            // dataGridViewFav
            // 
            this.dataGridViewFav.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFav.Location = new System.Drawing.Point(6, 42);
            this.dataGridViewFav.Name = "dataGridViewFav";
            this.dataGridViewFav.Size = new System.Drawing.Size(1182, 196);
            this.dataGridViewFav.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.labelAktTime);
            this.groupBox7.Controls.Add(this.checkBoxAktualisieren);
            this.groupBox7.Controls.Add(this.trackBarAktTime);
            this.groupBox7.Location = new System.Drawing.Point(633, 13);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(174, 146);
            this.groupBox7.TabIndex = 13;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Aktualisierung";
            // 
            // trackBarAktTime
            // 
            this.trackBarAktTime.Location = new System.Drawing.Point(7, 43);
            this.trackBarAktTime.Maximum = 60;
            this.trackBarAktTime.Minimum = 5;
            this.trackBarAktTime.Name = "trackBarAktTime";
            this.trackBarAktTime.Size = new System.Drawing.Size(159, 45);
            this.trackBarAktTime.TabIndex = 0;
            this.trackBarAktTime.Value = 5;
            this.trackBarAktTime.Scroll += new System.EventHandler(this.trackBarAktTime_Scroll);
            // 
            // checkBoxAktualisieren
            // 
            this.checkBoxAktualisieren.AutoSize = true;
            this.checkBoxAktualisieren.Location = new System.Drawing.Point(7, 20);
            this.checkBoxAktualisieren.Name = "checkBoxAktualisieren";
            this.checkBoxAktualisieren.Size = new System.Drawing.Size(159, 17);
            this.checkBoxAktualisieren.TabIndex = 1;
            this.checkBoxAktualisieren.Text = "Automatische Aktualisierung";
            this.checkBoxAktualisieren.UseVisualStyleBackColor = true;
            this.checkBoxAktualisieren.CheckedChanged += new System.EventHandler(this.checkBoxAktualisieren_CheckedChanged);
            // 
            // labelAktTime
            // 
            this.labelAktTime.AutoSize = true;
            this.labelAktTime.Location = new System.Drawing.Point(49, 86);
            this.labelAktTime.Name = "labelAktTime";
            this.labelAktTime.Size = new System.Drawing.Size(78, 13);
            this.labelAktTime.TabIndex = 2;
            this.labelAktTime.Text = "Alle xx Minuten";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 658);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRad)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFav)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAktTime)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.ComboBox comboBoxSort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackBarRad;
        private System.Windows.Forms.Button buttonMap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label RadiusLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox Breitengrad;
        private System.Windows.Forms.TextBox Laengengrad;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton radioButtonPLZ;
        private System.Windows.Forms.RadioButton radioButtonKoord;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button buttonRemoveFromFav;
        private System.Windows.Forms.Button buttonAddToFav;
        private System.Windows.Forms.DataGridView dataGridViewFav;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label labelAktTime;
        private System.Windows.Forms.CheckBox checkBoxAktualisieren;
        private System.Windows.Forms.TrackBar trackBarAktTime;
    }
}

