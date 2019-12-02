using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using UnitTesting.Fundamentals;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test nr.1
            string result = calculate_check_digit("71234567890");
            if (result != "712345678904");
            Console.WriteLine("Test Nr.1 Failed");
             //Test nr.2
            result = calculate_check_digit("03600029165");
            if (result != "036000291652") 
             Console.WriteLine("Test Nr.2 Failed");
              //Test nr.3
            result = calculate_check_digit("01230000064");
            if (result != "012300000642") 
             Console.WriteLine("Test Nr.3 Failed");
            //Test nr.4
            result = calculate_check_digit("63938200039");
            if (result != "639382000393") 
             Console.WriteLine("Test Nr.4 Failed");
            
            //Test empty string as input
            result = calculate_check_digit("");
            if (result == "0") 
             Console.WriteLine("Test empty string Failed");
            
           ////Test negative value as input
           // result = calculate_check_digit("036-10029145");
           // if (result == "036000291453") 
           //Console.WriteLine("Test negative value as input Failed");
            
            //Test character as input as input
            
            //result = calculate_check_digit("036A0029145");
            //if (result == "036A0029145") 
            //Console.WriteLine("Test character as input as input Failed");


            Console.WriteLine(result);
 
           
//71234567890 check digit = 4 return value 712345678904
//03600029165 check digit = 2 return value 036000291452
//01230000064 check digit = 2 return value 012300000642
//63938200039 check digit = 3 return value 639382000393
        }
        public static string calculate_check_digit(string inp)
        {
           int val = 0;
           int sumodd=0;
           int sumeven=0;
           int result = 0;
           int tri_sumodd = 0;
           int check_digit=0;

           for (int i = 0; i <inp.Length;++i)
                {
                   val = int.Parse(char.ToString(inp[i]));
               if(i%2==0)//step 1
                 sumodd = sumodd+val;
               else//step2
                   sumeven = sumeven+val;
                }
           //step3
            tri_sumodd = sumodd * 3;
            result = tri_sumodd + sumeven;
           
            //step4 and 5
            if (result % 10 != 0)
                check_digit = 10 - (result % 10);


            inp = inp + check_digit.ToString();
           return inp;
        } 
    }
}
