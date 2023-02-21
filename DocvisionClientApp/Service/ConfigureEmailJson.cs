using DocsvisionClientApp.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;


namespace DocsvisionClientApp.Service
{
    public static class ConfigureEmailJson
    {
        public static async Task<string> ConfigureJson(EmailModel emailModel)
        {
            string output = JsonConvert.SerializeObject(emailModel);
            return output;
        }
    }
}
