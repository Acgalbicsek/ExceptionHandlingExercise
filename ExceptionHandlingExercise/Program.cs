using System;
using System.Collections.Generic;
using System.IO;

namespace ExceptionHandlingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new char[] { '1', '2', '3', '4', '5', '6', 'a', 'm', 'y'};
            List<int> numbers = new List<int>();
            string str = "";

            foreach(var item in arr)
            {
                try
                {
                    str = item.ToString();
                    var number = int.Parse(str);

                    numbers.Add(number);

                }catch(Exception e)
                {
                    Console.WriteLine($"Unable to Parse'{item}'");
                }
            }
            foreach(var num in numbers)
            {
                Console.WriteLine(num);
            }
            
            
            // -----------------------------------------------------------------------------
            //done First create an char[], it must contain 6 numbers and 3 letters - name it arr
            //done Create a list called numbers that will hold integers
            //done Create an string variable with an empty string initializer - name it str

            // done using a foreach loop, attempt to parse the elements in your char[] with int.Parse()
            // done and Exceptions will be thrown 
            // done Below we will set this up 
            // ------------------------------------------------------------------------------



            //TODO START HERE:
            
            // done Make a foreach loop to iterate through your character array
            
                // Now create a try catch
                
                
                    // done Inside your try block
                        // set your string variable to each array element in your char[] to .ToString()
                        // Now, using int.Parse, parse your string variable and store in an int variable
                        // Then add each int to your list
                
                // done catch your Exception:
                // in the scope of your catch you can use the following, 
                
                    //done Console.WriteLine($"Unable to Parse '{character}'"); //character will be the name of each item in your collection
                
            

            //done foreach (var num in numbers)
            //{
            //    Console.WriteLine(num);
            //}
        }
    }
}
