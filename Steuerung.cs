using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Tankerkönig
{
    public class Steuerung
    {
        TankerkoenigAPI dieAPI;
        Daten dieDaten = new Daten();
        Datenbank dieDatenbank = new Datenbank();
        Form1 dieGUI;

        public Steuerung(Form1 form)
        {
            dieGUI = form;
            dieAPI = new TankerkoenigAPI();
        }

        public void ShowMapForSelectedTanke()
        {
            DataGridView pDataGrid = dieGUI.getTable();
            int selectedCells = pDataGrid.SelectedCells.Count;
            if (selectedCells == 0)
            {
                MessageBox.Show("Bitte eine Tankstelle auswählen!");
                return;
            }
            if(false) //todo: notfalls >15 checken
            {
                MessageBox.Show("Bitte nur EINE Tankstelle auswählen!");
                return;
            }
            //Index der ausgewählten Reihe finden
                int selectedrowindex = pDataGrid.SelectedCells[0].RowIndex;
            //Ausgewählte Reihe finden
                DataGridViewRow selectedRow = pDataGrid.Rows[selectedrowindex];
            //Daten vorbereiten
                string brand = Convert.ToString(selectedRow.Cells["brand"].Value);
                //Use name instead of brand if no brand specified
                if (brand == "") brand = Convert.ToString(selectedRow.Cells["name"].Value);

                string street = Convert.ToString(selectedRow.Cells["street"].Value);
                string housenumber = Convert.ToString(selectedRow.Cells["housenumber"].Value).Replace("/", "-");
                string postcode = Convert.ToString(selectedRow.Cells["postcode"].Value);
                string place = Convert.ToString(selectedRow.Cells["place"].Value);

            //Neues Fenster mit Google Maps + der Tankstelle erstellen

                //Ortssuche funktioniert bei Google Maps besser als Koordinaten
                //string lat = Convert.ToString(selectedRow.Cells["lat"].Value).Replace(",",".");
                //string lng = Convert.ToString(selectedRow.Cells["lng"].Value).Replace(",", ".");
                //Map map = new Map($"http://maps.google.com/maps?q={lat},{lng}");

                //Neue Map form erstellen mit Google Maps und der ausgewählten Tanke als Suchbegriff
                Map map = new Map($"http://maps.google.com/maps?q={brand} {street} {housenumber} {postcode} {place}");
                map.Show();
            
        }
        public void AktualisiereTable()
        {
            List<TankerkoenigAPI.Station> _stations;
            List<TankerkoenigAPI.Station> _favstations = new List<TankerkoenigAPI.Station>();
            try
            {
                _stations = dieAPI.Umkreissuche(dieGUI.getBreitengrad(), dieGUI.getLaengengrad(), dieGUI.getRadius(), dieGUI.getType(), dieGUI.getSort());
            }
            catch(TankerkoenigAPI.APIErrorException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            dieDaten.setStations(_stations);
            dieGUI.getTable().DataSource = dieDaten.getStations();

            foreach(string favid in dieDaten.getFavoriten_ID())
            {
                try
                {
                    var stat = _stations.First(p => p.id == favid);
                    _favstations.Add(stat);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to add element, increase Radius...");
                }
            }
            dieDaten.setFavStations(_favstations);
            dieGUI.getFavTable().DataSource = dieDaten.getFavStations();
        }

        public void AddToFav()
        {
            DataGridView pDataGrid = dieGUI.getTable();
            int selectedCells = pDataGrid.SelectedCells.Count;
            if (selectedCells == 0)
            {
                MessageBox.Show("Bitte eine Tankstelle auswählen!");
                return;
            }
            if (false) //todo: notfalls >15 checken
            {
                MessageBox.Show("Bitte nur EINE Tankstelle auswählen!");
                return;
            }
            //Index der ausgewählten Reihe finden
            int selectedrowindex = pDataGrid.SelectedCells[0].RowIndex;
            //Ausgewählte Reihe finden
            DataGridViewRow selectedRow = pDataGrid.Rows[selectedrowindex];
            //Daten vorbereiten
            string id = Convert.ToString(selectedRow.Cells["id"].Value);

            List<String> favoriten_ID = dieDaten.getFavoriten_ID();
            if (favoriten_ID.Contains(id))
            {
                MessageBox.Show("Tankstelle schon in Liste");
                return;
            }
            if(favoriten_ID.Count > 10)
            {
                MessageBox.Show("Schon 10 Tankstellen in der Liste, bitte eine Entfernen...");
                return;
            }
            favoriten_ID.Add(id);
            dieDaten.setFavoriten_ID(favoriten_ID);
            AktualisiereTable();
        }
        public void RemoveFromFav()
        {
            DataGridView pDataGrid = dieGUI.getFavTable();
            int selectedCells = pDataGrid.SelectedCells.Count;
            if (selectedCells == 0)
            {
                MessageBox.Show("Bitte eine Tankstelle auswählen!");
                return;
            }
            if (false) //todo: notfalls >15 checken
            {
                MessageBox.Show("Bitte nur EINE Tankstelle auswählen!");
                return;
            }
            //Index der ausgewählten Reihe finden
            int selectedrowindex = pDataGrid.SelectedCells[0].RowIndex;
            //Ausgewählte Reihe finden
            DataGridViewRow selectedRow = pDataGrid.Rows[selectedrowindex];
            //Daten vorbereiten
            string id = Convert.ToString(selectedRow.Cells["id"].Value);
            List<string> fav = dieDaten.getFavoriten_ID();
            fav.Remove(id);
            dieDaten.setFavoriten_ID(fav);
            AktualisiereTable();
        }
    }
}
