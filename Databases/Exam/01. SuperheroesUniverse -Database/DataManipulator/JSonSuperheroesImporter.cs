using DataManipulator.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManipulator
{
    public class JSonSuperheroesImporter
    {
        private const string JSonFilePath = "/Json-Data/sample-data.json";

        public void Import()
        {
            var fileToImport = Directory
                .GetFiles(Directory.GetCurrentDirectory() + "/Json-Data/")
                .Where(f => f.EndsWith(".json"))
                .Select(f => File.ReadAllText(f))
                .SelectMany(str => JsonConvert.DeserializeObject<IEnumerable<JSonSuperheroModel>>(str))
                .ToList();
        }
    }
}
