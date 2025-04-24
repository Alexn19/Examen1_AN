using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_AlexandraNoriega
{
    public class Simulation
    {
        public void RunSimulation()
        {
            try
            {
                Console.WriteLine("Iniciando simulación de gobierno...");

                throw new Exception("Error en la simulación");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error capturado: {ex.Message}");
            }
        }
    }
}
