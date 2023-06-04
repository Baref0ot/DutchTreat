using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace DutchTreat.Serivces {
    public class NullMailService:IMailService {

        private readonly ILogger<NullMailService> _logger;

        

        public NullMailService(ILogger<NullMailService> logger )
        {
            _logger = logger;
        }

        public string SendMessage(string to, string subject, string body) {
            _logger.LogInformation($"To: {to} Subject: {subject} Body: {body}");
            string ModifiedBody = body + " Has been modified.";

            return ModifiedBody;
        }// end SendMessage
    }
}
