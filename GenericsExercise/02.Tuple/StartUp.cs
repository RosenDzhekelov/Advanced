using System;

namespace _02.Tuple
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string[] firstInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string names = firstInput[0] + " " + firstInput[1];
            string city = "";
            for (int i = 3; i < firstInput.Length; i++)
            {
                city += firstInput[i] + " ";
            }
            var firstItem1 = new Item1<string>(names);
            var firstItem2 = new Item2<string>(firstInput[2]);
            var firstItem3 = new Item3<string>(city);
            var firstTuple = new Tuple<string, string,string>(firstItem1,firstItem2,firstItem3);
            Console.WriteLine($"{firstTuple.FirstItem.Value} -> {firstTuple.SecondItem.Value} -> {firstTuple.ThirdItem.Value}");
            string[] secondInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var  secondItem1 = new Item1<string>(secondInput[0]);
            var secondItem2 = new Item2<int>(int.Parse(secondInput[1]));
            bool isDrunk = secondInput[2] == "drunk";
            var secondItem3 = new Item3<bool>(isDrunk);
            var secondTuple = new Tuple<string, int, bool>(secondItem1, secondItem2 , secondItem3);
            Console.WriteLine($"{secondTuple.FirstItem.Value} -> {secondTuple.SecondItem.Value} -> {secondTuple.ThirdItem.Value}");
            string[] thirdInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var thirdItem1 = new Item1<string>(thirdInput[0]);
            var thirdItem3 = new Item3<string>(thirdInput[2]);
            var thirdItem2 = new Item2<double>(double.Parse(thirdInput[1]));
            var thirdTuple = new Tuple<string, double , string>(thirdItem1, thirdItem2 , thirdItem3);
            Console.WriteLine($"{thirdTuple.FirstItem.Value} -> {thirdTuple.SecondItem.Value} -> {thirdTuple.ThirdItem.Value}");

        }
    }
}
