namespace TestRating
{
    public interface IPolicyRater
    {
        decimal CalculatePolicyRating(IPolicy policy);
    }
}
