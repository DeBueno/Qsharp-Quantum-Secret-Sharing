using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;

namespace Quantum.Quantum_Secret_Sharing
{
    class Driver
    {
        static void Main(string[] args)
        {
            using (var sim = new QuantumSimulator())
            {
                System.Console.WriteLine("Message to send(0/1):");
                int msg = System.Convert.ToInt32(System.Console.ReadLine());
                System.Console.WriteLine("Enconding basis - Standard (s) or Hadamard (h)");
                char basis = System.Console.ReadLine().ToString()[0];
                var result = SecretSharing.Run(sim, msg, basis.ToString()).Result; ///VERY VERY IMPORTANT THAT YOU GET THE RESULT - OR WILL TRHOW MEMORY ACCESS VIOLATION
            }
            System.Console.WriteLine("Press any key to continue.");
            System.Console.Read();
        }
    }
}