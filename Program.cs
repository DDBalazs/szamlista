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
            Console.WriteLine("\n----------------------------");
            Console.WriteLine("\t[Lista tisztítása]");

            foreach (var sz in szam_list)
            {
                if (!tiszta_list.Contains(sz))
                { tiszta_list.Add(sz); }
            }
            Console.WriteLine($"\nTiszta lista nagysága: {tiszta_list.Count}.");

            Console.WriteLine("\n----------------------------");
            Console.WriteLine("\t[Statisztika]");
            Console.WriteLine();
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








        }
    }
}