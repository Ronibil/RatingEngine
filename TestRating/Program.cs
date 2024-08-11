using System;

namespace TestRating
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ConsoleOutput.ShowStartMessage();

                RatingEngine engine = new RatingEngine();
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
