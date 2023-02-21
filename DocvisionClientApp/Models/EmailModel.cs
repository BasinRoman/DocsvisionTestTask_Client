using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocsvisionClientApp.Model
{
    public class EmailModel
    {
        public string emailSubject { get; set; }
        public string emailBody { get; set; } = string.Empty;
        public string emailTo { get; set; }
        public string emailFrom { get; set; }
        public DateTime emailDate { get; set; }
        public EmailModel() { this.emailDate = DateTime.Now;}
    }
}
