using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;




namespace MarsQA_1.SpecflowPages.Helpers
{
    internal class JsonReader
    {

        public string username { get; set; }
        public string password { get; set; }



        public static JsonReader read()
        {

            string json = File.ReadAllText(@"C:\Users\gskum\OneDrive\Documents\SatheeshProject\StandardTaskNew\onboarding.specflow-master\MarsQA-1\SpecflowTests\Data\Credentials.json");
            JsonReader jr = JsonConvert.DeserializeObject<JsonReader>(json);
            return jr;
        }

        class Program
        {



           /* public static string read(string key)
            {
                // Read the JSON file into a string
                string json = File.ReadAllText(@"C:\Users\gskum\OneDrive\Documents\SatheeshProject\StandardTaskNew\onboarding.specflow-master\MarsQA-1\SpecflowTests\Data\Credentials.json");


                // Deserialize the JSON string into an object
                JsonReader jr = JsonConvert.DeserializeObject<JsonReader>(json);

                if (key == "username")
                {
                    return jr.username;
                }
                else if (key == "password")
                {
                    return jr.password;
                }

                return null;
            }

            public static JsonReader read()
            {

                string json = File.ReadAllText(@"C:\Users\gskum\OneDrive\Documents\SatheeshProject\StandardTaskNew\onboarding.specflow-master\MarsQA-1\SpecflowTests\Data\Credentials.json");
                JsonReader jr = JsonConvert.DeserializeObject<JsonReader>(json);
                return jr;
            }*/

        }



    }
}




