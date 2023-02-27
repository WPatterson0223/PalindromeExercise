using System;
namespace PalindromeExercise
{
	public class WordSmith
	{
		public WordSmith()
		{
		}
		public bool IsAPalindrome(string str)
		{
            char[] charArray = str.ToLower().ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray) == str.ToLower();
            
		}
	}
}

