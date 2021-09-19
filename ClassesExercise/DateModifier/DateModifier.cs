using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
   public class DateModifier
    {
        public string FirstDate { get; set; }
        public string SecondDate { get; set; }

        public DateModifier(string firstDate , string secondDate)
        {
            FirstDate = firstDate;
            SecondDate = secondDate;
        }

        public void DifferenceInDays()
        {
            int firstDateYear = int.Parse(FirstDate.Substring(0, 4));
            int firstDateMonth = int.Parse(FirstDate.Substring(5, 2));
            int firstDateDay = int.Parse(FirstDate.Substring(8, 2));
            int secondDateYear = int.Parse(SecondDate.Substring(0, 4));
            int secondDateMonth = int.Parse(SecondDate.Substring(5, 2));
            int secondDateDay = int.Parse(SecondDate.Substring(8, 2));
            var firstDate = new DateTime(firstDateYear, firstDateMonth, firstDateDay);
            var secondDate = new DateTime(secondDateYear, secondDateMonth, secondDateDay);
            var result = secondDate - firstDate;
            string[] results = result.ToString().Split('.');
            Console.WriteLine(Math.Abs(int.Parse(results[0])));  
        }
    }
}
