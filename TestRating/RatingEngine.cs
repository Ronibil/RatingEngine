using System;

namespace TestRating
{
    /// <summary>
    /// The RatingEngine reads the policy application details from a file and produces a numeric 
    /// rating value based on the details.
    /// </summary>
    public class RatingEngine
    {
        public decimal Rating { get; set; }
        public void Rate()
        {
            try
            {
                ConsoleOutput.ShowStartRating();

                IPolicy policy = PolicySerializer.DeserializePolicy();

                IPolicyRater rater = PolicySpecifier.CreateRater(policy);
                if (rater == null)
                {
                    Console.WriteLine("Unknown policy type.");
                    return;
                }
                Rating = rater.CalculatePolicyRating(policy);

                ConsoleOutput.ShowCompleteRating();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
