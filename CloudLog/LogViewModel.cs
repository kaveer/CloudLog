using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Protobuf.Collections;
using Google.Protobuf.WellKnownTypes;

namespace CloudLog
{
    public class LogViewModel
    {
        public int LogId { get; set; }
        public string InsertId { get; internal set; }
        public string LogName { get; internal set; }
        public string ProtoPayloadTypeUrl { get; internal set; }
        public string ProtoPayloadValue { get; internal set; }
        public Timestamp RecieveTimestamp { get; internal set; }
        public Dictionary<string, string> Resource { get; internal set; }
        public string Severity { get; internal set; }
        public Timestamp LogTimestamp { get; internal set; }
        public bool IsNew { get; set; }
    }
}
