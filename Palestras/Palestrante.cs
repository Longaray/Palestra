using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Palestras
{
    public class Palestrante
    {
        private String name;
        private int time;
        private bool alocation;

        public Palestrante(String name, int time) {
            this.name = name;
            this.time = time;
            this.alocation = false;
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public void setTime(int time)
        {
            this.time = time;
        }

        public void setAllocation(bool alocation)
        {
            this.alocation = alocation;
        }

        public String getName()
        {
            return name;
        }

        public int getTime()
        {
            return time;
        }

        public bool getAlocation()
        {
            return alocation;
        }

        public string toString()
        {
            return "Palestrante: "+name+" Tempo: "+time+" minutos.";
        }
    }
}
