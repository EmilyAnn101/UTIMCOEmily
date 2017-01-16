using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text.RegularExpressions;
using System.Runtime.Serialization;

namespace UTIMCOSample
{
    class Parser
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter File Path:");
            string path = Console.ReadLine();
            List<int> sums = new List<int>();
            var json = System.IO.File.ReadAllText(path);

            sums = Parsing(json);

            foreach (var s in sums)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();
        }

        public static List<int> Parsing(string json)
        {
            List<int> sums = new List<int>();

            var objects = JArray.Parse(json);
            Console.Write("The sums are: \n");
            foreach (JObject root in objects)
            {
                foreach (KeyValuePair<String, JToken> app in root)
                {
                    string[] items = app.Value.Children().Last().Last.ToString().Split('{');
                    items = items.Where(w => w.Contains("label")).ToArray();
                    sums.Add(findnumber(items));
                }
            }
            return sums;
        }
        public static int findnumber(string[] items)
        {
            int sum = 0;
            foreach (var item in items)
            {
                int j;
                string number = item.Split(':')[1];
                number = number.Split(',')[0];
                if (Int32.TryParse(number, out j))
                    sum = sum + j;
                else
                    Console.WriteLine("String could not be parsed.");
            }
            return sum;
        }
    }
}
