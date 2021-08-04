
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
    public static float CheckNumberFloat(float firstNumber, float secondNumber, float thirdNumber)
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

    public static string CheckStringMax(string firstString, string secondString, string thirdString)
    {
        if (firstString.CompareTo(secondString) > 0 && firstString.CompareTo(thirdString) > 0 )       
        {
            return firstString;
        }
        if (secondString.CompareTo(firstString) > 0 && secondString.CompareTo(thirdString)>0)           
        {
            return secondString;
        }
        if (thirdString.CompareTo(firstString) > 0 && thirdString.CompareTo(secondString) > 0)
        {
            return thirdString;
        }
        throw new Exception("firstString,SecondString,thirdString are same");
    }
}

