using System;
using System.Text;
using ApprovalTests.Core;

namespace FizzBuzz
{
    internal class FizzBuzzPrinter
    {
        public FizzBuzzPrinter()
        {
        }

        internal string PrintLine(int lineNumber)
        {
            StringBuilder stringToReturn = new StringBuilder();
            if (lineNumber % 3 == 0) { stringToReturn.Append("Fizz"); }
            if (lineNumber % 5 == 0) { stringToReturn.Append("Buzz"); }
            if (stringToReturn.Length == 0) { return lineNumber.ToString(); }
            return stringToReturn.ToString();
            
        }

        internal string PrintLines(int from, int to)
        {
            StringBuilder returnString = new StringBuilder();
            for (int currentLine = from; currentLine<= to; currentLine++)
            {
                returnString.AppendLine(PrintLine(currentLine));
            }
            return returnString.ToString();
        }
    }
}