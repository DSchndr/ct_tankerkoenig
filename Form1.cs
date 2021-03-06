using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Tankerkönig
{
    public partial class Form1 : Form
    {
        Steuerung dieSteuerung;
        System.Timers.Timer aktTimer = new System.Timers.Timer();

        public Form1()
        {
            InitializeComponent();
            dieSteuerung = new Steuerung(this);
            GUIInit();
            InitTimer();
        }

        private void InitTimer()
        {
            aktTimer.Elapsed += new ElapsedEventHandler(aktTimerEvent);
            aktTimer.AutoReset = true;
            aktTimer.Interval = getTrackBarAktTime();
            aktTimer.SynchronizingObject = this;
        }

        //GUI Elemente initialisieren
        private void GUIInit()
        {
            dataGridView1.AutoGenerateColumns = true;

            comboBoxType.Items.Add("all");
            comboBoxType.Items.Add("diesel");
            comboBoxType.Items.Add("e10");
            comboBoxType.Items.Add("e5");
            comboBoxType.SelectedIndex = 0;

            comboBoxSort.Items.Add("price");
            comboBoxSort.Items.Add("dist");
            comboBoxSort.SelectedIndex = 0;

            setRadiusLabel();
            setAktLabel();
            Laengengrad.Text = "13.438";
            Breitengrad.Text = "52.521";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dieSteuerung.AktualisiereTable();
        }

        private void buttonMap_Click(object sender, EventArgs e)
        {
            dieSteuerung.ShowMapForSelectedTanke();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public double getRadius()
        {
            return Convert.ToDouble(trackBarRad.Value) / 10;
        }

        public string getType()
        {
            return comboBoxType.Text;
        }
        public string getSort()
        {
            return comboBoxSort.Text;
        }
        public double getLaengengrad()
        {
            return Convert.ToDouble(Laengengrad.Text.Replace(".", ","));
        }

        public double getBreitengrad()
        {
            return Convert.ToDouble(Breitengrad.Text.Replace(".",","));
        }

        public DataGridView getTable()
        {
            return dataGridView1;
        }

        public DataGridView getFavTable()
        {
            return dataGridViewFav;
        }

        public void setTableDataSource(object pDataSource) //obsolet
        {
            dataGridView1.DataSource = pDataSource;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void trackBarRad_Scroll(object sender, EventArgs e)
        {
            setRadiusLabel();
        }

        private void setRadiusLabel()
        {
            RadiusLabel.Text = $"{Convert.ToDouble(trackBarRad.Value) / 10} KM";
        }

        private void buttonAddToFav_Click(object sender, EventArgs e)
        {
            dieSteuerung.AddToFav();
        }

        private void buttonRemoveFromFav_Click(object sender, EventArgs e)
        {
            dieSteuerung.RemoveFromFav();
        }

        private void checkBoxAktualisieren_CheckedChanged(object sender, EventArgs e)
        {
            setAktualisieren(checkBoxAktualisieren.Checked);
        }

        private void setAktLabel()
        {
            labelAktTime.Text = $"Alle {trackBarAktTime.Value} Minuten";
        }

        private void trackBarAktTime_Scroll(object sender, EventArgs e)
        {
            setAktLabel();
            NewAktTime();
        }
        public int getTrackBarAktTime()
        {
            return trackBarAktTime.Value*1000*60;
        }

        private void aktTimerEvent(object o, ElapsedEventArgs e)
        {
            dieSteuerung.AktualisiereTable();
            Console.WriteLine("Timer event fired! Aktualisiere...");
        }
        public void NewAktTime()
        {
            aktTimer.Interval = getTrackBarAktTime();
        }
        public void setAktualisieren(bool isChecked)
        {
            if (isChecked)
            {
                aktTimer.Start();
            }
            else
            {
                aktTimer.Stop();
            }
        }

        private void buttonFavTankeLog_Click(object sender, EventArgs e)
        {
            DatenViewer datenViewer = new DatenViewer();
            datenViewer.Show();
        }
    }
}
