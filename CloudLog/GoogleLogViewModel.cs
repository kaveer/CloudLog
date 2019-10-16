using Newtonsoft.Json;
using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudLog
{
    public class GoogleLogViewModel
    {
        public ProtoPayload protoPayload { get; set; }
        public string insertId { get; set; }
        public Resource resource { get; set; }
        public DateTime timestamp { get; set; }
        public string severity { get; set; }
        public string logName { get; set; }
        public string receiveTimestamp { get; set; }
    }

    [ProtoContract]
    public class Status
    {
    }
    [ProtoContract]
    public class AuthenticationInfo
    {
        [ProtoMember(1)]
        public string principalEmail { get; set; }
    }

    public class RequestAttributes
    {
    }

    public class DestinationAttributes
    {
    }

    public class RequestMetadata
    {
        public string callerSuppliedUserAgent { get; set; }
        public RequestAttributes requestAttributes { get; set; }
        public DestinationAttributes destinationAttributes { get; set; }
    }

    [ProtoContract]
    public class ResourceAttributes
    {
    }

    [ProtoContract]
    public class AuthorizationInfo
    {
        [ProtoMember(1)]
        public string resource { get; set; }
        [ProtoMember(2)]
        public string permission { get; set; }
        [ProtoMember(3)]
        public bool granted { get; set; }
        [ProtoMember(4)]
        public ResourceAttributes resourceAttributes { get; set; }
    }

    public class BindingDelta
    {
        public string action { get; set; }
        public string role { get; set; }
        public string member { get; set; }
    }

    public class PolicyDelta
    {
        public List<BindingDelta> bindingDeltas { get; set; }
    }

    public class ServiceData
    {
        [JsonProperty("@type")]
        public string invalidNameType { get; set; }
        public PolicyDelta policyDelta { get; set; }
    }

    public class ResourceLocation
    {
        public List<string> currentLocations { get; set; }
    }

    [ProtoContract(SkipConstructor = true)]
    public class ProtoPayload
    {
        //[JsonProperty("@type")]
        //public string invalidNameYype { get; set; }
        [ProtoMember(2)]
        public Status status { get; set; }
        [ProtoMember(1)]
        public AuthenticationInfo authenticationInfo { get; set; }
        public RequestMetadata requestMetadata { get; set; }
        [ProtoMember(3)]
        public string serviceName { get; set; }
        [ProtoMember(4)]
        public string methodName { get; set; }
        [ProtoMember(6)]
        public List<AuthorizationInfo> authorizationInfo { get; set; }
        [ProtoMember(5)]
        public string resourceName { get; set; }
        public ServiceData serviceData { get; set; }
        public ResourceLocation resourceLocation { get; set; }
    }

    public class Labels
    {
        public string project_id { get; set; }
        public string location { get; set; }
        public string bucket_name { get; set; }
    }

    public class Resource
    {
        public string type { get; set; }
        public Labels labels { get; set; }
    }
}
