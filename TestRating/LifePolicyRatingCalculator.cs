using System;

namespace TestRating
{
    public class LifePolicyRatingCalculator : IPolicyRater
    {
        public decimal CalculatePolicyRating(IPolicy policy)
        {
            LifePolicy lifePolicy = policy as LifePolicy;
            try
            {
                if (lifePolicy == null) throw new ArgumentException("Invalid policy type");

                ConsoleOutput.ShowStartPolicyRating(policy.Type.ToString());

                if (lifePolicy.DateOfBirth == DateTime.MinValue)
                {
                    throw new ArgumentException("Life policy must include Date of Birth.");
                }

                if (lifePolicy.DateOfBirth < DateTime.Today.AddYears(-100))
                {
                    throw new ArgumentException("Max eligible age for coverage is 100 years.");
                }

                if (lifePolicy.Amount == 0)
                {
                    throw new ArgumentException("Life policy must include an Amount.");
                }

                int age = DateTime.Today.Year - lifePolicy.DateOfBirth.Year;

                if (lifePolicy.DateOfBirth.Month == DateTime.Today.Month &&
                DateTime.Today.Day < lifePolicy.DateOfBirth.Day ||
                DateTime.Today.Month < lifePolicy.DateOfBirth.Month)
                {
                    age--;
                }

                decimal baseRate = lifePolicy.Amount * age / 200;
                return lifePolicy.IsSmoker ? baseRate * 2 : baseRate;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
