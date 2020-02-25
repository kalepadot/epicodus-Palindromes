using System;
using System.Collections.Generic;

static class Palindrome
{
  public static string ReverseString(string s)
  {
    char[] arr = s.ToCharArray();
    Array.Reverse(arr);
    return new string(arr);
  }
}

public class Program
{
  public static void Main()
  {
    Console.WriteLine("Enter a word that could be a palindrome");
    string userInput = Console.ReadLine();
    if ( userInput == Palindrome.ReverseString(userInput)) 
    {
      Console.WriteLine("This is a Palindrome");
    }   
    else 
    {
      Console.WriteLine("This is not a Palindrome");
    }
  }
}


