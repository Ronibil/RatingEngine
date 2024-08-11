using System;

namespace TestRating
{
    internal class HealthPolicy : IPolicy
    {
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public PolicyType Type => PolicyType.Health;

        public string Gender { get; set; }
        public decimal Deductible { get; set; }
    }
}
