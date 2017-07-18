namespace ABA.Models
{
    using System;
    public class Behavior
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Antecedent Antecedent { get; set; }  
        public Consequence Consequence { get; set; }      
    }
}