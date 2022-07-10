using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace HHLibrary
{
    public class HHModel
    {
        /// <summary>
        /// Geting answer on GET request
        /// </summary>
        /// <param name="request">URL request</param>
        /// <returns></returns>
        public string RequestGet(string request)
        {
            string outstring = "";
            try
            {
                WebClient client = new WebClient();
                client.Headers.Add("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/90.0.4430.212 Safari/537.36");
                
                
                using(Stream stream = client.OpenRead(request))
                {
                    using (StreamReader streamReader = new StreamReader(stream))
                    {
                        string line;

                        while ((line = streamReader.ReadLine()) != null)
                            outstring += line;
                    }
                }

                //stream.Close();
                //streamReader.Close();
            }
            catch (Exception e)
            {
                outstring = e.Message;
            }

            return outstring;
        }


        public string JsonParseString(string json)
        {
            string outstring = "";
            dynamic jsonObj = JObject.Parse(json);
            outstring += jsonObj.name + "\r\n"; // name is key in json file
            outstring += " Salary from: " + jsonObj.salary.from + " to " + jsonObj.salary.to;

            return outstring;
        }

        public string JsonParseStringItems(string json)
        {
            string outstring = "";
            dynamic jsonObj = JObject.Parse(json);

            foreach(dynamic item in jsonObj.items)
            {
                outstring += item.name + "\r\n";
                if (item.salary != null)
                    outstring += " Salary from: " + item.salary.from + " to " + item.salary.to + "\r\n";
                outstring += "============================" + "\r\n";
            }



            return outstring;
        }


        public List<Vacancy> JsonParserResoutSearching(string json)
        {
            List<Vacancy> listVacancies = new List<Vacancy>();

            dynamic jsonObj = JObject.Parse(json);

            foreach (dynamic item in jsonObj.items)
            {
                listVacancies.Add(new Vacancy(item));
            }
            return listVacancies;
        }
    }
}
