using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRating
{
    public class TravelPolicyRatingCalculator : IPolicyRater
    {
        public decimal CalculatePolicyRating(IPolicy policy)
        {
            TravelPolicy travelPolicy = policy as TravelPolicy;

            try
            {
                if (travelPolicy == null) throw new ArgumentException("Invalid policy type");

                ConsoleOutput.ShowStartPolicyRating(policy.Type.ToString());

                if (travelPolicy.Days <= 0)
                {
                    throw new ArgumentException("Travel policy must specify Days.");
                }

                if (travelPolicy.Days > 180)
                {
                    throw new ArgumentException("Travel policy cannot be more than 180 Days.");
                }

                if (string.IsNullOrEmpty(travelPolicy.Country))
                {
                    throw new ArgumentException("Travel policy must specify country.");
                }

                decimal rating = travelPolicy.Days * 2.5m;
                if (travelPolicy.Country == "Italy")
                {
                    rating *= 3;
                }
                return rating;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
