using System.ComponentModel;
using System.Globalization;

namespace CAS_7_LINQ_HOMEWORK
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            //C# Advanced-07 LINQ Homework & Exercises

            //1.Select numbers from range
            //Create an list of integers, write a linq query that process that list and print list of numbers
            //greater than 40 and less than 70.
            //Input: [79, 1, 6, 54, 48, 22, 82, 74, 77, 81, 20, 60, 65, 86, 100]
            //Expected output: 54 48 60 65

            List<int> Range = new List<int> { 79, 1, 6, 54, 48, 22, 82, 74, 77, 81, 20, 60, 65, 86, 100 };

            var FilteredNumbers = Range.Where(number => number > 40 && number < 70).ToList();
            foreach (int numbers in FilteredNumbers)
            {
                Console.WriteLine(numbers);
            }

            //2.Minimum length to uppercase
            //Create list of animals.Write a linq query to process that list and print names that is at least 6
            //characters long and make them uppercase.
            //Input: "ant", "cat", "cow", "dog", "elephant", "horse", "kangaroo", "lion",
            //            "sheep", "tiger", "wolf"
            //Expected output: "ELEPHANT", "KANGAROO"
            Console.WriteLine("---------------------------");
            List<string> Animals = new List<string> { "ant", "cat", "cow", "dog", "elephant", "horse", "kangaroo", "lion" };

            var AnimalsWrite = Animals.Where(animal => animal.Length >= 6).Select(animal => animal.ToUpper()).ToList();

            foreach (string animal in AnimalsWrite)
            {

                Console.WriteLine(animal);
            }

            //3.Select words with condition
            //Write a linq query for process list of animals and print names of animal starting with letter 'h'
            //and ending with letter 'e'.
            //Input: "ant", "cat", "cow", "dog", "elephant", "horse", "kangaroo", "lion",
            //"sheep", "tiger", "wolf"
            //Expected output:"horse", "hare" 

            Console.WriteLine("---------------------------");
            List<string> Animals2 = new List<string> { "ant", "cat", "cow", "dog", "elephant", "horse", "kangaroo", "lion", "hare" };

            var AnimalsLetter = Animals2.Where(anima => anima.StartsWith("h")).Where(anima => anima.EndsWith("e")).ToList();

            foreach (string anim in AnimalsLetter)
            {

                Console.WriteLine(anim);
            }

            //4.Top 5 numbers in descend order
            //Write a linq query that process list of integers and print top 5 numbers in descending order.
            //Input: [79, 1, 6, 54, 48, 22, 82, 74, 77, 81, 20, 60, 65, 86, 100]
            //Expected output: 100 86 82 81 79

            Console.WriteLine("---------------------------");
            List<int> Brojke = new List<int> { 79, 1, 6, 54, 48, 22, 82, 74, 77, 81, 20, 60, 65, 86, 100 };

            var Top5 = Brojke.OrderByDescending(broj => broj).Take(5).ToList();

            foreach (int broj in Top5)
            {

                Console.WriteLine(broj);
            }





            //5.Numbers that square is greater than 7000
            //Write a linq query that from list of integers print list of numbers and their squares only if square
            //is greater than 7000
            //Input: [79, 1, 6, 54, 48, 22, 82, 74, 77, 81, 20, 60, 65, 86, 100]
            //Expected output: 86 - 7396, 100 - 10000

            Console.WriteLine("---------------------------");
            List<int> Broevi = new List<int> { 79, 1, 6, 54, 48, 22, 82, 74, 77, 81, 20, 60, 65, 86, 100 };

            var SquareNumber = Brojke.Where(num => num * num >= 7000).ToList();

            foreach (int broj in SquareNumber)
            {

                Console.WriteLine($"Number {broj} with expected output {broj * broj}");
            }




            //6.Replace substring
            //Write a linq query for process list of animals and print names of animal with replaced 'an'
            //substring with asterisk(*).
            //Input: "ant", "cat", "cow", "dog", "elephant", "horse", "kangaroo", "lion",
            //"sheep", "tiger", "wolf"
            //Expected output: "*t", "cat", "cow", "dog", "eleph*t", "horse", "k*garoo",
            //"hare", "sheep", "tiger", "wolf"

            Console.WriteLine("---------------------------");
            List<string> Animals3 = new List<string> { "ant", "cat", "cow", "dog", "elephant", "horse", "kangaroo", "lion", };

            var AnimalsReplaced = Animals3.Select(ani => ani.Replace("an", "*")).ToList();
            //var AnimalsReplaced = Animals3.Select(ani => ani.Contains("an") ? ani.Replace("an", "*"):ani).ToList();


            foreach (string anim in AnimalsReplaced)
            {

                Console.WriteLine(anim);
            }
            //7.Last word containing letter
            //Write a linq query for process list of animals which sort list alphabetically and print last name
            //that contains letter 'e'.
            //Input: "ant", "cat", "cow", "dog", "elephant", "horse", "kangaroo", "lion",
            //"sheep", "tiger", "wolf"
            //Expected output:"tiger"

            Console.WriteLine("---------------------------");
            List<string> Animals4 = new List<string> { "ant", "cat", "cow", "dog", "elephant", "horse", "kangaroo", "lion",
             "sheep", "tiger", "wolf" };


            var AnimalsAlphabet = Animals4.Where(ani => ani.Contains("e")).OrderBy(ani => ani).Last();

            //var AnimalsAlphabet = Animals4.OrderBy(x => x)
            //                     .LastOrDefault(w => w.Contains("e"));
            
            Console.WriteLine(AnimalsAlphabet); // tiger

            //            Shuffle an sorted array(medium)
            //Write a linq query that shuffles sorted array or list and print result.
            //Input: [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15]
            //Expected output: 9 11 12 10 3 6 1 14 8 5 4 15 13 2 7(Each time different
            //order...)

               Console.WriteLine("---------------------------");
               var rand = new Random();

            int[] numberArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

               int[] Shuffle = numberArray.OrderBy(p => rand.Next()).ToArray();


               foreach(int item in Shuffle)
              {
                  Console.WriteLine(item);
              }
            
        }
    }
}