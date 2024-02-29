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
            Console.WriteLine($"La media ponderata dei voti è {media}, il voto massimo è {max} ed è in posizione {posMax+1}, il voto minimo è {min} ed è in posizione {posMin+1}.");
            Console.WriteLine("Inserisci un voto per ottenere l'elenco dei voti maggiori e minori di 0.5");
            double votoSelezionato = double.Parse(Console.ReadLine());
            ElencoVotiNellIntorno(voti, pesi, nVoti, votoSelezionato);
            OrdinaPerVoto(ref voti, ref pesi, nVoti);
            Console.WriteLine("Voti in ordine:");
            StampaVotiPesi(voti, pesi, nVoti);
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
                voti[i] = random.NextDouble()*10+1;
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
                    posmax = i+1;
                }
                if (voti[i] < min)
                {
                    min = voti[i];
                    posmin = i+1;
                }
            }
            return sommaVotiPonderata / sommaPesi;
        }
        static void ElencoVotiNellIntorno(double[] voti, int[] pesi, int nVoti, double voto)
        {
            double diffPoss = 0.5;
            Console.WriteLine($"Elenco dei voti maggiori o minori di 0.5 rispetto a {voto}:");
            for (int i = 0; i < nVoti; i++)
            {
                double differenza = voti[i] - voto;
                if (differenza <= diffPoss && differenza >= -diffPoss)
                {
                    Console.WriteLine($"{voti[i]}    {pesi[i]}");
                }
            }
        }
        static void OrdinaPerVoto(ref double[] voti, ref int[] pesi, int nVoti)
        {
            bool scambiato;
            do
            {
                scambiato = false;
                for (int i = 0; i < nVoti - 1; i++)
                {
                    if (voti[i] > voti[i + 1])
                    {
                        double tempVoto = voti[i];
                        int tempPeso = pesi[i];
                        voti[i] = voti[i + 1];
                        pesi[i] = pesi[i + 1];
                        voti[i + 1] = tempVoto;
                        pesi[i + 1] = tempPeso;
                        scambiato = true;
                    }
                }
            } while (scambiato);
        }
    }
}
