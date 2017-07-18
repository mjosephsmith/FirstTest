namespace ABA.Tests
{
    using System;
    using Xunit;
    using ABA.ModelLogic;
    using ABA.DataAccess;
    using ABA.Models;

    public class BehaviorLogicTest    
    {
        [Fact]
        public void GetBehaviorsByDateAscendingWhenNoBehaviorsExistReturnsEmptyList()
        {
            var behaviorContext = new BehavioralScienceContext();
            var behaviorLogic = new BehaviorLogic(behaviorContext);
            var tomorrow = DateTime.Now.AddDays(+1);

            var behaviorList = behaviorLogic.GetBehaviorsByDateAscending(tomorrow);

            Assert.Equal(0, behaviorList.Count);
        }

        [Fact]
        public void GetBehaviorsByDateAscendingReturnsSortedList()
        {
            var behaviorContext = new BehavioralScienceContext();
            var behaviorLogic = new BehaviorLogic(behaviorContext);
            var last30Days = DateTime.Now.AddDays(-30);

            var behaviorList = behaviorLogic.GetBehaviorsByDateAscending(last30Days);
            var inAscendingOrder = true;

            for (int i = 0; i < behaviorList.Count - 1; i++)
            {
                if (behaviorList[i].Antecedent.OccuranceDateTime > 
                    behaviorList[i + 1].Antecedent.OccuranceDateTime)
                {
                    inAscendingOrder = false;
                }
            }

            Assert.Equal(true, inAscendingOrder);
        }
    }
}