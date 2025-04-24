using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_AlexandraNoriega
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var president = new President("Alexandra");
                var decisions = new DecisionHistory();
                var requests = new CitizenRequests();
                var education = new Ministry<GovernmentEntity>("Educación");

                while (true)
                {
                    Console.WriteLine("\n===== Simulación de Gobierno =====");
                    Console.WriteLine("1. Tomar decisión");
                    Console.WriteLine("2. Ver historial de decisiones");
                    Console.WriteLine("3. Agregar solicitud ciudadana");
                    Console.WriteLine("4. Procesar solicitud por número");
                    Console.WriteLine("5. Agregar miembro a ministerio");
                    Console.WriteLine("6. Quitar miembro de ministerio");
                    Console.WriteLine("7. Ver miembros del ministerio");
                    Console.WriteLine("8. Salir");
                    Console.Write("Selecciona una opción: ");

                    string input = Console.ReadLine();
                    Console.WriteLine();

                    switch (input)
                    {
                        case "1":
                            Console.Write("Escribe tu decisión: ");
                            string decision = Console.ReadLine();
                            president.MakeDecision(decision);
                            decisions.AddDecision(decision);
                            break;

                        case "2":
                            decisions.ShowHistory();
                            break;

                        case "3":
                            Console.Write("Escribe una solicitud ciudadana: ");
                            string req = Console.ReadLine();
                            requests.AddRequest(req);
                            break;

                        case "4":
                            requests.ShowRequests();
                            Console.Write("Número de solicitud a procesar: ");
                            if (int.TryParse(Console.ReadLine(), out int num))
                                requests.ProcessRequest(num);
                            else
                                Console.WriteLine("Número inválido.");
                            break;

                        case "5":
                            Console.Write("Nombre del nuevo miembro: ");
                            string addName = Console.ReadLine();
                            education.AddMember(new President(addName));
                            break;

                        case "6":
                            Console.Write("Nombre del miembro a quitar: ");
                            string removeName = Console.ReadLine();
                            education.RemoveMember(removeName);
                            break;

                        case "7":
                            education.ShowMembers();
                            break;

                        case "8":
                            Console.WriteLine("Simulación finalizada.");
                            return;

                        default:
                            Console.WriteLine("Opción no válida.");
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error capturado: {ex.Message}");
            }
        }

    }
}