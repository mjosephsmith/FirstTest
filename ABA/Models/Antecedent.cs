using System;

namespace ABA.Models
{
    public class Antecedent
    {
        public int Id { get; set; }
        public DateTime OccuranceDateTime { get; set; }
        public string Location { get; set; }
        public string OthersPresent { get; set; }
        public string ActionOfOthersPresent { get; set; }
        public string PreceedingEvent { get; set; }
        public string EnvironmentalCondition { get; set; }
    }
}