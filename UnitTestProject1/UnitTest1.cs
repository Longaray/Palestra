using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palestras;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void UnitTestPalestras_setPalestra()
        {
            Palestrante palestra = new Palestrante("TI INOVATION", 30);

            Assert.AreEqual("TI INOVATION", palestra.getName(), "Nome incorreto");
            Assert.AreEqual(30, palestra.getTime(), "Tempo de palestra incorreto");
            Assert.IsFalse(palestra.getAlocation(), "Alocação incorreta");
        }

        [TestMethod]
        public void UnitTestPalestras_createAgenda()
        {
            List<Palestrante> list = new List<Palestrante>(5);
            list.Add(new Palestrante("TI INOVATION", 30));
            list.Add(new Palestrante("AGILE METHODS", 30));
            list.Add(new Palestrante("MOTIVATIONAL ENVIRONMENT", 60));
            list.Add(new Palestrante("ABOUT CERTIFICATES", 60));
            list.Add(new Palestrante("AUTOMATED TESTS, QUALITY AND YOU", 45));

            Agenda agenda1 = new Agenda();
            List<Palestrante> newList = new List<Palestrante>(list);
            agenda1.DesmarcarTodos(newList);
            int[] turnTimes = new int[1] { 1 };
            //1 dia, 1 turno, 1 hora.
            List<Object> agenda = agenda1.criarAgenda(1, 1, turnTimes, newList);

            Assert.AreEqual("MOTIVATIONAL ENVIRONMENT", (agenda[0] as List<Palestrante>)[0].getName(), "Palestrante 1 incorreto");

            //1 dia, 2 turno, 1 hora.
            newList = new List<Palestrante>(list);
            agenda1.DesmarcarTodos(newList);
            turnTimes = new int[2] { 1,1 };
            agenda = agenda1.criarAgenda(1, 2, turnTimes, newList);
            Assert.AreEqual("MOTIVATIONAL ENVIRONMENT", (agenda[0] as List<Palestrante>)[0].getName(), "Palestrante 1 incorreto");
            Assert.AreEqual("ABOUT CERTIFICATES", (agenda[1] as List<Palestrante>)[0].getName(), "Palestrante 2 incorreto");
        }
    }
}
