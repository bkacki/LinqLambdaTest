namespace LinqLambdaTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var array = new[] { 1, 2, 3, 4, 5 };
            var result =
                from i in array
                select i * 2;
            foreach(var i in result) 
                Console.WriteLine(i);
            var linqResult = array.Select(i => i*2);
            foreach(var i in linqResult)
                Console.WriteLine(i);

            Console.WriteLine();

            int[] values = new int[] { 0, 12, 44, 36, 92, 54, 13, 8 };
            IEnumerable<int> result2 =
                from v in values
                where v < 37
                orderby v descending
                select v;
            foreach(var i in result2 ) 
                Console.WriteLine(i);

            var linqResult2 = values.Where(v => v < 37).OrderBy(v => -v); //lub .OrderByDescending
            foreach (var i in linqResult2)
                Console.WriteLine(i);
        }
    }
}
