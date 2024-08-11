using System;

namespace TestRating
{
    public interface IPolicy
    {
        string FullName { get; set; }
        DateTime DateOfBirth { get; set; }
        PolicyType Type { get; }
    }
}
