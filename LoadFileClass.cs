using System;
using Newtonsoft.Json.Linq;
using System.IO;
namespace MalamProject
{
    public class LoadFileClass
    {
        //public void loadFile(string filePath)

        public void loadFile(string filePath)
        {
            if (System.IO.File.Exists(filePath) == true)
            {
                Console.WriteLine("The File Exist");
                string jsonFromFile = File.ReadAllText(filePath);
                try
                {
                    JToken token = JObject.Parse(jsonFromFile);
                    Console.WriteLine("The Json File Is Valid, the content is: " + token);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                Console.WriteLine("The File Not Exist");
            }
        }
    }
}
