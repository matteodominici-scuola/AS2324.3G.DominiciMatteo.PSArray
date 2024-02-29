namespace AS2324._3G.DominiciMatteo.PSArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Matteo Dominici; 3G; 29/02/2024; Proca singola Array");
            Console.WriteLine("Inserisci il numero di voti");
            int nVoti = int.Parse(Console.ReadLine());
            double[] voti = new double[nVoti];
            int[] pesi = new int[nVoti];
            StampaVotiPesi(voti, pesi, nVoti);
        }
        static void StampaVotiPesi(double[] voti, int[] pesi, int nVoti)
        {
            Console.WriteLine("Voti, pesi");
            for (int i = 0; i < nVoti; i++)
            {
                Console.WriteLine($"{voti[i]}, {pesi[i]}");
            }
        }
    }
}
