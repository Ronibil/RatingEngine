using System;
using System.IO;

namespace TestRating
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ConsoleOutput.ShowStartMessage();

                string policyJson = File.ReadAllText("policy.json");
                IPolicy policy = PolicySerializer.DeserializePolicy(policyJson);

                IPolicyRater rater = PolicySpecifier.CreateRater(policy);

                RatingEngine engine = new RatingEngine(policy, rater);
                engine.Rate();

                ConsoleOutput.ShowRating(engine.Rating);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
