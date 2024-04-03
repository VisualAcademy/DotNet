using System;

namespace Enrollment
{
    class QuantumIndianBloodCalculator
    {
        static void Main(string[] args)
        {
            // Input fractions as strings
            string fraction1 = "1/8";
            string fraction2 = "1/16";

            // Calculate and simplify QIB, returning the result as a string
            string result = CalculateAndSimplifyQIBAsString(fraction1, fraction2);
            Console.WriteLine(result);
        }

        static string CalculateAndSimplifyQIBAsString(string fraction1, string fraction2)
        {
            // Parse input fractions
            (int num1, int den1) = ParseFraction(fraction1);
            (int num2, int den2) = ParseFraction(fraction2);

            // Convert fractions to a common denominator and sum
            int commonDenominator = den1 * den2;
            int sumNumerator = (num1 * den2) + (num2 * den1);

            // Divide the sum by 2 (multiplying denominator by 2)
            commonDenominator *= 2;

            // Simplify the resulting fraction
            (int simplifiedNum, int simplifiedDen) = SimplifyFraction(sumNumerator, commonDenominator);

            // Return result as a string
            return $"{simplifiedNum}/{simplifiedDen}";
        }

        static (int, int) ParseFraction(string fraction)
        {
            string[] parts = fraction.Split('/');
            int numerator = int.Parse(parts[0]);
            int denominator = int.Parse(parts[1]);
            return (numerator, denominator);
        }

        static (int, int) SimplifyFraction(int numerator, int denominator)
        {
            int gcd = GCD(numerator, denominator);
            return (numerator / gcd, denominator / gcd);
        }

        static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
    }
}
