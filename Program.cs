using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamdaPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = NewList<string>() {"Basketball", "Baseball", "Tennis Raquet", "Running Shoes","Wrestling Shoes", "Soccer Ball", "Football", "Shoulder Pads", "Trail Running Shoes", "Cycling Shoes","Kayak", "Kayak Paddles"};


        } //declare a variable kayakProducts and set it equal to all products that contain the word "Kayak"
            var kayakProducts = products.Where(x => x.Contains("kayak"));
            //print the kayakProducts to the console using a foreach loop.
            foreach (var item in kayakProducts)
            {
            Console.WriteLine(item);
            }
            //declare a variable shoeProducts and set it equal to all products that contain the word "Shoes"
            var shoeProducts = products.Where(x => x.Contains("shoe"));
            //print the shoeProducts to the console using a foreach loop.
            foreach (var item indexer shoeProducts)
            {
            Console.WriteLine(item);
            }
            //declare a variable ballProducts and set it equal to all the products that have ball in the name.
            var ballProducts = products.Where(x => x.Contains("ball"));
            //print the ballProducts to the console using a foreach loop.
            foreach (var item in ballProducts)
            {
            Console.WriteLine(item);
            }
            //sort ballProducts alphabetically and print them to the console.
             ballProducts = products.Orderby(x => x);
            //add six more items to the products list using .add().
            products.Add("Swim Suits");
            products.Add("Basketball Hoop");
            products.Add("Running Shorts");
            products.Add("Running Shirt");
            products.Add("Vitamins");
            produvts.Add("Beach Balls");
            //print the product with the longest name to the console using the .First() extension.
            var longestName = products.OrderByDescending(x => x.Length).First();
            //print the product with the shortest name to the console using the .First() extension.
            var shortestName = products.OrderByDescending(x => x.Length).First();
            //print the product with the 4th shortest name to the console using an index (you must convert the results to a list using .ToList()).
            var fourthshortestName = products.OrderByDescending(x => x.Length).ToList()[3];
            Console.WriteLine(fourthshortestName);
            //print the ballProduct with the 2nd longest name to the console using an index(you must convert the results to a list using .ToList()).
            var secondlongestName = products.OrderBy(x => x.Length).ToList()[1];
            Console.WriteLine(secondlongestName);
            Console.WriteLine();
            //declare a variable reversedProducts and set it equal to all products ordered by the longest word first. (use the OrderByDecending() extension).
            var reversedProducts = products.OrderByDescending(x => x.Length).ToList();
            //print out the reversedProducts to the console using a foreach loop.
            foreach (var item in reverseProducts)
            {
            Console.WriteLine(item);
            }
            Console.WriteLine();
            //print out all the products ordered by the longest word first using the OrderByDecending() extension and a foreach loop.  
            var longestWord = products.OrderByDescending(x => x.Length).ToList();
            foreach (var item in longestWord)
            {
            Console.Writeline(item);
            }
            //You will not use a variable to store your list

            Console.ReadKey();
        }
    }
}

