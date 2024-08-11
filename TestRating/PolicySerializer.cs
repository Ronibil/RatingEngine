using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System;
using System.IO;

namespace TestRating
{
    public class PolicySerializer
    {
        public static IPolicy DeserializePolicy()
        {
            try
            {
                string policyJson = File.ReadAllText("policy.json");

                PolicyType policyType = JObject.Parse(policyJson)["type"].ToObject<PolicyType>();

                IPolicy policy = null;

                switch (policyType)
                {
                    case PolicyType.Health:
                        policy = JsonConvert.DeserializeObject<HealthPolicy>(policyJson, new StringEnumConverter());
                        break;
                    case PolicyType.Travel:
                        policy = JsonConvert.DeserializeObject<TravelPolicy>(policyJson, new StringEnumConverter());
                        break;
                    case PolicyType.Life:
                        policy = JsonConvert.DeserializeObject<LifePolicy>(policyJson, new StringEnumConverter());
                        break;
                    default:
                        throw new NotSupportedException("Policy type is not supported.");
                };

                return policy;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
