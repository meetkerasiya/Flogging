using System;
using System.Collections.Generic;

namespace Flogging.Core
{
    public class FlogDetail
    {
        public FlogDetail()
        {
            Timestamp = DateTime.Now;
        }
        public DateTime Timestamp { get; private set; }

        public string Message { get; set; }

        //Where
        public string Product { get; set; }
        public string Layer { get; set; }
        public string Location { get; set; }
        public string Hostname { get; set; }

        //Whoo

        public string UserId { get; set; }
        public string UserName { get; set; }
        public string CustomerId { get; set; }
        public string CustomerName { get; set; }

        //EVERYTHING ELSE

        public long? ElapsedMilliseconds { get; set; }
        public Exception Exception { get; set; }

        public string CorrelationId { get; set; }

        public Dictionary<string, object> AdditionalInfo { get; set; }


    }
}
