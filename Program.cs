using System;

namespace StringInterpA3
{
    class Program
    {
        static void Main(string[] args)
        {
            var date = DateTime.Now;
            Console.WriteLine($"{date,40:MMMM dd, yyyy}");
            Console.WriteLine($"{date:yyyy.MM.dd}");
            Console.WriteLine($"{date:'Day' dd 'of' MMMM, yyyy}");
            Console.WriteLine($"{date:'Year:' yyyy, 'Month:' MM, 'Day:' dd}");
            Console.WriteLine($"{date,10:dddd}");
            Console.WriteLine($"{date:hh:mm tt}");
            Console.WriteLine($"{date:'h':hh,'m':mm,'s':ss}");
            Console.WriteLine($"{date:yyyy.MM.dd.hh.mm.ss}");
            Console.WriteLine("");
            var pi = Math.PI;
            Console.WriteLine($"${pi:F2}");
            Console.WriteLine($"{pi,10:F3}");

        }
    }
}
