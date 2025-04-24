using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_AlexandraNoriega
{
    public class Government
    {
        public Dictionary<string, GovernmentEntity> Ministries { get; set; } = new Dictionary<string, GovernmentEntity>();

        public void AddMinistry(string key, GovernmentEntity entity)
        {
            Ministries[key] = entity;
        }

        public void ShowMinistries()
        {
            Console.WriteLine("\n Ministerios actuales:");
            foreach (var kv in Ministries)
            {
                Console.WriteLine($" ° {kv.Key} - Encargado: {kv.Value.Name}");
            }
        }
    }

}
