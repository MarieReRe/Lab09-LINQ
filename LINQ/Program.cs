using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Linq;
using System;
using LINQ.Classes;
using System.Security.Cryptography.X509Certificates;
using System.IO;

namespace LINQ
{
    public class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            //First we need to connect to the JSON File 
     
        }
        static void ReadData()
        {
            using (StreamReader newYorkNeighborhoods = File.OpenText("LINQ/data.json"))
            {
                string jsonData= newYorkNeighborhoods.ReadLine();
                RootObject deserializedRoot = JsonConvert.DeserializeObject<RootObject>(jsonData);
                newYorkNewYork(deserializedRoot);
            }
           

        }

       
        //output all neighborhoods (147)
        public static void newYorkNewYork(RootObject deserializedRoot)
        {

            
            

        }
    }
}
