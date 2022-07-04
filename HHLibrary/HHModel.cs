using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

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
                client.Headers.Add("user-agent", "Mozilla / 4.0(compatible; MSIE 7.0; Windows NT 6.1; WOW64; Trident / 6.0;)");
                Stream stream = client.OpenRead(request);

                StreamReader streamReader = new StreamReader(stream);
                string line;

                while((line = streamReader.ReadLine()) != null)
                    outstring += line;
                stream.Close();

                //streamReader.Close();
            }
            catch (Exception e)
            {
                outstring = e.Message;
            }

            return outstring;
        }
    }
}
