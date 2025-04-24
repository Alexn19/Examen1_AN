using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_AlexandraNoriega
{
    public class Ministry<T> where T : GovernmentEntity
    {
        public string Name { get; }
        public List<T> Members = new List<T>();

        public Ministry(string name)
        {
            Name = name;
        }

        public void AddMember(T member)
        {
            Members.Add(member);
            Console.WriteLine($"Miembro agregado a {Name}: {member.Name}");
        }

        public void RemoveMember(string name)
        {
            var person = Members.Find(m => m.Name == name);
            if (person != null)
            {
                Members.Remove(person);
                Console.WriteLine($"Miembro {name} fue removido de {Name}.");
            }
            else
            {
                Console.WriteLine("Miembro no encontrado.");
            }
        }

        public void ShowMembers()
        {
            Console.WriteLine($"\nMinisterio de {Name}:");
            foreach (var m in Members)
                Console.WriteLine($"Integrante: {m.Name}");
        }
    }
}
