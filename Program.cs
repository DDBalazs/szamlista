namespace Hehe
{
    class Program
    {
        static List<int> szam_list = new List<int>();
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            //Listák
            for(int i = 0; i < 200; i++)
            {
                szam_list.Add(rnd.Next(1, 51));
            }
        }
    }
}