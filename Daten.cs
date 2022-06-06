using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tankerkönig
{
    public class Daten
    {
        private List<string> Favoriten_ID = new List<string>();
        private List<TankerkoenigAPI.Station> stations = new List<TankerkoenigAPI.Station>();
        private List<TankerkoenigAPI.Station> favstations = new List<TankerkoenigAPI.Station>();

        public List<TankerkoenigAPI.Station> getStations()
        {
            return stations;
        }
        public List<TankerkoenigAPI.Station> getFavStations()
        {
            return favstations;
        }

        public void setStations(List<TankerkoenigAPI.Station>  pStations)
        {
            stations = pStations;
        }
        public void setFavStations(List<TankerkoenigAPI.Station> pStations)
        {
            favstations = pStations;
        }

        public List<string> getFavoriten_ID()
        {
            return Favoriten_ID;
        }

        public void setFavoriten_ID(List<string> pFavoriten_ID)
        {
            Favoriten_ID = pFavoriten_ID;
        }
    }
}
