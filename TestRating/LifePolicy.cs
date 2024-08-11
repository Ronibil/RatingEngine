using System;

namespace TestRating
{
    public class LifePolicy : IPolicy
    {
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public PolicyType Type => PolicyType.Life;

        public bool IsSmoker { get; set; }
        public decimal Amount { get; set; }
    }
}
