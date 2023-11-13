using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Projects
{
    public class Proj30 : BaseProj
    {
        public override string Description => "Write a C# program to convert a hexadecimal number to a decimal number.";

        public override void Run()
        {
            Console.WriteLine("Please enter a hexadecimal number: ");
            var hexaNumber = Console.ReadLine();

            var decimalNumber = ConvertHexToDecimal(hexaNumber);
            Console.WriteLine($"The decimal equivalent of the hexadecimal number {hexaNumber} is {decimalNumber}.");
        }

        public int ConvertHexToDecimal(string hexNumber)
        {
            int decimalNumber = 0;
            for (int i = hexNumber.Length - 1; i >= 0 ; i--)
            {
                int hexDigitValue = GetHexDigitValue(hexNumber[i]);
                decimalNumber += hexDigitValue * (int)Math.Pow(16, i);
            }

            return decimalNumber;
        }

        public int GetHexDigitValue(char hexDigit)
        {
            if (hexDigit >= '0' && hexDigit <= '9')
            {
                return hexDigit - '0';
            }
            else if (hexDigit >= 'A' && hexDigit <= 'F')
            {
                return (hexDigit - 'A' + 10);
            }
            else
            {
                throw new ArgumentException("Invalid hexadecimal digit.");
            }
        }
    }
}
