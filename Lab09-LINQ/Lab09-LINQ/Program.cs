
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Linq;
using System;
using System.Security.Cryptography.X509Certificates;
using System.IO;
using System.Collections.Generic;


namespace Lab09_LINQ
{
    public class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ReadData();

            //First we need to connect to the JSON File 

        }
      static void ReadData()
        {
            using StreamReader newYorkNeighborhoods = File.OpenText("../../../json1.json");
            string jsonData = newYorkNeighborhoods.ReadLine();
            RootObject deserializedRoot = JsonConvert.DeserializeObject<RootObject>(jsonData);
            NewYorkNewYork(deserializedRoot);


        }


        //output all neighborhoods (147)
       static void NewYorkNewYork(RootObject deserializedRoot)
        {
            //Q 1
            var questionOne = from neighborhood in deserializedRoot.features
                              select neighborhood;

            int count = 0;
            foreach (var answer in questionOne)
            {
                count++;
                Console.WriteLine($"{answer.properties.neighborhood}");
            }
            Console.WriteLine($"Total neighborhood: {count}");

       
         
            Console.WriteLine("====== Q2 ==========");
            //Filter out all the neighborhoods that do not have any names (Final Total: 143)

            var questionTwo = questionOne.Where(x => x.properties.neighborhood != "");
             count = 0;

            foreach(var item in questionTwo)
            {
                count++;
                Console.WriteLine($"{item.properties.neighborhood}");
            }
            Console.WriteLine($"Total neighborhoods with names: {count}");


            Console.WriteLine("====== Q3 ==========");
            // Remove the duplicates (Final Total: 39 neighborhoods)
            var questionThree = questionOne.GroupBy(x => x.properties.neighborhood).Select(group => group.First());
            count = 0;
            foreach(var item in questionThree)
            {
                count++;
                Console.WriteLine($"{item.properties.neighborhood}");
            }
            Console.WriteLine($"Total neighborhoods that do not repeat: {count}");

            Console.WriteLine("====== Q4 ==========");
            // Rewrite the queries from above and consolidate all into one single query.
            

            Console.WriteLine("====== Q5 ==========");
            //Rewrite at least one of these questions only using the opposing method (example: Use LINQ Query statements instead of LINQ method calls and vice versa.)
        }
    }

}
