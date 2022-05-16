using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Tankerkönig
{
    public class TankerkoenigAPI
    {
        public class ListResult
        {
            public bool ok;
            public string message;
            public string license;
            public string data;
            public string status;
            public List<Station> stations;
        }
        public class Station
        {
            public string name { get; set; }
            public string brand { get; set; }
            public string street { get; set; }
            public string houseNumber { get; set; }
            public double price { get; set; } //Wenn nur eine Spritsorte abgefragt wird ist im JSON statt Name der Sorte 'price' angegeben.
            public double diesel { get; set; }
            public double e5 { get; set; }
            public double e10 { get; set; }
            public bool isOpen { get; set; }
            public double dist { get; set; }
            public string place { get; set; }
            public int postCode { get; set; }
            public string id { get; set; }
            public double lat { get; set; }
            public double lng { get; set; }
        }

        public class PriceResult
        {
            public bool ok;
            public string message;
            public string license;
            public string data;
            public string status;
            //public List<Price> prices;
        }

        private string APIKey = null;
        private static string APIurl = "https://creativecommons.tankerkoenig.de/json/"; //Alte API? Zumindest findet man die dokumentation hierfür auf der homepage
        private static string APIurlv4 = "https://creativecommons.tankerkoenig.de/api/v4/"; //https://creativecommons.tankerkoenig.de/swagger/#/search/get_stations_postalcode

        [Serializable]
        public class APIErrorException : Exception
        {
            public APIErrorException() { }

            public APIErrorException(string err) : base(String.Format("API ERROR: {0}", err)) {}
        }

        public TankerkoenigAPI()
        {
            APIKey = "00000000-0000-0000-0000-000000000002"; //Use test api key
        }

        public TankerkoenigAPI(string pAPIKey)
        {
            APIKey = pAPIKey;
        }

        public List<Station> Umkreissuche(double lat, double lng, double rad, string type, string sort)
        {
            if (type == "all") sort = "dist"; // API ERROR: wenn type = all ist, muss sort 'dist' sein, oder sort Parameter weglassen
            string url = $"{APIurl}list.php?lat={lat}&lng={lng}&rad={rad}&sort={sort}&type={type}&apikey={APIKey}";
            string json = Request(url);
            var result = JsonConvert.DeserializeObject<ListResult>(json);

            if (!result.ok) throw new APIErrorException(result.message);
            if (result.status != "ok") throw new APIErrorException($"API STATUS: {result.status}");

            return result.stations;
        }

        /* API Methode 2: Preisabfrage
         * ids: UUIDs, durch komma getrennt !!!max 10!!!!
         * 
         * 
         * 
         */
        public string Preisabfrage(string ids)
        {

            return "";
        }

        public void Tankstellen_PLZ(string PLZ)
        {

        }

        //https://docs.microsoft.com/de-de/dotnet/framework/network-programming/how-to-request-data-using-the-webrequest-class#example
        private string Request(string purl)
        {
            string r;
            // Create a request for the URL.
            WebRequest request = WebRequest.Create(purl);

            // Get the response.
            WebResponse response = request.GetResponse();
            // Display the status.
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);

            // Get the stream containing content returned by the server.
            // The using block ensures the stream is automatically closed.
            using (Stream dataStream = response.GetResponseStream())
            {
                // Open the stream using a StreamReader for easy access.
                StreamReader reader = new StreamReader(dataStream);
                // Read the content.
                string responseFromServer = reader.ReadToEnd();
                // Display the content.
                //Console.WriteLine(responseFromServer);
                r = responseFromServer;
            }

            // Close the response.
            response.Close();
            return r;
        }

    }
}
