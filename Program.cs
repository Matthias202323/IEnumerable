
namespace IEnumerable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrez un nombre entre 1 et 10");
            string input= Console.ReadLine();
            int y = int.Parse(input);
            int somme = 0;
            List<int> integers = new List<int> {  1, 2, 3, 4, 5, 6, 7, 8, 9 ,10};
            IEnumerable<int> integersLowerThanY = integers.Where((x) => x < y);
            int sum = integersLowerThanY.Aggregate((x, y) => x + y);
            int length = integersLowerThanY.Count();   
            Console.WriteLine("moyenne = " + sum/length);
           
        }
    }
}
