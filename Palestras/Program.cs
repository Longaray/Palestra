using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Palestras
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lista de palestras
            List<Palestrante> listPalestras = new List<Palestrante>();

            //Basic code taken from MSDN
            // Read each line of the file into a string array. Each element
            // of the array is one line of the file.
            string[] lines = System.IO.File.ReadAllLines(@"entrada.txt");

            //CRia ocorrencia de palestra com o nome da palestra e tempo
            foreach (string line in lines)
            {
                // Use a tab to indent each line of the file.
                string[] splitLine = line.Split(';');
                listPalestras.Add(new Palestrante(splitLine[0], Convert.ToInt16(splitLine[1])));
            }

            //Cria uma agenda baseada nos criterias de cada agenda
            //Acording to proposed challenge = 2 days, 2 turns of 3h and 4h each.
            Agenda a1 = new Agenda();
            int[] turnTimes = new int[2]{3,4};
            List<Object> agenda = a1.criarAgenda(2, 2, turnTimes, listPalestras);
            a1.showAgenda(agenda);

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }
    }
 }
