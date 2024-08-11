using System;

namespace TestRating
{
    public class HealthPolicyRatingCalculator : IPolicyRater
    {
        public decimal CalculatePolicyRating(IPolicy policy)
        {
            HealthPolicy healthPolicy = policy as HealthPolicy;
            try
            {
                if (healthPolicy == null) throw new ArgumentException("Invalid policy type");

                ConsoleOutput.ShowStartPolicyRating(policy.Type.ToString());

                if (string.IsNullOrEmpty(healthPolicy.Gender))
                {
                    throw new InvalidOperationException("Health policy must specify gender");
                }
                if (healthPolicy.Gender == "Male")
                {
                    return healthPolicy.Deductible < 500 ? 1000m : 900m;
                }
                return healthPolicy.Deductible < 800 ? 1100m : 1000m;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
