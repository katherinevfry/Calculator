using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an operator (+, /, *, ^, avg) followed by a comma seperated list of numbers");
            var userInput = Console.ReadLine();
            var splitInput = userInput.Split(' ');

            var op = splitInput[0];
            var numList = splitInput[1];
            var nums = numList.Split(',');

            switch (op)
            {
                case "+":
                    var sum = 0;
                    foreach (var n in nums)
                    {
                        var newNum = int.Parse(n);
                        sum += newNum;
                    }
                    Console.WriteLine(sum);
                    break;
                case "avg":
                    var start = 0m;
                    var loopC = 0m;
                    foreach (var n in nums)
                    {
                       var newNum = int.Parse(n);
                        start += newNum;
                       loopC ++;
                    }
                    var avgFinal = start / loopC;
                    Console.WriteLine(avgFinal);
                    break;
                case "*":
                    var result = 1;
                    foreach (var n in nums)
                    {
                        var newNum = int.Parse(n);
                        result *= newNum;
                    }
                    Console.WriteLine(result);
                    break;
                case "/":
                    var intV = Decimal.Parse(nums[0]);
                    var output = intV * intV;
                    foreach (var n in nums)
                    {
                        var newNum = Decimal.Parse(n);
                        output /= newNum;
                    }
                    Console.WriteLine(output);
                    break;
                case "^":
                    var sqr = "";
                    foreach (var n in nums)
                    {
                        var newNum = int.Parse(n);
                        var total = newNum * newNum;
                        sqr += total.ToString() + ',';
                    }
                    Console.WriteLine(sqr); ;
                    break;
                default:
                    Console.WriteLine("choose an option please");
                    break;
            }
        }
    }
}
