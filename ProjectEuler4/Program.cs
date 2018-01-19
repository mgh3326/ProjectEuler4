using System;

namespace ProjectEuler4
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var max = 0;
            for (var i = 100; i < 1000; i++)
            {
                for (var j = 100; j < 1000; j++)
                {
                    var str = (i * j).ToString();
                    for (var k = 0; k < str.Length / 2; k++)
                    {
                        if (str[k] != str[str.Length - 1 - k])
                            break;
                        if (str[k] != str[str.Length - 1 - k]) continue;
                        if (k != str.Length / 2 - 1) continue;
                        if (max < Convert.ToInt32(str))
                            max = Convert.ToInt32(str);
                        //Console.WriteLine(str);
                    }
                }
            }
            Console.WriteLine("max : " + max);
        }
    }
}
