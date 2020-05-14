
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

            /*
             * Filter out all the neighborhoods that do not have any names (Final Total: 143)
                 Remove the duplicates (Final Total: 39 neighborhoods)
            Rewrite the queries from above and consolidate all into one single query.
            Rewrite at least one of these questions only using the opposing method (example: Use LINQ Query statements instead of LINQ method calls and vice versa.)
             */
        }
    }

}
