using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WeatherCheck;
using Newtonsoft.Json;

namespace UnitTestsforWeatherCheck
{

    [TestClass]
    public class Tests
    {
        private ParamsStore paramstore;
        //private 

        [TestInitialize]
        public void SetUp()
        {
            paramstore = new ParamsStore();
        }

        [TestMethod]
        public void correct_url()
        {
            string cityname = "Manchester";
            string result;
            result = paramstore.GetUrl(cityname);
            Assert.AreEqual(result, "http://api.openweathermap.org/data/2.5/weather?q=Manchester,uk&APPID=74199d873ef49144fcd96ddc01fa6064");
        }
        [TestMethod]
        public void get_obj()
        {
            string cityname = "Manchester";
            string url;
            RootObject result;
            url = paramstore.GetUrl(cityname);
            result = paramstore.GetJSONObj(url);
            Assert.IsTrue(result != null);
        }
    }

}
