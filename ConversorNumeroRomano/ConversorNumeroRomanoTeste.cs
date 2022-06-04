using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConversorNumeroRomano.Teste;

namespace ConversorNumeroRomano
{
    [TestClass]
    public class ConversorNumeroRomanoTeste
    {
        private NumeroRomano numeroRomano;

        [TestMethod]
        [DataRow("I", 1)]
        [DataRow("II", 2)]
        [DataRow("III", 3)]
        [DataRow("IV", 4)]
        [DataRow("V", 5)]
        [DataRow("VI", 6)]
        [DataRow("VII", 7)]
        [DataRow("VIII", 8)]
        [DataRow("IX", 9)]
        [DataRow("X", 10)]

        public void TesteDecimalRomano()
        {            
            numeroRomano = "a";
        }

        [TestMethod]
        [DataRow("I", 1)]
        [DataRow("II", 2)]
        [DataRow("III", 3)]
        [DataRow("IV", 4)]
        [DataRow("V", 5)]
        [DataRow("VI", 6)]
        [DataRow("VII", 7)]
        [DataRow("VIII", 8)]
        [DataRow("IX", 9)]
        [DataRow("X", 10)]

        public void TesteRomanoDecimal()
        {
            numeroRomano = "a";
        }
    }
}
