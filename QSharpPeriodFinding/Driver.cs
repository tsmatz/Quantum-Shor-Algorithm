using Microsoft.Quantum.Simulation.Simulators;

namespace Quantum.QSharpPeriodFinding
{
    class Driver
    {
        static void Main(string[] args)
        {
            using (var qsim = new QuantumSimulator())
            {
                int N, a;

                // answer should be 5
                N = 11;
                a = 5;
                QuantumPeriodFinding.Run(qsim, N, a).Wait();

                // answer should be 4
                N = 15;
                a = 7;
                QuantumPeriodFinding.Run(qsim, N, a).Wait();
            }
        }
    }
}