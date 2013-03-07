using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _002_Calculadora;

namespace _004_Teste
{
    [TestClass]
    public class CalculadoraTest
    {
        /// <summary>
        ///A test for Somar
        ///</summary>
        [TestMethod()]
        public void SomarTest()
        {
            double x = 1.0; // TODO: Initialize to an appropriate value
            double y = 2.0; // TODO: Initialize to an appropriate value
            double expected = 3.0; // TODO: Initialize to an appropriate value
            double actual;
            actual = Calculadora.Somar(x, y);
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Dividir
        ///</summary>
        [TestMethod()]
        public void DividirTest()
        {
            double x = 1F; // TODO: Initialize to an appropriate value
            double y = 2F; // TODO: Initialize to an appropriate value
            double expected = 0.5F; // TODO: Initialize to an appropriate value
            double actual;
            actual = Calculadora.Dividir(x, y);
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Multiplicar
        ///</summary>
        [TestMethod()]
        public void MultiplicarTest()
        {
            double x = 2F; // TODO: Initialize to an appropriate value
            double y = 3F; // TODO: Initialize to an appropriate value
            double expected = 6F; // TODO: Initialize to an appropriate value
            double actual;
            actual = Calculadora.Multiplicar(x, y);
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Subtrair
        ///</summary>
        [TestMethod()]
        public void SubtrairTest()
        {
            double x = 1F; // TODO: Initialize to an appropriate value
            double y = 2F; // TODO: Initialize to an appropriate value
            double expected = -1F; // TODO: Initialize to an appropriate value
            double actual;
            actual = Calculadora.Subtrair(x, y);
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
