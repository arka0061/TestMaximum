
using System;

public class MaximumNumber
{
 
    public static int CheckNumberInteger(int firstNumber, int secondNumber, int thirdNumber)
        {
            if (firstNumber.CompareTo(secondNumber) > 0 && firstNumber.CompareTo(thirdNumber) > 0)
            {
                return firstNumber;
            }
            else if (secondNumber.CompareTo(firstNumber) > 0 && secondNumber.CompareTo(thirdNumber) > 0)
            {
                return secondNumber;
            }
            else if (thirdNumber.CompareTo(firstNumber) > 0 && thirdNumber.CompareTo(secondNumber) > 0)
            {
                return thirdNumber;
            }
            else
            {
                throw new Exception("firstNumber,SecondNumber,ThirdNumber are all equal");
            }
        }
    public static double CheckNumberFloat(double firstNumber, double secondNumber, double thirdNumber)
    {
        if (firstNumber.CompareTo(secondNumber) > 0 && firstNumber.CompareTo(thirdNumber) > 0)
        {
            return firstNumber;
        }
        if (secondNumber.CompareTo(firstNumber) > 0 && secondNumber.CompareTo(thirdNumber) > 0)
        {
            return secondNumber;
        }
        if (thirdNumber.CompareTo(firstNumber) > 0 && thirdNumber.CompareTo(secondNumber) > 0)
        {
            return thirdNumber;
        }
        throw new Exception("firstNumber,SecondNumber,thirdNumber are same");
    }
}

