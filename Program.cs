using System;
using System.Collections.Generic;
using System.Linq;

namespace csharp_day1
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Hello, what is your name?");
            // Console.Write("> ");
            // var name = Console.ReadLine();
            // bool validating = true;
            // while (validating)
            // {
            //     Console.WriteLine($@"Hello {name}, how old are you {name}?");
            //     string strAge = Console.ReadLine();
            //     if (int.TryParse(strAge, out int age) && age > 20)
            //     {
            //         Console.WriteLine("Success");
            //         Console.WriteLine("press Q key to exit");
            //         ConsoleKeyInfo key = Console.ReadKey();
            //         if (key.Key == ConsoleKey.Q)
            //         {
            //             validating = false;
            //         }
            //     }
            //     else
            //     {
            //         Console.Clear();
            //         Console.WriteLine("Invalid age");

            //     }
            // }
            Console.ReadKey();
            // int age = 90;
            // float price = 2.900091230910f;
            // decimal whatever = 4.23423423m;

            // String[] names = new String[age];
            // names[0] = "Jim";
            // names[1] = "Tim";
            // names[2] = "Mim";

            // System.Console.WriteLine(names[9]);

            List<string> names = new List<string>();
            names.Add("Jim");
            names.Add("Tim");
            names.Add("Mim");
            names.Add("Kim");


            // for (var i = 0; i < names.Count; i++)
            // {
            //     string n = names[i];
            //     System.Console.WriteLine(n);
            // }
            // foreach (var n in names)
            // {

            // }

            // List<string> choices = new List<string>(){
            //     "boulder",
            //     "parchment",
            //     "sheers"
            // };

            Random rnd = new Random();
            // int index = rnd.Next(choices.Count);

            Dictionary<string, string> choices = new Dictionary<string, string>(){
                {"diet","sadness express"},
                {"",""}
            };

            choices.Add("fast-food", "DQ");
            choices.Add("Healthy", "MuchoSmoothie");
            choices.Add("SitDown", "Longhorn Steakhouse");

            if (choices.ContainsKey("whatever"))
            {
                string choice = choices["whatever"];
            }
            else
            {
                var keys = choices.Keys;
                int randKey = rnd.Next(keys.Count);
                System.Console.WriteLine(choices.ElementAt(randKey).Value);
            }
        }
    }
}
