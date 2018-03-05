using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = @"Text: file.txt(6GB);Some string content
Image: img.bmp(19MB);1920x1080
Text: data.txt(12B);Another string
Movie:logan.2017.mkv(19GB);1920x1080;2h12m";



            string[] separators = {Environment.NewLine};
            string[] items = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in items)
            {
                //Console.WriteLine($"-"+item);
                string[] internal_separators = { ";" };
                string[] file_property_separators = { ":" };
                string[] properties = text.Split(internal_separators, StringSplitOptions.RemoveEmptyEntries);
                string[] fproperties = properties[0].Split(file_property_separators, StringSplitOptions.RemoveEmptyEntries);
                foreach (var fprop in fproperties)
                {
                    Console.WriteLine($"!!!"+fprop);
                }

                    
                //properties[0] = text.Split(internal_separators, StringSplitOptions.RemoveEmptyEntries);




                foreach (var prop in properties)
                {
                    //Console.WriteLine($"--"+prop);
                    //string[] file_property_separators = { ":" };
                    string[] file_properties = text.Split(file_property_separators, StringSplitOptions.RemoveEmptyEntries);

                   // Console.WriteLine(prop);

                    //foreach(var fprop in file_properties)
                    //{
                    //    Console.WriteLine(fprop);
                    //}
                }
            

            }
            Console.ReadKey();
        }
    }
}
