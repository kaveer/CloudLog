using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudForensic
{
    class GoogleLogViewModel
    {
        public ProtoPayload protoPayload { get; set; }
        public string insertId { get; set; }
        public Resource resource { get; set; }
        public DateTime timestamp { get; set; }
        public string severity { get; set; }
        public string logName { get; set; }
        public string receiveTimestamp { get; set; }
    }

    public class Status
    {
    }

    public class AuthenticationInfo
    {
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

    public class ResourceAttributes
    {
    }

    public class AuthorizationInfo
    {
        public string resource { get; set; }
        public string permission { get; set; }
        public bool granted { get; set; }
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
        public string __invalid_name__@type { get; set; }
    public PolicyDelta policyDelta { get; set; }
}

public class ResourceLocation
{
    public List<string> currentLocations { get; set; }
}

public class ProtoPayload
{
    public string __invalid_name__@type { get; set; }
public Status status { get; set; }
public AuthenticationInfo authenticationInfo { get; set; }
public RequestMetadata requestMetadata { get; set; }
public string serviceName { get; set; }
public string methodName { get; set; }
public List<AuthorizationInfo> authorizationInfo { get; set; }
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
