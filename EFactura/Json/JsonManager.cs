
using EFactura.ConfigSettings;

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFactura.Json
{
    public class JsonManager
    {
        public Config? LoadConfig(string path)
        {
            try
            {
                string json = File.ReadAllText(path);
                return Newtonsoft.Json.JsonConvert.DeserializeObject<Config>(json);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

            }
            return null;
        }
    }
}
