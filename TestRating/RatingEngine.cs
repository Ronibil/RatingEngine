using System;

namespace TestRating
{
    /// <summary>
    /// The RatingEngine reads the policy application details from a file and produces a numeric 
    /// rating value based on the details.
    /// </summary>
    public class RatingEngine
    {
        private readonly IPolicy _policy;
        private readonly IPolicyRater _rater;
        public decimal Rating { get; set; }
        public RatingEngine(IPolicy policy, IPolicyRater rater)
        {
            _policy = policy;
            _rater = rater;
        }
        public void Rate()
        {
            try
            {
                ConsoleOutput.ShowStartRating();

                if (_rater == null)
                {
                    Console.WriteLine("Unknown policy type.");
                    return;
                }
                Rating = _rater.CalculatePolicyRating(_policy);

                ConsoleOutput.ShowCompleteRating();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
