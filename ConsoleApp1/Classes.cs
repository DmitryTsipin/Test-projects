using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json;


namespace WeatherCheck
{
    public class ParamsStore
    {

        public string GetUrl(string city)
        {
            var result = "http://api.openweathermap.org/data/2.5/weather?q=" + city + ",uk&APPID=74199d873ef49144fcd96ddc01fa6064";
            return result;
        }

       
        public RootObject GetJSONObj(string url)
        {
            RootObject weatherobj;
            using (var wc = new WebClient())
            {
                wc.Credentials = CredentialCache.DefaultCredentials;

                var json = wc.DownloadString(url);

                weatherobj = JsonConvert.DeserializeObject<RootObject>(json);
            }
            return weatherobj;
        }

    }



}
