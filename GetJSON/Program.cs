using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GetJSON
{
    class Program
    {
        public static string folder = @"C:\Users\Jeff\Documents\Visual Studio 2015\Websites\FootballSite\data\";

        static void Main(string[] args)
        {
            var url = "http://www.footballwebpages.co.uk/league.json?comp=5";
            ProcessLeague(url, "league");
            ProcessMatches(94);
            ProcessMatches(118);
            ProcessMatches(187);
            ProcessMatches(226);
            ProcessMatches(251);
            ProcessMatches(1004);
            ProcessMatches(100);
            ProcessMatches(229);
            ProcessMatches(230);
            ProcessMatches(103);
            ProcessMatches(292);
            ProcessMatches(293);
            ProcessMatches(79);
            ProcessMatches(80);
            ProcessMatches(403);
            ProcessMatches(319);
            ProcessMatches(569);
            ProcessMatches(131);
            ProcessMatches(154);
            ProcessMatches(65);
            ProcessMatches(66);
            ProcessMatches(113);
            ProcessMatches(68);
            ProcessMatches(114);
        }

        private static string _download_serialized_json_data<T>(string url) where T : new()
        {
            using (var w = new WebClient())
            {
                var json_data = string.Empty;
                // attempt to download JSON data as a string
                try
                {
                    json_data = w.DownloadString(url);
                }
                catch (Exception) { }
                // if string with JSON data is not empty, deserialize it to class and return its instance 
                //return !string.IsNullOrEmpty(json_data) ? JsonConvert.DeserializeObject<T>(json_data) : new T();
                return !string.IsNullOrEmpty(json_data) ? json_data : string.Empty;
            }
        }

        private static void ProcessLeague(string url, string filename)
        {
            var data = _download_serialized_json_data<Rootobject>(url);
            var fileToWrite = string.Format("{0}{1}.json", folder,filename);
            using (StreamWriter file = new StreamWriter(fileToWrite))
            {
                file.WriteLine(data);
            }
        }

        private static void ProcessMatches(int team)
        {
            var url = string.Format("http://www.footballwebpages.co.uk/matches.json?team={0}", team);
            var data = _download_serialized_json_data<Rootobject>(url);
            var filename = string.Format("matches-{0}.json", team);
            var fileToWrite = string.Format("{0}{1}", folder, filename);
            using (StreamWriter file = new StreamWriter(fileToWrite))
            {
                file.WriteLine(data);
            }
        }
    }
}

