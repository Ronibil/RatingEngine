namespace TestRating
{
    public static class PolicySpecifier
    {
        public static IPolicyRater CreateRater(IPolicy policy)
        {
            switch (policy.Type)
            {
                case PolicyType.Health:
                    return new HealthPolicyRatingCalculator();
                case PolicyType.Travel:
                    return new TravelPolicyRatingCalculator();
                case PolicyType.Life:
                    return new LifePolicyRatingCalculator();
                default:
                    return null;
            }
        }
    }
}
