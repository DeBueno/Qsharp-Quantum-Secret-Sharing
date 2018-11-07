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
                System.Console.WriteLine("Message to send:");
                int msg = System.Convert.ToInt32(System.Console.ReadLine());
                System.Console.WriteLine("Size of the message in bits: ");
                int msgSz = System.Convert.ToInt32(System.Console.ReadLine());
                System.Console.WriteLine("Enconding basis - Standard (s) or Hadamard (h)");
                char basis = System.Console.ReadLine().ToString()[0];

                basis = char.ToUpper(basis);

                System.Console.WriteLine("Bob read in x or y direction? (x/y)");
                char bob = System.Console.ReadLine().ToString()[0];
                bob = char.ToUpper(bob);

                System.Console.WriteLine("Number of iterations: ");
                int iterations = System.Convert.ToInt32(System.Console.ReadLine());
                var result = SecretSharing.Run(sim, msg, msgSz, basis.ToString(), bob.ToString(), iterations).Result;
                if (!result)
                {
                    System.Console.WriteLine("Didn't work...");
                }
            }
            System.Console.WriteLine("Press any key to continue.");
            System.Console.Read();
        }
    }
}
