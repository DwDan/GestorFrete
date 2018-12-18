using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Interface;
using UI;
using GMap.NET;

namespace DwUniSys.Test
{
    [TestClass]
    public class MetodoTest
    {
        [TestMethod]
        public void DateTime_QuandoChamarToVisual_RetornaDataLeitura()
        {
            string ResultadoEsperado = Convert.ToDateTime("17/12/2018").ToVisual();

            string ResultadoReal = "17/12/2018";

            Assert.AreEqual(ResultadoEsperado, ResultadoReal);
        }

        [TestMethod]
        public void DataLeitura_QuandoChamarGetData_RetornaDateTime()
        {
            DateTime ResultadoEsperado = "17/12/2018".GetData();

            DateTime ResultadoReal = Convert.ToDateTime("17/12/2018");

            Assert.AreEqual(ResultadoEsperado, ResultadoReal);
        }

        [TestMethod]
        public void DataInvalida_QuandoChamarGetData_RetornaNewDateTime()
        {
            DateTime ResultadoEsperado = "30/50/2018".GetData();

            DateTime ResultadoReal = new DateTime();

            Assert.AreEqual(ResultadoEsperado, ResultadoReal);
        }

        [TestMethod]
        public void EnderecoValido_QuandoChamarMetodoCoordenadas_RetornaPointLatLngValido()
        {
            PointLatLng ResultadoNaoEsperado = new PointLatLng();

            PointLatLng ResultadoReal = new GetPointLatLng().Coordenadas(new IEndereco()
            {
                LOGRADOURO = "RUA CORCOVADO",
                NUMERO = "702",
                BAIRRO = "MONTE CASTELO",
                MUNICIPIO = "CONTAGEM",
                UF = "MG"
            });

            Assert.AreNotEqual(ResultadoNaoEsperado, ResultadoReal);
        }
    }
}
