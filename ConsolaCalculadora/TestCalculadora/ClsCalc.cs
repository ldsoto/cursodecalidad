using ConsolaCalculadora;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestCalculadora
{
    [TestClass]
    public class ClsCalc
    {

        public ClsCalc(){}

        [DataRow(4, 4, 8)]
        [DataRow(4, 6, 10)]
        [DataRow(5, 4, 9)]
        [TestMethod]
        public void SumaTest(int a, int b, int esperado)
        {
            //Arrange

            //Act
            int real = ClsCalculadora.Suma(a, b);

            //Assert
            Assert.AreEqual(real, esperado);
        }


        [DataRow(4, 4, 0)]
        [DataRow(4, 6, -2)]
        [DataRow(5, 4, 1)]
        [TestMethod]
        public void RestaTest(int a, int b, int esperado)
        {
            //Arrange

            //Act
            int real = ClsCalculadora.Resta(a, b);

            //Assert
            Assert.AreEqual(real, esperado);

        }

        [DataRow(4, 4, 16)]
        [DataRow(4, 8, 32)]
        [DataRow(5, 4, 20)]
        [TestMethod]
        public void MultiplicacionTest(int a, int b, int esperado)
        {
            //Arrange

            //Act
            int real = ClsCalculadora.Multiplicacion(a, b);

            //Assert
            Assert.AreEqual(real, esperado);
        }

        [DataRow(4, 4, 1)]
        [DataRow(8, 4, 2)]
        [DataRow(16, 4, 4)]
        [TestMethod]
        public void DivisionTest(int a, int b, int esperado)
        {
            //Arrange

            //Act
            double real = ClsCalculadora.Division(a, b);

            //Assert
            Assert.AreEqual(real, esperado);
        }



    }
}
