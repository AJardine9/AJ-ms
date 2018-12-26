using System;
using System.Collections.Generic;
using System.Text;

namespace Palindrome.Library
{
    public class Palindrome
    {
        string Pword;

        public void VPalindrome (string word)
       {
         Console.WriteLine("Check if a word is a Palindrome?");
            Pword = Console.ReadLine();
              Char[]chars  = word.ToLower().ToCharArray();
            for (int i = 0, j = chars.Length - 1; i < j; i++, j--)


                if (chars[i] != chars[j])
                    return false;
            



        }





        

    }
}
