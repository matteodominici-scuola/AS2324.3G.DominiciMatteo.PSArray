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
            double max = 0;
            double min = 0;
            int posMax = 0;
            int posMin = 0;
            CaricaVettori(ref voti, ref pesi, nVoti);
            StampaVotiPesi(voti, pesi, nVoti);
            StampaVotiDispariMaggiori4(ref voti, ref pesi, nVoti);
            double media = MediaPonderata(voti, pesi, nVoti, ref max, ref posMax, ref min, ref posMin);
            Console.WriteLine($"La media ponderata dei voti è {media}, il voto massimo è {max} ed è in posizione {posMax}, il voto minimo è {min} ed è in posizione {posMin}.");
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
        static double MediaPonderata(double[] voti, int[] pesi, int nVoti, ref double max, ref int posmax, ref double min, ref int posmin)
        {
            double sommaVotiPonderata = 0;
            double sommaPesi = 0;
            max = voti[0];
            min = voti[0];
            for(int i = 0; i < nVoti ; i++)
            {
                sommaVotiPonderata += voti[i] * pesi[i];
                sommaPesi += pesi[i];
                if (voti[i] > max)
                {
                    max = voti[i];
                    posmax = i;
                }
                if (voti[i] < min)
                {
                    min = voti[i];
                    posmin = i;
                }
            }
            return sommaVotiPonderata / sommaPesi;
        }
    }
}
