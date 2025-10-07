using L2O___D09;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Linq1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Find all products that are out of stock. 
            var re1 = ListGenerators.ProductList.Where(x => x.UnitsInStock == 0);
            foreach (var x in re1)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("---------------------------");

            //2. Find all products that are in stock and cost more than 3.00 per unit. 
            var re2 = ListGenerators.ProductList.Where(x => x.UnitsInStock >= 1 && x.UnitPrice > 3);
            foreach (var x in re2)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("---------------------------");

            //3. Returns digits whose name is shorter than their value. 
            string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" }; 
            //var re3=Arr.Find(a=>a.Length >


            //1. Get first Product out of Stock  
            var re4 = ListGenerators.ProductList.FirstOrDefault(x => x.UnitsInStock == 0);
            Console.WriteLine(re4);
            Console.WriteLine("---------------------------");

            //2.Return the first product whose Price > 1000, unless there is no match, in which case null is returned.
            var re5 = ListGenerators.ProductList.FirstOrDefault(x => x.UnitPrice > 1000);
            Console.WriteLine(re5);
            Console.WriteLine("---------------------------");


            //3.Retrieve the second number greater than 5
            int[] Arr2 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var re6 = Arr2.Skip(1).FirstOrDefault(x => x > 5);

            Console.WriteLine(re6);
            Console.WriteLine("---------------------------");


            //1.Find the unique Category names from Product List
            var re0=ListGenerators.ProductList.DistinctBy(x => x.ProductName);
            Console.WriteLine(re0);
            Console.WriteLine("---------------------------");

            //2.Produce a Sequence containing the unique first letter from both product and customer names.
            var re7 = ListGenerators.ProductList.Select(p => p.ProductName[0])
            .Union(ListGenerators.CustomerList.Select(c => c.CompanyName[0]));

            foreach (var x in re7)
            {
                Console.WriteLine(x);
            }

            //3. Create one sequence that contains the common first letter from both product and customer names. 

            var re8 = ListGenerators.ProductList.Select(p => p.ProductName[0])
            .Intersect(ListGenerators.CustomerList.Select(c => c.CompanyName[0]));
            foreach (var x in re8)
            {
                Console.WriteLine(x);
            }

            //4. Create one sequence that contains the first letters of product names that are not also first letters of customer names

            var re9 = ListGenerators.ProductList.Select(p => p.ProductName[0])
            .Except(ListGenerators.CustomerList.Select(c => c.CompanyName[0]));

            foreach (var x in re9)
            {
                Console.WriteLine(x);
            }
            //5. Create one sequence that contains the last Three Characters in each names of all customers and products, including any duplicates 


            //var re10=
            //Uses Count to get the number of odd numbers in the array

            int[] Arr3 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            int re11 = Arr3.Count(n => n % 2 != 0);
            Console.WriteLine(re11);
            Console.WriteLine("------------------------");

            //2. Return a list of customers and how many orders each has. 
            var re12 =ListGenerators.CustomerList
           .Select(c => new { c.CompanyName, OrdersCount = c.Orders.Count() });
            Console.WriteLine(re12);
            Console.WriteLine("------------------------");

            //Return a list of categories and how many products each has

            var re13 = ListGenerators.ProductList
            .GroupBy(p => p.Category)
            .Select(g => new { Category = g.Key, ProductCount = g.Count() });
            // Get the total of the numbers in an array
            int total = Arr3.Sum();
            Console.WriteLine(total);
            Console.WriteLine("------------------------");

            //Get the total number of characters of all words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).

            //var re14 = File.ReadAllLines("dictionary_english.txt");
            //int totalCh= re14.Sum(w => w.Length);
            //Console.WriteLine(totalCh);
            //Get the total units in stock for each product category.
            var re15 = ListGenerators.ProductList
            .GroupBy(p => p.Category)
            .Select(g => new { Category = g.Key, TotalUnits = g.Sum(p => p.UnitsInStock)
            });
            foreach (var x in re15)
            {
                Console.WriteLine(x);
            }

            //7.Get the length of the shortest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First)
            int shortest = re14.Min(w => w.Length);
            Console.WriteLine(shortest);

            //8.Get the cheapest price among each category's products
            var re16 = ListGenerators.ProductList.GroupBy(p => p.Category)
           .Select(g => new { Category = g.Key, MinPrice = g.Min(p => p.UnitPrice) });


            //Get the length of the longest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            int longest = re14.Max(w => w.Length);
            Console.WriteLine(longest);
            // Get the most expensive price among each category's products. 
            var re17= ListGenerators.ProductList.GroupBy(p => p.Category)
            .Select(g => new { Category = g.Key, MaxPrice = g.Max(p => p.UnitPrice) });
            //13. Get the average length of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First). 
            double avgLength = re14.Average(w => w.Length);

            //14. Get the average price of each category's products. 
            var re18= ListGenerators.ProductList.GroupBy(p => p.Category)
           .Select(g => new { Category = g.Key, AvgPrice = g.Average(p => p.UnitPrice) });
            Console.WriteLine(re18);

            //1. Sort a list of products by name 
            var sort = ListGenerators.ProductList
             .OrderBy(p => p.ProductName);
            foreach (var x in sort)
            {
                Console.WriteLine(x);
            }


            string[] Arr4 = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //2. Uses a custom comparer to do a case-insensitive sort of the words in an array.
            var re19 = Arr4.OrderBy(x => x, StringComparer.OrdinalIgnoreCase);
            foreach (var x in re19)
            {
                Console.WriteLine(x);
            }
            // Sort a list of products by units in stock from highest to lowest. 
            var RE20 = ListGenerators.ProductList
              .OrderByDescending(p => p.UnitsInStock);
            foreach (var x in RE20)
            {
                Console.WriteLine(x);
            }

            // Sort a list of digits, first by length of their name, and then alphabetically by the name itself.           
            string[] Arr5 = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            var re21= Arr5.OrderBy(d => d.Length).ThenBy(d => d);

            // Sort first by word length and then by a case-insensitive sort of the words in an array. 
            string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            var re22=words.OrderBy(w => w.Length).ThenBy(w => w, StringComparer.OrdinalIgnoreCase);
            foreach (var x in re22)
            {
                Console.WriteLine(x);
            }


            // Sort a list of products, first by category, and then by unit price, from highest to lowest. 
            var re23= ListGenerators.ProductList.OrderBy(p => p.Category).ThenByDescending(p => p.UnitPrice);
            foreach (var x in re23)
            {
                Console.WriteLine(x);
            }

            // Sort first by word length and then by a case-insensitive descending sort of the words in an array
            string[] Arr6 = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" }; 
            var re24=Arr6.OrderBy(w => w.Length).ThenByDescending(w => w, StringComparer.OrdinalIgnoreCase);
            foreach (var x in re24)
            {
                Console.WriteLine(x);
            }
            // Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array. 
            string[] Arr7 = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            var reversed = Arr7.Where(d => d.Length > 1 && d[1] == 'i').Reverse();
            foreach (var x in reversed)
            {
                Console.WriteLine(x);
            }
               

              








        }
    }
}
