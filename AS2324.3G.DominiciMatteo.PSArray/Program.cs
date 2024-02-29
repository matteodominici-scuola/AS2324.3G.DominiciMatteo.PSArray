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
            CaricaVettori(ref voti, ref pesi, nVoti);
            StampaVotiPesi(voti, pesi, nVoti);
            StampaVotiDispariMaggiori4(ref voti, ref pesi, nVoti);
        }
        static void StampaVotiPesi(double[] voti, int[] pesi, int nVoti)
        {
            Console.WriteLine("Voti pesi");
            for (int i = 0; i < nVoti; i++)
            {
                Console.WriteLine($"{voti[i]}    {pesi[i]}");
            }
        }
        static void CaricaVettori(ref double[] voti, ref int[] pesi, int nVoti)
        {
            Random random = new Random();
            for(int i = 0;i < nVoti; i++)
            {
                voti[i] = random.Next(1, 11);
                pesi[i] = random.Next(0, 101);
            }
        }
        static void StampaVotiDispariMaggiori4(ref double[] voti, ref int[] pesi, int nVoti)
        {
            Console.WriteLine("I voti in posizione dispari e maggiori di 4 sono:");
            for(int i = 0; i < nVoti ; i++)
            {
                if (voti[i]>4)
                {
                    Console.WriteLine($"{voti[i]}    {pesi[i]}");
                }
            }
        }
    }
}
