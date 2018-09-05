using System;

namespace convertNumbersToWords
{
    internal class Program
    {
        static string[] ones={"one","two","three","four","five","six"," seven", "eight","nine","ten","eleven","twelve","thirteen","forteen","fifteen","sixteen","seventeen","eighteen","ninteen"};      
        static string[] tens={"twenty","thirty","fourty","fifty","sixty","seventy","eighty","ninty"}; 
        
        public static void Main(string[] args)
        {
            
            //Collects user input
            
            Console.WriteLine("Enter the Number:"); 
            
            //Converts to an integer value
            int number=Int32.Parse(Console.ReadLine());
            

            if (number <= 19)
            {  
                Console.WriteLine(writeOnes(number));

            }
            else if (number > 19)
            {
                splitNumber(number);

            }
        }
        
        //This method finds word for value from 1 to 19
        public static string writeOnes(int numberToWrite)
        {
            string answer = ones[numberToWrite - 1];
                
            return answer;
        }
        
        //This method finds word for value from 1 to 19

        public static string writeTens(int numberToWrite)
        {
            string answer = tens[numberToWrite - 2];

            return answer;
        }
        
        
        //This method splits the number into two and uses the appropriate method(s)

        public static void splitNumber(int numberToWrite)
        {
            int chkAns = numberToWrite / 10;
            int chkMod = numberToWrite % 10;

            if (chkMod == 0)
            {
                Console.WriteLine(writeTens(chkAns));
            }
            else
            {
                Console.WriteLine(writeTens(chkAns) + " " + writeOnes(chkMod));
            }
        }
        
    }
}

