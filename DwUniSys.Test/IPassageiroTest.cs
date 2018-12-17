using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Interface;
using GMap.NET;

namespace DwUniSys.Test
{
    [TestClass]
    public class IPassageiroTest
    {
        [TestMethod]
        public void Coordenadas_QuandoObterCoordenadas_DeveRetornarNovoPontoLatitudeLongitudeValidos()
        {
            IPassageiro IPassageiro = new IPassageiro();
            IPassageiro.I0_LATITUDE = -19.982513;
            IPassageiro.I0_LONGITUDE = -43.9456905;

            PointLatLng ResultadoEsperado = new PointLatLng() { Lat = -19.982513, Lng = -43.9456905 };

            PointLatLng ResultadoReal = IPassageiro.I0_COORDENADAS;

            Assert.AreEqual(ResultadoEsperado, ResultadoReal);
        }
    }
}
