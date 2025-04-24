using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_AlexandraNoriega
{
    public class DecisionHistory
    {
        private Stack<string> pastDecisions = new Stack<string>();

        public void AddDecision(string decision)
        {
            pastDecisions.Push(decision);
        }

        public void ShowHistory()
        {
            if (pastDecisions.Count == 0)
                Console.WriteLine("No hay decisiones aún.");
            else
                foreach (var d in pastDecisions)
                    Console.WriteLine($"Decisión: {d}");
        }
    }
}
