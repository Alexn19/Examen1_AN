using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_AlexandraNoriega
{
    public class President : GovernmentEntity, IDecisionMaker
    {
        public President(string name) : base(name) { }
        public override void Operate()
        {
            Console.WriteLine($"Presidenta {Name} está operando como presidente.");
        }

        public void MakeDecision(string decision)
        {
            Console.WriteLine($"Presidenta {Name} toma una decisión presidencial: {decision}.");
        }
    }
}
