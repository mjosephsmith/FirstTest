namespace ABA.DataAccess
{
    using System;
    using System.Collections.Generic;
    using ABA.Models;

    public interface IContext
    {
        List<Behavior> GetBehaviorsByDateAscending(DateTime behaviorDateTime);
    }    
}