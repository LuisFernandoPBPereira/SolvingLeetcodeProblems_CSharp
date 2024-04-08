public class Solution {
    public bool IsPalindrome(string s) {
        if (s == " ")
            return true;

        string palindrome = s;

        palindrome = palindrome.ToLower();
        s = s.ToLower();

        for (int i = 0; i < palindrome.Length; i++)
        {
            if (char.IsSymbol(palindrome[i]) || 
                char.IsPunctuation(palindrome[i]))
            {
                palindrome = palindrome.Replace(palindrome[i].ToString(), "");
            }
            if (char.IsSymbol(s[i]) || char.IsPunctuation(s[i]))
            {
                s = s.Replace(s[i].ToString(), "");
            }
        }
        //Alguns caracteres não estavam sendo removidos - Descobrir a causa.
        s = s.Replace(" ", "");
        palindrome = palindrome.Replace(" ", "");
        s = s.Replace("[", "");
        palindrome = palindrome.Replace("[", "");
        s = s.Replace(")", "");
        palindrome = palindrome.Replace(")", "");

        for (int i = 0, j = s.Length - 1; i < s.Length; i++, j--)
        {
            if (palindrome[i] != s[j])
            {
                return false;
            }
        }
        return true;
    }
}