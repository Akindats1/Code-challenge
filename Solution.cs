using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeChallenge
{
    public class Solution
    {
        public int commonChild(string s1, string s2)
        {
            int count = 0;
            
            for(int i = 0; i < s1.Length; i++)
            {
                for(int j = 0; j < s2.Length; j++)
                {
                    if(s1[i] == s2[j])
                    {
                        s2 = s2.Remove(j, 1);
                        count++;
                        break;

                    }
                }
            }
            return count;
        }


       public string Winner(int n)
       {
            string winner = string.Empty;

            if(n == 1)
            {
                winner = "Richard";
            }
             
            else if(n > 1)
            {
               ToPowerOfTwo(n)
            }
        }




        public bool ToPowerOfTwo(int number)
        {
            while(number > 1)
            {
                if(number % 2 != 0)
                {
                    return false;
                }
                else if(number / 2 = 2)
                {
                    return true;
                }
                   
            }
        }



        public string balancedSums(int[] arr)
        {
            // string number = arr.ToString();

            // string firstHalf = number.Substring(0, number.Length / 2);
            // string secondHalf = number.Substring(number.Length / 2);

            // int firstSum = 0;
            // int secondSum = 0;

            // for(int i = 0; i < firstHalf.Length; i++)
            // {
            //     firstSum += firstHalf[i];
            //     secondSum += secondHalf[i];
            // }

            // if(firstSum != secondSum)
            // {
            //     return "NO";
            // }
            // else
            // {
            //     return "YES";
            //}


            for(int i = 1; i < arr.Length - 1; i++)
            {
                int firstSum = 0; int secondSum = 0;
                for(int j = i - 1; j >= 0; j--)
                {
                    firstSum += arr[j];
                }
            }

            for(int j = i + 1; j < arr.Length; j++)
            {
                secondSum += arr[j];
            }

            if(firstSum == secondSum)
            {
                return "YES"
            }
            return "NO"
        }


        // public string Paragraph(string sentence)
        // {
        //     string sentence = Console.ReadLine();
        //     char[] SentenceToChar = sentence.ToCharArray();

        //     foreach (char[] item in SentenceToChar)
        //     {
        //         if()
        //     }
        // }



        

    }
}