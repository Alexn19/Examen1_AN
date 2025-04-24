using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_AlexandraNoriega
{
    public abstract class GovernmentEntity
    {
        public string Name;
        public abstract void Operate();

        public GovernmentEntity(string name) => Name = name;
    }
}
