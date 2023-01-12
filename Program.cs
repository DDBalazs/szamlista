namespace Hehe
{
    class Program
    {
        static List<int> szam_list = new List<int>();
        static List<int> tiszta_list = new List<int>();
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            //Listák
            for (int i = 0; i < 200; i++)
            {
                szam_list.Add(rnd.Next(1, 51));
            }

            //Kiiratás
            for (int i = 0; i < szam_list.Count; i++)
            {
                if (i % 20 == 0)
                {
                    Console.Write("\n");
                }
                Console.Write($"{szam_list[i]:00} , ");
            }
            //Fájlba kiiratni txt, csv UTF 8 kódolású ami ismeri az ékezetes betűket
            var sw = new StreamWriter(@"C:\Users\csoke.balazs\Documents\asd\kaki.txt", false, System.Text.Encoding.UTF8);
            for (int i = 0; i < szam_list.Count; i++)
            {
                if (i % 20 == 0)

                { sw.Write("\n"); }
                sw.Write($"{szam_list[i]:00} , ");

            }
            sw.Close();
            Console.WriteLine();
            Console.WriteLine("\n-----------------------------------");
            Console.WriteLine("\t[Lista tisztítása]");

            foreach (var sz in szam_list)
            {
                if (!tiszta_list.Contains(sz))
                { tiszta_list.Add(sz); }
            }
            Console.WriteLine($"\nTiszta lista nagysága: {tiszta_list.Count}.");

            Console.WriteLine("\n-----------------------------------");
            Console.WriteLine("\t[Statisztika]");
            Console.WriteLine();
            tiszta_list.Sort();
            tiszta_list.Reverse();
            foreach (var t in tiszta_list)
            {
                int dbstat = 0;

                foreach(var sz in szam_list)
                {
                    if (t == sz)
                    {
                        dbstat++;
                    }
                }
                Console.WriteLine($"{t:00} : {dbstat} db");
            }
            Console.WriteLine("\n-----------------------------------");
            Console.WriteLine("\t[Elem hozzáadása + 245]");
            szam_list.Add(245);
            Console.WriteLine($"\núj lista hossza: {szam_list.Count}");
            Console.WriteLine("\n-----------------------------------");
            int osszeg = szam_list.Sum();
            Console.WriteLine($"\nA lista összege: {osszeg}");
            Console.WriteLine("\n-----------------------------------");
            Console.WriteLine("\t[Maximum vagy minimum]");
            int Max = szam_list.Max();
            Console.WriteLine($"\nA legnagyobb értéke a listának: {Max}");
            int MaxHely = szam_list.IndexOf(Max);
            Console.WriteLine($"\nA legkissebb értéke a listának: {MaxHely+1}");
            Console.WriteLine("\n-----------------------------------");
        }
    }
}