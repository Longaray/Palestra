using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Palestras
{
    class Program
    {
        //List for palestrante
        private static List<Palestrante> listPalestrante;

        static void Main(string[] args)
        {
            //List for palestrante
            listPalestrante = new List<Palestrante>();

            //Basic code taken from MSDN
            // Read each line of the file into a string array. Each element
            // of the array is one line of the file.
            string[] lines = System.IO.File.ReadAllLines(@"entrada.txt");

            // Display the file contents by using a foreach loop.
            //System.Console.WriteLine("Contents of WriteLines2.txt = ");
            foreach (string line in lines)
            {
                // Use a tab to indent each line of the file.
                //Console.WriteLine("\t" + line);
                string[] splitLine = line.Split(';');
                listPalestrante.Add(new Palestrante(splitLine[0], Convert.ToInt16(splitLine[1])));

            }

            //DEBUG: eliminate final version
            /*foreach(Palestrante aux in listPalestrante)
            {
                Console.WriteLine(aux.toString());
            }*/

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }
    }
}
