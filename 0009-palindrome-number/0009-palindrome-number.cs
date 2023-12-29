public class Solution 
{
    public bool IsPalindrome(int x) 
    {
        string digits = x.ToString();
        string reversedDigits = ReverseString(digits);
        
        return digits == reversedDigits;
    }
    
    public string ReverseString(string str)
    {
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}