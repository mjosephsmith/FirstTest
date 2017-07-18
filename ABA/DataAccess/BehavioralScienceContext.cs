namespace ABA.DataAccess
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using ABA.Models;

    public class BehavioralScienceContext : IContext
    {
        public List<Behavior> GetBehaviorsByDateAscending(DateTime behaviorDateTime)
        {
            try
            {
                var behaviorList = new List<Behavior>();

                var antecedentA = new Antecedent() { OccuranceDateTime = DateTime.Now.AddDays(-20)};
                var behaviorA = new Behavior();

                var antecedentB = new Antecedent() { OccuranceDateTime = DateTime.Now.AddDays(-18)};
                var behaviorB = new Behavior();

                var antecedentC = new Antecedent() { OccuranceDateTime = DateTime.Now.AddDays(-18)};
                var behaviorC = new Behavior();
                            
                behaviorA.Antecedent = antecedentA;
                behaviorB.Antecedent = antecedentB;
                behaviorC.Antecedent = antecedentC;

                behaviorList.Add(behaviorA);
                behaviorList.Add(behaviorB);
                behaviorList.Add(behaviorC);

                var filteredBehaviorList = behaviorList.Where(b => b.Antecedent.OccuranceDateTime >= behaviorDateTime).ToList();
                var sortedBehaviorList = filteredBehaviorList.OrderBy(o => o.Antecedent.OccuranceDateTime).ToList();
                return sortedBehaviorList;
            }
            catch
            {
                throw;
            }
        }
    }
}