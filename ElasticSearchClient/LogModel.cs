using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElasticSearchClient
{
    class LogModel
    {
        public DateTime log_timestamp { get; private set; }
        public string Method { get; private set; }
        public string Scheme { get; private set; }
        public string Access { get; private set; }
        public string URI { get; private set; }
        public string IP { get; private set; }
        public LogModel()
        {
            this.log_timestamp = DateTime.Now;
            this.Method = "GET";
            this.IP = "1";
            this.Scheme = "asdasd";
        }
    }
  
}
