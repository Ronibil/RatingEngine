using System;

namespace TestRating
{
    public class TravelPolicy : IPolicy
    {
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public PolicyType Type => PolicyType.Travel;
        public string Country { get; set; }
        public int Days { get; set; }
    }
}
