using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Palestras
{
    public class Agenda
    {
        //Metodo de criacao da agenda
        public List<Object> criarAgenda(int days, int turns, int[] turnTimes, List<Palestrante> list)
        {
            //Order the list by event time from biggest to shortest
            for (int i = 0; i < list.Count; i++)
            {
                Palestrante aux = list[i];
                for (int j = 0; j < list.Count; j++)
                {
                    Palestrante aux2 = list[j];
                    if (aux2.getTime() < aux.getTime())
                    {
                        list[i] = aux2;
                        list[j] = aux;
                        aux = aux2;
                    }
                }
            }

            int totalEventsRemaining = list.Count;

            List<int> eventDays = new List<int>(days * turns);
            List<Palestrante> palestraList;
            List<Object> turnList = new List<Object>();
            int turnsRemaining = days * turns;
            //Enquanto ha palestras nao agendadas
            while (totalEventsRemaining > 0 && turnsRemaining > 0)
            {
                //para cada turno do evento
                for (int i = 0; i < turns; i++)
                {
                    //transforma horas de cada turno em minutos
                    int timeRemainingPerTurn = turnTimes[i] * 60;
                    palestraList = new List<Palestrante>();

                    //para cada palestra na lista
                    foreach (Palestrante palestra in list)
                    {
                        //se a palestra nao excede o tempo restante e ja nao estiver agendada
                        if (palestra.getTime() <= timeRemainingPerTurn && !palestra.getAlocation())
                        {
                            palestraList.Add(palestra);
                            timeRemainingPerTurn = timeRemainingPerTurn - palestra.getTime();
                            palestra.setAllocation(true);
                            totalEventsRemaining--;
                        }
                    }
                    //agenda palestra
                    turnList.Add(palestraList);
                    turnsRemaining--;
                }
            }

            //retorna a agenda
            return turnList;
        }

        //Metodo para exibição da Agenda
        public void showAgenda(List<Object> turnList)
        {
            int day = 1;
            DateTime startTime = DateTime.Now;

            //para cada turno
            for (int j = 0; j < turnList.Count; j++)
            {
                //Turno impar e manha turno par e de tarde
                if (j % 2 == 0)
                {
                    //começa de manha as 9h
                    startTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 9, 0, 0);
                    Console.WriteLine("Dia " + day + ":");
                    Console.WriteLine("Manhâ:");
                    day++;
                }
                else
                {
                    Console.WriteLine("Tarde:");
                }

                List<Palestrante> auxPalestraList = turnList[j] as List<Palestrante>;
                {
                    foreach (Palestrante aux in auxPalestraList)
                    {
                        Console.WriteLine(startTime.ToString("HH:mm") + " " + aux.toString());
                        startTime = startTime.AddMinutes(aux.getTime());
                    }
                }

                if (j % 2 == 0)
                {
                    Console.WriteLine(startTime.ToString("HH:mm") + " Almoço");
                    startTime = startTime.AddMinutes(60);
                }
                else
                {
                    Console.WriteLine(startTime.ToString("HH:mm") + " Dúvidas e Debates");
                }
            }
        }

        //Desmarca todos os eventos
        public void DesmarcarTodos(List<Palestrante> list)
        {
            //para cada palestra na lista
            foreach (Palestrante palestra in list)
            {
                palestra.setAllocation(false);
            }
        }
    }
}