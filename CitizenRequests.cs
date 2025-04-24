using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_AlexandraNoriega
{
    public class CitizenRequests
    {
        private Queue<string> requests = new Queue<string>();

        public void AddRequest(string request)
        {
            requests.Enqueue(request);
        }

        public void ShowRequests()
        {
            if (requests.Count == 0)
            {
                Console.WriteLine("No hay solicitudes pendientes.");
                return;
            }

            int i = 1;
            foreach (var r in requests)
            {
                Console.WriteLine($"{i++}. Enviado {r}");
            }
        }


        public void ProcessRequest(int number)
        {
            if (number < 1 || number > requests.Count)
            {
                Console.WriteLine("Número de solicitud inválido.");
                return;
            }

            var temp = new Queue<string>();
            for (int i = 1; i <= requests.Count; i++)
            {
                var item = requests.Dequeue();
                if (i == number)
                {
                    Console.WriteLine($"Procesado: {item}");
                }
                else
                {
                    temp.Enqueue(item);
                }
            }
            requests = temp;
        }
    }
}
