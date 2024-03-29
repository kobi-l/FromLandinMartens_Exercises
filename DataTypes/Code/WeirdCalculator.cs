﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
	public class WeirdCalculator
	{
		public static long SimpleWholeNumberAdd(int firstValue, long secondValue)
		{
			return (long)firstValue + secondValue;
		}

		public static decimal SimpleDecimalAdd(float firstValue, double secondValue, decimal thirdValue)
		{
			/*
			 * Decimals, Floats and Doubles can be complex (the long comment in `ComplexDecimalAdd` below describes why but read that later).
			 * 
			 * HOWEVER - for this test, don't worry about the complex nature of them, assume all values passed in *CAN* be converted to decimals!
			 * 
			 * Hint: You can make this method's body one line!
			 */

			return (decimal)firstValue + (decimal)secondValue + thirdValue;
		}

		public static decimal ComplexDecimalAdd(float firstValue, double secondValue, decimal thirdValue)
		{
			/*
			 * There's an interesting thing to point out when comparing double/float and decimal:
			 * The range of double is ±5.0 × 10−324 to ±1.7 × 10308, while the range of decimal is (-7.9 x 1028 to 7.9 x 1028) / (100 to 28).
			 * The range of float is half of double.
			 * 
			 * In other words, the range of double / float is several times larger than the range of decimal!!
			 * The reason for this is that they are used for quite different things.
			 * 
			 * Double / float is for larger whole numbers where as decimal is for more percise numbers (more trailing decimal digits)!
			 * 
			 * For this method, we now have to *safely* go between the different types (no more assuming it is going to work!)
			 * 
			 * I will give you one clue / tip - You *will* need to handle exceptions for the final solution.
			 * If you are new to exceptions, google "C# Exception Handling" - litterally half our jobs is googling :P
			 */
			
			try 
			{
				var result = (decimal)firstValue + (decimal)secondValue + thirdValue;
			}
			catch (Exception)
			{
				return 0m;
			}

			return (decimal)firstValue + (decimal)secondValue + thirdValue;
		}

		public static decimal ComplexAdd(char firstValue, string secondValue)
		{
			/*
			 * You will notice the TDD tests around this just "assume" it will work. Do not worry about handling exceptions or errors, assume input is valid.
			 */

			// Converts Char to String and then to Decimal:
			var numOne = Convert.ToDecimal(firstValue.ToString());

			// Parse String to Decimal:
			Decimal.TryParse(secondValue, out decimal numTwo);
			return numOne + numTwo;
		}

		public static decimal ConditionalMath(int firstValue, int secondValue, bool returnNegative)
		{
			var actual = firstValue + secondValue;

			if (actual < 0 && returnNegative)
				return actual;

			else if (actual < 0 && !returnNegative)
				return Math.Abs(actual);

			else if (returnNegative)
				return actual * -1;
			else
				return actual;
		}
	}
}
