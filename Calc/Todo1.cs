using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp7
{
    public class FindUniqueNamesWithVowels
    {
        public  static void  GetUniqueWords(string[] names1, string[] names2)
        {
            // Function to check if first character is vowel 
            

                var queryResults1 = from n in names1
                                   where n.StartsWith("a") || n.StartsWith("A") ||
                                   n.StartsWith("e") || n.StartsWith("E") ||
                                   n.StartsWith("i") || n.StartsWith("I") ||
                                   n.StartsWith("o") || n.StartsWith("O") ||
                                   n.StartsWith("u") || n.StartsWith("U") 
                                  select n;

                var queryResults2 = from n in names2
                                    where n.StartsWith("a") || n.StartsWith("A") ||
                                    n.StartsWith("e") || n.StartsWith("E") ||
                                    n.StartsWith("i") || n.StartsWith("I") ||
                                    n.StartsWith("o") || n.StartsWith("O") ||
                                    n.StartsWith("u") || n.StartsWith("U")
                                  select n;



            var all = queryResults1.Union(queryResults2).ToArray();


         //   bool isUnique = all.Distinct().Count() == all.Count(); //to check whether all values are distinct or not
            string[] q = all.ToArray(); //creating an array

            

            foreach (var query in q)
            {
                Console.WriteLine(query);
                Console.ReadLine();

            }

          //  return isUnique;

        }

        static void Main(string[] args)
        {
            //TODO 1: Implement GetUniqueWords function, such that the returned array has no duplicates and has only words starting with a vowel
            //TODO 2: Also implement the Nnuit test for the class FindUniqueNamesWithVowels

            string[] names1 = new string[] { "Amazon", "Elephant", "Uber", "good" };
            string[] names2 = new string[] { "English", "France", "Elephant" };
            //Console.WriteLine(GetUniqueWords(names1, names2)); // should print Amazon, Elephant, Uber, English
            GetUniqueWords(names1, names2);
            
        }
    }

    
}
