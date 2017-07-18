namespace ABA.ModelLogic
{
    using System;
    using System.Collections.Generic;
    using ABA.Models;
    using ABA.DataAccess;

    public class BehaviorLogic
    {
        IContext dbContext;
        public BehaviorLogic(IContext injectedContext)
        {
            dbContext = injectedContext;
        }

        public List<Behavior> GetBehaviorsByDateAscending(DateTime behaviorDateTime)
        {               
            return dbContext.GetBehaviorsByDateAscending(behaviorDateTime);
        }  
    }
}